namespace _CM_Lab5
{
    partial class App
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxDeg = new System.Windows.Forms.ListBox();
            this.buttonDeg = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxScalar = new System.Windows.Forms.ListBox();
            this.buttonScalar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(400, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxDeg);
            this.tabPage1.Controls.Add(this.buttonDeg);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Степенной метод";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxDeg
            // 
            this.listBoxDeg.FormattingEnabled = true;
            this.listBoxDeg.Location = new System.Drawing.Point(6, 6);
            this.listBoxDeg.Name = "listBoxDeg";
            this.listBoxDeg.Size = new System.Drawing.Size(380, 355);
            this.listBoxDeg.TabIndex = 1;
            // 
            // buttonDeg
            // 
            this.buttonDeg.Location = new System.Drawing.Point(6, 371);
            this.buttonDeg.Name = "buttonDeg";
            this.buttonDeg.Size = new System.Drawing.Size(380, 23);
            this.buttonDeg.TabIndex = 0;
            this.buttonDeg.Text = "Поiхали";
            this.buttonDeg.UseVisualStyleBackColor = true;
            this.buttonDeg.Click += new System.EventHandler(this.buttonDeg_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonScalar);
            this.tabPage2.Controls.Add(this.listBoxScalar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод скалярных произведений";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(418, 34);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(370, 400);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // listBoxScalar
            // 
            this.listBoxScalar.FormattingEnabled = true;
            this.listBoxScalar.Location = new System.Drawing.Point(6, 6);
            this.listBoxScalar.Name = "listBoxScalar";
            this.listBoxScalar.Size = new System.Drawing.Size(380, 355);
            this.listBoxScalar.TabIndex = 2;
            // 
            // buttonScalar
            // 
            this.buttonScalar.Location = new System.Drawing.Point(6, 371);
            this.buttonScalar.Name = "buttonScalar";
            this.buttonScalar.Size = new System.Drawing.Size(380, 23);
            this.buttonScalar.TabIndex = 3;
            this.buttonScalar.Text = "Поiхали";
            this.buttonScalar.UseVisualStyleBackColor = true;
            this.buttonScalar.Click += new System.EventHandler(this.buttonScalar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Метод Рэлея";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "App";
            this.Text = "Собственное значение матрицы";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxDeg;
        private System.Windows.Forms.Button buttonDeg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button buttonScalar;
        private System.Windows.Forms.ListBox listBoxScalar;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

