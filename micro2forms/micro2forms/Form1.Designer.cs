namespace micro2forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TemperatureGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TitleOfGraph = new System.Windows.Forms.Label();
            this.dataGridViewTemperature = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SelectCOM = new System.Windows.Forms.Label();
            this.cBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rTextTemp = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.TemperatureGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TemperatureGraph.Legends.Add(legend1);
            this.TemperatureGraph.Location = new System.Drawing.Point(492, 89);
            this.TemperatureGraph.Name = "TemperatureGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            this.TemperatureGraph.Series.Add(series1);
            this.TemperatureGraph.Size = new System.Drawing.Size(606, 301);
            this.TemperatureGraph.TabIndex = 0;
            this.TemperatureGraph.Text = "Temperature Graph";
            // 
            // TitleOfGraph
            // 
            this.TitleOfGraph.AutoSize = true;
            this.TitleOfGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOfGraph.Location = new System.Drawing.Point(12, 9);
            this.TitleOfGraph.Name = "TitleOfGraph";
            this.TitleOfGraph.Size = new System.Drawing.Size(381, 39);
            this.TitleOfGraph.TabIndex = 1;
            this.TitleOfGraph.Text = "Temperature readings ";
            // 
            // dataGridViewTemperature
            // 
            this.dataGridViewTemperature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemperature.Location = new System.Drawing.Point(13, 187);
            this.dataGridViewTemperature.Name = "dataGridViewTemperature";
            this.dataGridViewTemperature.RowHeadersWidth = 51;
            this.dataGridViewTemperature.RowTemplate.Height = 24;
            this.dataGridViewTemperature.Size = new System.Drawing.Size(474, 203);
            this.dataGridViewTemperature.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 396);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(209, 62);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(227, 396);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(209, 62);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // SelectCOM
            // 
            this.SelectCOM.AutoSize = true;
            this.SelectCOM.Location = new System.Drawing.Point(21, 60);
            this.SelectCOM.Name = "SelectCOM";
            this.SelectCOM.Size = new System.Drawing.Size(112, 17);
            this.SelectCOM.TabIndex = 5;
            this.SelectCOM.Text = "Select COM Port";
            // 
            // cBoxCOMPort
            // 
            this.cBoxCOMPort.FormattingEnabled = true;
            this.cBoxCOMPort.Location = new System.Drawing.Point(153, 57);
            this.cBoxCOMPort.Name = "cBoxCOMPort";
            this.cBoxCOMPort.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOMPort.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Temp (C)";
            // 
            // rTextTemp
            // 
            this.rTextTemp.Location = new System.Drawing.Point(254, 106);
            this.rTextTemp.Name = "rTextTemp";
            this.rTextTemp.Size = new System.Drawing.Size(139, 59);
            this.rTextTemp.TabIndex = 8;
            this.rTextTemp.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 470);
            this.Controls.Add(this.rTextTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxCOMPort);
            this.Controls.Add(this.SelectCOM);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.dataGridViewTemperature);
            this.Controls.Add(this.TitleOfGraph);
            this.Controls.Add(this.TemperatureGraph);
            this.Name = "Form1";
            this.Text = "Temperature Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TemperatureGraph;
        private System.Windows.Forms.Label TitleOfGraph;
        private System.Windows.Forms.DataGridView dataGridViewTemperature;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label SelectCOM;
        private System.Windows.Forms.ComboBox cBoxCOMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTextTemp;
    }
}

