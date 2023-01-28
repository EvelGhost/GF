namespace GraphiccFunction
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.холстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сторонаAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSideTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.сторонаBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSideTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.шагToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasWalkTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.график1синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yBlueTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xBlueTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.рисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawOnlyGrphicOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.рисоватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 28);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 422);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.холстToolStripMenuItem,
            this.график1синийToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // холстToolStripMenuItem
            // 
            this.холстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сторонаAToolStripMenuItem,
            this.aSideTextBox,
            this.сторонаBToolStripMenuItem,
            this.bSideTextBox,
            this.шагToolStripMenuItem,
            this.canvasWalkTextBox});
            this.холстToolStripMenuItem.Name = "холстToolStripMenuItem";
            this.холстToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.холстToolStripMenuItem.Text = "холст";
            // 
            // сторонаAToolStripMenuItem
            // 
            this.сторонаAToolStripMenuItem.Name = "сторонаAToolStripMenuItem";
            this.сторонаAToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сторонаAToolStripMenuItem.Text = "сторона a:";
            // 
            // aSideTextBox
            // 
            this.aSideTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aSideTextBox.Name = "aSideTextBox";
            this.aSideTextBox.Size = new System.Drawing.Size(100, 27);
            this.aSideTextBox.Text = "-10";
            // 
            // сторонаBToolStripMenuItem
            // 
            this.сторонаBToolStripMenuItem.Name = "сторонаBToolStripMenuItem";
            this.сторонаBToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сторонаBToolStripMenuItem.Text = "сторона b:";
            // 
            // bSideTextBox
            // 
            this.bSideTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bSideTextBox.Name = "bSideTextBox";
            this.bSideTextBox.Size = new System.Drawing.Size(100, 27);
            this.bSideTextBox.Text = "10";
            // 
            // шагToolStripMenuItem
            // 
            this.шагToolStripMenuItem.Name = "шагToolStripMenuItem";
            this.шагToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шагToolStripMenuItem.Text = "шаг:";
            // 
            // canvasWalkTextBox
            // 
            this.canvasWalkTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.canvasWalkTextBox.Name = "canvasWalkTextBox";
            this.canvasWalkTextBox.Size = new System.Drawing.Size(100, 27);
            this.canvasWalkTextBox.Text = "0,1";
            // 
            // график1синийToolStripMenuItem
            // 
            this.график1синийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yToolStripMenuItem,
            this.yBlueTextBox,
            this.xToolStripMenuItem,
            this.xBlueTextBox});
            this.график1синийToolStripMenuItem.Name = "график1синийToolStripMenuItem";
            this.график1синийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.график1синийToolStripMenuItem.Text = "График 1(синий)";
            // 
            // yToolStripMenuItem
            // 
            this.yToolStripMenuItem.Name = "yToolStripMenuItem";
            this.yToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yToolStripMenuItem.Text = "y = ";
            // 
            // yBlueTextBox
            // 
            this.yBlueTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yBlueTextBox.Name = "yBlueTextBox";
            this.yBlueTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xToolStripMenuItem.Text = "x = ";
            // 
            // xBlueTextBox
            // 
            this.xBlueTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.xBlueTextBox.Name = "xBlueTextBox";
            this.xBlueTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // рисоватьToolStripMenuItem
            // 
            this.рисоватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawOnlyGrphicOneToolStripMenuItem});
            this.рисоватьToolStripMenuItem.Name = "рисоватьToolStripMenuItem";
            this.рисоватьToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.рисоватьToolStripMenuItem.Text = "Рисовать";
            // 
            // drawOnlyGrphicOneToolStripMenuItem
            // 
            this.drawOnlyGrphicOneToolStripMenuItem.Name = "drawOnlyGrphicOneToolStripMenuItem";
            this.drawOnlyGrphicOneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drawOnlyGrphicOneToolStripMenuItem.Text = "только график 1";
            this.drawOnlyGrphicOneToolStripMenuItem.Click += new System.EventHandler(this.drawOnlyGrphicOneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem холстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сторонаAToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox aSideTextBox;
        private System.Windows.Forms.ToolStripMenuItem сторонаBToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox bSideTextBox;
        private System.Windows.Forms.ToolStripMenuItem шагToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox canvasWalkTextBox;
        private System.Windows.Forms.ToolStripMenuItem график1синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox yBlueTextBox;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox xBlueTextBox;
        private System.Windows.Forms.ToolStripMenuItem рисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawOnlyGrphicOneToolStripMenuItem;
    }
}

