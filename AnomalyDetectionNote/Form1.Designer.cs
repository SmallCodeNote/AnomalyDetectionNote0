namespace AnomalyDetectionNote
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_Train = new System.Windows.Forms.Button();
            this.button_Predict = new System.Windows.Forms.Button();
            this.trackBar_windowSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_threshold = new System.Windows.Forms.TrackBar();
            this.label_thresholdTitle = new System.Windows.Forms.Label();
            this.label_windowSizeValue = new System.Windows.Forms.Label();
            this.label_thresholdValue = new System.Windows.Forms.Label();
            this.chart_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_windowSizeList = new System.Windows.Forms.TextBox();
            this.textBox_TrainDataDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PredictDataDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ModelFilePath = new System.Windows.Forms.TextBox();
            this.button_ModelFilePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_windowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Train
            // 
            this.button_Train.Location = new System.Drawing.Point(12, 12);
            this.button_Train.Name = "button_Train";
            this.button_Train.Size = new System.Drawing.Size(123, 57);
            this.button_Train.TabIndex = 1;
            this.button_Train.Text = "Train";
            this.button_Train.UseVisualStyleBackColor = true;
            this.button_Train.Click += new System.EventHandler(this.button_Train_Click);
            // 
            // button_Predict
            // 
            this.button_Predict.Location = new System.Drawing.Point(12, 101);
            this.button_Predict.Name = "button_Predict";
            this.button_Predict.Size = new System.Drawing.Size(123, 57);
            this.button_Predict.TabIndex = 1;
            this.button_Predict.Text = "Predict";
            this.button_Predict.UseVisualStyleBackColor = true;
            this.button_Predict.Click += new System.EventHandler(this.button_Predict_Click);
            // 
            // trackBar_windowSize
            // 
            this.trackBar_windowSize.Location = new System.Drawing.Point(174, 30);
            this.trackBar_windowSize.Name = "trackBar_windowSize";
            this.trackBar_windowSize.Size = new System.Drawing.Size(222, 56);
            this.trackBar_windowSize.TabIndex = 2;
            this.trackBar_windowSize.Scroll += new System.EventHandler(this.trackBar_windowSize_Scroll);
            this.trackBar_windowSize.ValueChanged += new System.EventHandler(this.trackBar_windowSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "windowSize";
            // 
            // trackBar_threshold
            // 
            this.trackBar_threshold.Location = new System.Drawing.Point(174, 119);
            this.trackBar_threshold.Name = "trackBar_threshold";
            this.trackBar_threshold.Size = new System.Drawing.Size(222, 56);
            this.trackBar_threshold.TabIndex = 2;
            this.trackBar_threshold.Scroll += new System.EventHandler(this.trackBar_threshold_Scroll);
            this.trackBar_threshold.ValueChanged += new System.EventHandler(this.trackBar_threshold_Scroll);
            // 
            // label_thresholdTitle
            // 
            this.label_thresholdTitle.AutoSize = true;
            this.label_thresholdTitle.Location = new System.Drawing.Point(172, 101);
            this.label_thresholdTitle.Name = "label_thresholdTitle";
            this.label_thresholdTitle.Size = new System.Drawing.Size(66, 15);
            this.label_thresholdTitle.TabIndex = 3;
            this.label_thresholdTitle.Text = "threshold";
            // 
            // label_windowSizeValue
            // 
            this.label_windowSizeValue.AutoSize = true;
            this.label_windowSizeValue.Location = new System.Drawing.Point(402, 33);
            this.label_windowSizeValue.Name = "label_windowSizeValue";
            this.label_windowSizeValue.Size = new System.Drawing.Size(15, 15);
            this.label_windowSizeValue.TabIndex = 3;
            this.label_windowSizeValue.Text = "-";
            // 
            // label_thresholdValue
            // 
            this.label_thresholdValue.AutoSize = true;
            this.label_thresholdValue.Location = new System.Drawing.Point(402, 122);
            this.label_thresholdValue.Name = "label_thresholdValue";
            this.label_thresholdValue.Size = new System.Drawing.Size(15, 15);
            this.label_thresholdValue.TabIndex = 3;
            this.label_thresholdValue.Text = "-";
            // 
            // chart_Graph
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_Graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_Graph.Legends.Add(legend3);
            this.chart_Graph.Location = new System.Drawing.Point(12, 181);
            this.chart_Graph.Name = "chart_Graph";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_Graph.Series.Add(series3);
            this.chart_Graph.Size = new System.Drawing.Size(860, 426);
            this.chart_Graph.TabIndex = 4;
            this.chart_Graph.Text = "chart1";
            // 
            // textBox_windowSizeList
            // 
            this.textBox_windowSizeList.Location = new System.Drawing.Point(437, 30);
            this.textBox_windowSizeList.Name = "textBox_windowSizeList";
            this.textBox_windowSizeList.Size = new System.Drawing.Size(417, 22);
            this.textBox_windowSizeList.TabIndex = 5;
            // 
            // textBox_TrainDataDir
            // 
            this.textBox_TrainDataDir.Location = new System.Drawing.Point(12, 656);
            this.textBox_TrainDataDir.Name = "textBox_TrainDataDir";
            this.textBox_TrainDataDir.Size = new System.Drawing.Size(806, 22);
            this.textBox_TrainDataDir.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 638);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "TrainDataDir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "PredictDataDir";
            // 
            // textBox_PredictDataDir
            // 
            this.textBox_PredictDataDir.Location = new System.Drawing.Point(12, 742);
            this.textBox_PredictDataDir.Name = "textBox_PredictDataDir";
            this.textBox_PredictDataDir.Size = new System.Drawing.Size(806, 22);
            this.textBox_PredictDataDir.TabIndex = 5;
            this.textBox_PredictDataDir.TextChanged += new System.EventHandler(this.textBox_PredictDataDir_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 681);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ModelFilePath";
            // 
            // textBox_ModelFilePath
            // 
            this.textBox_ModelFilePath.Location = new System.Drawing.Point(12, 699);
            this.textBox_ModelFilePath.Name = "textBox_ModelFilePath";
            this.textBox_ModelFilePath.Size = new System.Drawing.Size(775, 22);
            this.textBox_ModelFilePath.TabIndex = 5;
            this.textBox_ModelFilePath.TextChanged += new System.EventHandler(this.textBox_PredictDataDir_TextChanged);
            // 
            // button_ModelFilePath
            // 
            this.button_ModelFilePath.Location = new System.Drawing.Point(790, 699);
            this.button_ModelFilePath.Name = "button_ModelFilePath";
            this.button_ModelFilePath.Size = new System.Drawing.Size(27, 25);
            this.button_ModelFilePath.TabIndex = 6;
            this.button_ModelFilePath.Text = "...";
            this.button_ModelFilePath.UseVisualStyleBackColor = true;
            this.button_ModelFilePath.Click += new System.EventHandler(this.button_ModelFilePath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 863);
            this.Controls.Add(this.button_ModelFilePath);
            this.Controls.Add(this.textBox_ModelFilePath);
            this.Controls.Add(this.textBox_PredictDataDir);
            this.Controls.Add(this.textBox_TrainDataDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_windowSizeList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_Graph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_thresholdTitle);
            this.Controls.Add(this.label_thresholdValue);
            this.Controls.Add(this.label_windowSizeValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_threshold);
            this.Controls.Add(this.trackBar_windowSize);
            this.Controls.Add(this.button_Predict);
            this.Controls.Add(this.button_Train);
            this.Name = "Form1";
            this.Text = "AnomalyDetectionNote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_windowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Train;
        private System.Windows.Forms.Button button_Predict;
        private System.Windows.Forms.TrackBar trackBar_windowSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_threshold;
        private System.Windows.Forms.Label label_thresholdTitle;
        private System.Windows.Forms.Label label_windowSizeValue;
        private System.Windows.Forms.Label label_thresholdValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Graph;
        private System.Windows.Forms.TextBox textBox_windowSizeList;
        private System.Windows.Forms.TextBox textBox_TrainDataDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PredictDataDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ModelFilePath;
        private System.Windows.Forms.Button button_ModelFilePath;
    }
}

