﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;
using Microsoft.ML.TimeSeries;

using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

using WinFormStringCnvClass;

namespace AnomalyDetectionNote
{
    public partial class Form1 : Form
    {
        string thisExeDirPath;

        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

            InitarizeChart();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
            }
        }

        private void button_Train_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_TrainData = new OpenFileDialog();
            ofd_TrainData.Title = "TrainData";
            ofd_TrainData.Filter = "TEXT|*.txt|CSV|*.csv|TSV|*.tsv";
            if (ofd_TrainData.ShowDialog() != DialogResult.OK) return;

            SaveFileDialog sfd_ModelFile = new SaveFileDialog();
            sfd_ModelFile.Title = "SaveModel";
            sfd_ModelFile.Filter = "ZIP|*.zip";
            sfd_ModelFile.FileName = "model.zip";
            if (sfd_ModelFile.ShowDialog() != DialogResult.OK) return;

            MLContext mlContext = new MLContext();

            // Load Data
            SetChartGraphLine(File.ReadAllText(ofd_TrainData.FileName));
            IDataView dataView = mlContext.Data.LoadFromTextFile<TimeSeriesData>(path: ofd_TrainData.FileName, hasHeader: true, separatorChar: '\t');

            // 異常検出パイプラインの定義
            int windowSizeParam = (int)Math.Pow(2, ((TrackBar)sender).Value);
            double thresholdParam = (((TrackBar)sender).Value / 10.0);
            var pipeline = mlContext.Transforms.DetectAnomalyBySrCnn(outputColumnName: "Prediction", inputColumnName: "value", windowSize: windowSizeParam, judgementWindowSize: windowSizeParam, threshold: thresholdParam);

            // モデルの訓練
            var model = pipeline.Fit(dataView);

            mlContext.Model.Save(model, dataView.Schema, sfd_ModelFile.FileName);

        }

        private void button_Predict_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_LoadModel = new OpenFileDialog();
            ofd_LoadModel.Title = "LoadModel";
            ofd_LoadModel.Filter = "ZIP|*.zip";
            if (ofd_LoadModel.ShowDialog() != DialogResult.OK) return;

            OpenFileDialog ofd_LoadData = new OpenFileDialog();
            ofd_LoadData.Title = "LoadData";
            ofd_LoadData.Filter = "TEXT|*.txt|CSV|*.csv|TSV|*.tsv";
            if (ofd_LoadData.ShowDialog() != DialogResult.OK) return;

            MLContext mlContext = new MLContext();
            ITransformer model = mlContext.Model.Load(ofd_LoadModel.FileName, out var modelSchema);

            SetChartGraphLine(File.ReadAllText(ofd_LoadData.FileName));
            IDataView dataView2 = mlContext.Data.LoadFromTextFile<TimeSeriesData>(path: ofd_LoadData.FileName, hasHeader: true, separatorChar: '\t');

            // 異常検出の実行
            var transformedData = model.Transform(dataView2);

            // 結果の取得
            var predictions = mlContext.Data.CreateEnumerable<TimeSeriesPrediction>(transformedData, reuseRowObject: false).ToList();

            // 結果の表示
            foreach (var p in predictions)
            {
                Console.WriteLine($"Prediction: {p.Prediction[0]}");
            }

            for (int dataIndex = 0; dataIndex < predictions.Count; dataIndex++)
            {
                if ((predictions[dataIndex]).Prediction[0] > 0.3)
                {
                    chartGraph_Point.Points.Add(chartGraph_Line.Points[dataIndex]);
                }
            }


        }

        private void trackBar_threshold_Scroll(object sender, EventArgs e)
        {
            label_thresholdValue.Text = (((TrackBar)sender).Value / 10.0).ToString();
        }

        private void trackBar_windowSize_Scroll(object sender, EventArgs e)
        {
            label_windowSizeValue.Text = Math.Pow(2, ((TrackBar)sender).Value).ToString();
        }

        Series chartGraph_Line;
        Series chartGraph_Point;
        private void InitarizeChart()
        {
            chartGraph_Line = new Series("Line");
            chartGraph_Line.ChartType = SeriesChartType.Line;
            chartGraph_Point = new Series("Point");
            chartGraph_Point.ChartType = SeriesChartType.Point;

            chart_Graph.Series.Clear();
            chart_Graph.Series.Add(chartGraph_Line);
            chart_Graph.Series.Add(chartGraph_Point);

            var chartArea = new ChartArea("ChartArea1");
            chart_Graph.ChartAreas.Clear();
            chart_Graph.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Format = "yyyy/MM";
            chartArea.AxisX.Title = "Time";
            chartArea.AxisY.Title = "Value";

        }

        private void SetChartGraphLine(string data)
        {

            string[] lines = data.Replace("\r\n", "\n").Split('\n');


            foreach (var line in lines)
            {
                if (line.StartsWith("time")) continue; // Skip the header line

                var parts = line.Split('\t');
                if (parts.Length != 2) continue; // Skip lines with wrong format

                string time = parts[0];
                double value = double.Parse(parts[1]);

                chartGraph_Line.Points.AddXY(time, value);
            }

        }

        private void SetChartGraphPoint(string time, double value)
        {
            chartGraph_Point.Points.AddXY(time, value);

        }


        private void textBox_PredictDataDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ModelFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ZIP|*.zip";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            textBox_ModelFilePath.Text = ofd.FileName;

        }
    }

    public class TimeSeriesData
    {
        [LoadColumn(0)]
        public string time;

        [LoadColumn(1)]
        public float value;
    }

    public class TimeSeriesPrediction
    {
        [VectorType]
        ///Prediction[0]：異常スコア（Anomaly Score）Prediction[1]：異常の原始スコア（Raw Score）Prediction[2]：異常の大きさ（Magnitude）
        public double[] Prediction { get; set; }

    }

}