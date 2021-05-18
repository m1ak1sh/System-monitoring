namespace Laba1
{
    partial class FormSystemMonitor
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbCPU = new MetroFramework.Controls.MetroProgressBar();
            this.pbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblEstablishedV = new MetroFramework.Controls.MetroLabel();
            this.lblAvalibleV = new MetroFramework.Controls.MetroLabel();
            this.lblUseV = new MetroFramework.Controls.MetroLabel();
            this.chartCPURAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.lblCPUValue = new MetroFramework.Controls.MetroLabel();
            this.lblRAMValue = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(244, 114);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(450, 71);
            this.pbCPU.TabIndex = 0;
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(244, 203);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(450, 73);
            this.pbRAM.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(153, 140);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(28, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ЦП";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(145, 233);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "ОЗУ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 298);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Используется:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 317);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Доступно:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 336);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(91, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Установлено:";
            // 
            // lblEstablishedV
            // 
            this.lblEstablishedV.AutoSize = true;
            this.lblEstablishedV.Location = new System.Drawing.Point(153, 298);
            this.lblEstablishedV.Name = "lblEstablishedV";
            this.lblEstablishedV.Size = new System.Drawing.Size(78, 19);
            this.lblEstablishedV.TabIndex = 7;
            this.lblEstablishedV.Text = "значение 1";
            // 
            // lblAvalibleV
            // 
            this.lblAvalibleV.AutoSize = true;
            this.lblAvalibleV.Location = new System.Drawing.Point(153, 317);
            this.lblAvalibleV.Name = "lblAvalibleV";
            this.lblAvalibleV.Size = new System.Drawing.Size(78, 19);
            this.lblAvalibleV.TabIndex = 8;
            this.lblAvalibleV.Text = "значение 2";
            // 
            // lblUseV
            // 
            this.lblUseV.AutoSize = true;
            this.lblUseV.Location = new System.Drawing.Point(153, 336);
            this.lblUseV.Name = "lblUseV";
            this.lblUseV.Size = new System.Drawing.Size(78, 19);
            this.lblUseV.TabIndex = 9;
            this.lblUseV.Text = "значение 3";
            // 
            // chartCPURAM
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.chartCPURAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPURAM.Legends.Add(legend1);
            this.chartCPURAM.Location = new System.Drawing.Point(40, 394);
            this.chartCPURAM.Name = "chartCPURAM";
            this.chartCPURAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 9;
            series1.MarkerSize = 9;
            series1.MarkerStep = 9;
            series1.Name = "ЦП";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 9;
            series2.Name = "ОЗУ";
            this.chartCPURAM.Series.Add(series1);
            this.chartCPURAM.Series.Add(series2);
            this.chartCPURAM.Size = new System.Drawing.Size(669, 204);
            this.chartCPURAM.TabIndex = 10;
            this.chartCPURAM.Text = "chart1";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_total";
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Memory";
            this.pcRAM.CounterName = "% Committed Bytes in Use";
            // 
            // lblCPUValue
            // 
            this.lblCPUValue.AutoSize = true;
            this.lblCPUValue.Location = new System.Drawing.Point(701, 140);
            this.lblCPUValue.Name = "lblCPUValue";
            this.lblCPUValue.Size = new System.Drawing.Size(101, 19);
            this.lblCPUValue.TabIndex = 11;
            this.lblCPUValue.Text = "значение ЦП%";
            // 
            // lblRAMValue
            // 
            this.lblRAMValue.AutoSize = true;
            this.lblRAMValue.Location = new System.Drawing.Point(701, 233);
            this.lblRAMValue.Name = "lblRAMValue";
            this.lblRAMValue.Size = new System.Drawing.Size(109, 19);
            this.lblRAMValue.TabIndex = 12;
            this.lblRAMValue.Text = "значение ОЗУ%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSystemMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 639);
            this.Controls.Add(this.lblRAMValue);
            this.Controls.Add(this.lblCPUValue);
            this.Controls.Add(this.chartCPURAM);
            this.Controls.Add(this.lblUseV);
            this.Controls.Add(this.lblAvalibleV);
            this.Controls.Add(this.lblEstablishedV);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.pbCPU);
            this.Name = "FormSystemMonitor";
            this.Text = "Системный монитор";
            this.Load += new System.EventHandler(this.FormSystemMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPURAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pbCPU;
        private MetroFramework.Controls.MetroProgressBar pbRAM;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblEstablishedV;
        private MetroFramework.Controls.MetroLabel lblAvalibleV;
        private MetroFramework.Controls.MetroLabel lblUseV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPURAM;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Diagnostics.PerformanceCounter pcRAM;
        private MetroFramework.Controls.MetroLabel lblCPUValue;
        private MetroFramework.Controls.MetroLabel lblRAMValue;
        private System.Windows.Forms.Timer timer1;
    }
}