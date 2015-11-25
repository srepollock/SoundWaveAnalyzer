﻿namespace FinalProject_v3
{
    partial class InputForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.freqLabel = new System.Windows.Forms.Label();
            this.freqUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HFTChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ampLabel = new System.Windows.Forms.Label();
            this.ampUpDown = new System.Windows.Forms.NumericUpDown();
            this.addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sampLabel = new System.Windows.Forms.Label();
            this.sampUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.freqWaveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.filterAudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welchWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotFrequencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descreteFourierTransformThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threads1MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.threads2MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.threads3MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.threads4MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ampUpDownLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.newFreqBtn = new System.Windows.Forms.Button();
            this.newFreqLabel = new System.Windows.Forms.Label();
            this.newFreqUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HFTChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampUpDown)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqWaveChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFreqUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.52252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.47748F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.256881F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.freqLabel);
            this.panel2.Controls.Add(this.freqUpDown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 98);
            this.panel2.TabIndex = 1;
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(4, 2);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(57, 13);
            this.freqLabel.TabIndex = 2;
            this.freqLabel.Text = "Frequency";
            // 
            // freqUpDown
            // 
            this.freqUpDown.DecimalPlaces = 2;
            this.freqUpDown.Location = new System.Drawing.Point(4, 18);
            this.freqUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.freqUpDown.Name = "freqUpDown";
            this.freqUpDown.Size = new System.Drawing.Size(192, 20);
            this.freqUpDown.TabIndex = 1;
            this.freqUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.HFTChart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 64);
            this.panel5.Name = "panel5";
            this.tableLayoutPanel1.SetRowSpan(this.panel5, 2);
            this.panel5.Size = new System.Drawing.Size(672, 202);
            this.panel5.TabIndex = 6;
            // 
            // HFTChart
            // 
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.HFTChart.ChartAreas.Add(chartArea1);
            this.HFTChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.HFTChart.Legends.Add(legend1);
            this.HFTChart.Location = new System.Drawing.Point(0, 0);
            this.HFTChart.Name = "HFTChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "HFT";
            this.HFTChart.Series.Add(series1);
            this.HFTChart.Size = new System.Drawing.Size(672, 202);
            this.HFTChart.TabIndex = 0;
            this.HFTChart.Text = "HFT Data";
            title1.Name = "HFT";
            this.HFTChart.Titles.Add(title1);
            this.HFTChart.Click += new System.EventHandler(this.HFTChart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ampLabel);
            this.panel1.Controls.Add(this.ampUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 100);
            this.panel1.TabIndex = 7;
            // 
            // ampLabel
            // 
            this.ampLabel.AutoSize = true;
            this.ampLabel.Location = new System.Drawing.Point(5, 2);
            this.ampLabel.Name = "ampLabel";
            this.ampLabel.Size = new System.Drawing.Size(53, 13);
            this.ampLabel.TabIndex = 4;
            this.ampLabel.Text = "Amplitude";
            this.ampLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ampUpDown
            // 
            this.ampUpDown.Location = new System.Drawing.Point(5, 18);
            this.ampUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ampUpDown.Name = "ampUpDown";
            this.ampUpDown.Size = new System.Drawing.Size(192, 20);
            this.ampUpDown.TabIndex = 3;
            this.ampUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ampUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(61, 414);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sampLabel);
            this.panel3.Controls.Add(this.sampUpDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 98);
            this.panel3.TabIndex = 8;
            // 
            // sampLabel
            // 
            this.sampLabel.AutoSize = true;
            this.sampLabel.Location = new System.Drawing.Point(4, 4);
            this.sampLabel.Name = "sampLabel";
            this.sampLabel.Size = new System.Drawing.Size(47, 13);
            this.sampLabel.TabIndex = 6;
            this.sampLabel.Text = "Samples";
            // 
            // sampUpDown
            // 
            this.sampUpDown.Location = new System.Drawing.Point(4, 20);
            this.sampUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sampUpDown.Name = "sampUpDown";
            this.sampUpDown.Size = new System.Drawing.Size(192, 20);
            this.sampUpDown.TabIndex = 5;
            this.sampUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.freqWaveChart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 272);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel1.SetRowSpan(this.panel4, 2);
            this.panel4.Size = new System.Drawing.Size(672, 203);
            this.panel4.TabIndex = 9;
            // 
            // freqWaveChart
            // 
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.freqWaveChart.ChartAreas.Add(chartArea2);
            this.freqWaveChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.freqWaveChart.Legends.Add(legend2);
            this.freqWaveChart.Location = new System.Drawing.Point(0, 0);
            this.freqWaveChart.Name = "freqWaveChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.freqWaveChart.Series.Add(series2);
            this.freqWaveChart.Size = new System.Drawing.Size(672, 203);
            this.freqWaveChart.TabIndex = 0;
            this.freqWaveChart.Text = "Frequency";
            this.freqWaveChart.Click += new System.EventHandler(this.freqWaveChart_Click);
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.chartToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.recordToolStripMenuItem,
            this.stopRecordingToolStripMenuItem,
            this.toolStripMenuItem2,
            this.filterAudioToolStripMenuItem,
            this.highPassFilterToolStripMenuItem});
            this.audioToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click_1);
            // 
            // stopRecordingToolStripMenuItem
            // 
            this.stopRecordingToolStripMenuItem.Name = "stopRecordingToolStripMenuItem";
            this.stopRecordingToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stopRecordingToolStripMenuItem.Text = "Stop Recording";
            this.stopRecordingToolStripMenuItem.Click += new System.EventHandler(this.stopRecordingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 6);
            // 
            // filterAudioToolStripMenuItem
            // 
            this.filterAudioToolStripMenuItem.Name = "filterAudioToolStripMenuItem";
            this.filterAudioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.filterAudioToolStripMenuItem.Text = "Low Pass Filter";
            this.filterAudioToolStripMenuItem.Click += new System.EventHandler(this.filterAudioToolStripMenuItem_Click);
            // 
            // highPassFilterToolStripMenuItem
            // 
            this.highPassFilterToolStripMenuItem.Name = "highPassFilterToolStripMenuItem";
            this.highPassFilterToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.highPassFilterToolStripMenuItem.Text = "High Pass Filter";
            this.highPassFilterToolStripMenuItem.Click += new System.EventHandler(this.highPassFilterToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.chartToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.chartToolStripMenuItem.Text = "Select";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Checked = true;
            this.selectToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // chartToolStripMenuItem1
            // 
            this.chartToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangleWindowToolStripMenuItem,
            this.rectangleWindowToolStripMenuItem,
            this.welchWindowToolStripMenuItem,
            this.plotFrequencyToolStripMenuItem});
            this.chartToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.chartToolStripMenuItem1.Name = "chartToolStripMenuItem1";
            this.chartToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem1.Text = "Chart";
            // 
            // triangleWindowToolStripMenuItem
            // 
            this.triangleWindowToolStripMenuItem.Name = "triangleWindowToolStripMenuItem";
            this.triangleWindowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.triangleWindowToolStripMenuItem.Text = "Triangle Window";
            this.triangleWindowToolStripMenuItem.Click += new System.EventHandler(this.triangleWindowToolStripMenuItem_Click);
            // 
            // rectangleWindowToolStripMenuItem
            // 
            this.rectangleWindowToolStripMenuItem.Name = "rectangleWindowToolStripMenuItem";
            this.rectangleWindowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rectangleWindowToolStripMenuItem.Text = "Rectangle Window";
            this.rectangleWindowToolStripMenuItem.Click += new System.EventHandler(this.rectangleWindowToolStripMenuItem_Click);
            // 
            // welchWindowToolStripMenuItem
            // 
            this.welchWindowToolStripMenuItem.Name = "welchWindowToolStripMenuItem";
            this.welchWindowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.welchWindowToolStripMenuItem.Text = "Welch Window";
            this.welchWindowToolStripMenuItem.Click += new System.EventHandler(this.welchWindowToolStripMenuItem_Click);
            // 
            // plotFrequencyToolStripMenuItem
            // 
            this.plotFrequencyToolStripMenuItem.Name = "plotFrequencyToolStripMenuItem";
            this.plotFrequencyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.plotFrequencyToolStripMenuItem.Text = "Plot Signal";
            this.plotFrequencyToolStripMenuItem.Click += new System.EventHandler(this.plotFrequencyToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descreteFourierTransformThreadsToolStripMenuItem});
            this.optionsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // descreteFourierTransformThreadsToolStripMenuItem
            // 
            this.descreteFourierTransformThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threads1MenuButton,
            this.threads2MenuButton,
            this.threads3MenuButton,
            this.threads4MenuButton});
            this.descreteFourierTransformThreadsToolStripMenuItem.Name = "descreteFourierTransformThreadsToolStripMenuItem";
            this.descreteFourierTransformThreadsToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.descreteFourierTransformThreadsToolStripMenuItem.Text = "Descrete Fourier Transform Threads";
            // 
            // threads1MenuButton
            // 
            this.threads1MenuButton.Checked = true;
            this.threads1MenuButton.CheckOnClick = true;
            this.threads1MenuButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.threads1MenuButton.Name = "threads1MenuButton";
            this.threads1MenuButton.Size = new System.Drawing.Size(80, 22);
            this.threads1MenuButton.Text = "1";
            this.threads1MenuButton.Click += new System.EventHandler(this.threads1MenuButton_Click);
            // 
            // threads2MenuButton
            // 
            this.threads2MenuButton.CheckOnClick = true;
            this.threads2MenuButton.Name = "threads2MenuButton";
            this.threads2MenuButton.Size = new System.Drawing.Size(80, 22);
            this.threads2MenuButton.Text = "2";
            this.threads2MenuButton.Click += new System.EventHandler(this.threads2MenuButton_Click);
            // 
            // threads3MenuButton
            // 
            this.threads3MenuButton.CheckOnClick = true;
            this.threads3MenuButton.Name = "threads3MenuButton";
            this.threads3MenuButton.Size = new System.Drawing.Size(80, 22);
            this.threads3MenuButton.Text = "3";
            this.threads3MenuButton.Click += new System.EventHandler(this.threads3MenuButton_Click);
            // 
            // threads4MenuButton
            // 
            this.threads4MenuButton.CheckOnClick = true;
            this.threads4MenuButton.Name = "threads4MenuButton";
            this.threads4MenuButton.Size = new System.Drawing.Size(80, 22);
            this.threads4MenuButton.Text = "4";
            this.threads4MenuButton.Click += new System.EventHandler(this.threads4MenuButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ampUpDownLabel);
            this.panel6.Controls.Add(this.numericUpDown1);
            this.panel6.Controls.Add(this.newFreqBtn);
            this.panel6.Controls.Add(this.newFreqLabel);
            this.panel6.Controls.Add(this.newFreqUpDown);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(200, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(672, 31);
            this.panel6.TabIndex = 11;
            // 
            // ampUpDownLabel
            // 
            this.ampUpDownLabel.AutoSize = true;
            this.ampUpDownLabel.Location = new System.Drawing.Point(79, 9);
            this.ampUpDownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ampUpDownLabel.Name = "ampUpDownLabel";
            this.ampUpDownLabel.Size = new System.Drawing.Size(53, 13);
            this.ampUpDownLabel.TabIndex = 4;
            this.ampUpDownLabel.Text = "Amplitude";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(160, 8);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newFreqBtn
            // 
            this.newFreqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFreqBtn.Location = new System.Drawing.Point(501, 1);
            this.newFreqBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newFreqBtn.Name = "newFreqBtn";
            this.newFreqBtn.Size = new System.Drawing.Size(67, 30);
            this.newFreqBtn.TabIndex = 2;
            this.newFreqBtn.Text = "Insert";
            this.newFreqBtn.UseVisualStyleBackColor = true;
            this.newFreqBtn.Click += new System.EventHandler(this.newFreqBtn_Click);
            // 
            // newFreqLabel
            // 
            this.newFreqLabel.AutoSize = true;
            this.newFreqLabel.Location = new System.Drawing.Point(263, 9);
            this.newFreqLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newFreqLabel.Name = "newFreqLabel";
            this.newFreqLabel.Size = new System.Drawing.Size(104, 13);
            this.newFreqLabel.TabIndex = 1;
            this.newFreqLabel.Text = "Add New Frequency";
            // 
            // newFreqUpDown
            // 
            this.newFreqUpDown.DecimalPlaces = 2;
            this.newFreqUpDown.Location = new System.Drawing.Point(392, 9);
            this.newFreqUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.newFreqUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.newFreqUpDown.Name = "newFreqUpDown";
            this.newFreqUpDown.Size = new System.Drawing.Size(85, 20);
            this.newFreqUpDown.TabIndex = 0;
            this.newFreqUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(191, 31);
            this.panel7.TabIndex = 12;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HFTChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampUpDown)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.freqWaveChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFreqUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown freqUpDown;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart HFTChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ampLabel;
        private System.Windows.Forms.NumericUpDown ampUpDown;
        private System.Windows.Forms.Label sampLabel;
        private System.Windows.Forms.NumericUpDown sampUpDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart freqWaveChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem filterAudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plotFrequencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleWindowToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown newFreqUpDown;
        private System.Windows.Forms.Label newFreqLabel;
        private System.Windows.Forms.Button newFreqBtn;
        private System.Windows.Forms.Label ampUpDownLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem highPassFilterToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripMenuItem rectangleWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welchWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descreteFourierTransformThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threads1MenuButton;
        private System.Windows.Forms.ToolStripMenuItem threads2MenuButton;
        private System.Windows.Forms.ToolStripMenuItem threads3MenuButton;
        private System.Windows.Forms.ToolStripMenuItem threads4MenuButton;
    }
}