namespace NM2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown_x1_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x1_2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x1_3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x1_4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Accept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_x2_4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x2_3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x2_2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x2_1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_x_amount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_y_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "Y";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "X1*X2";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(657, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // numericUpDown_x1_1
            // 
            this.numericUpDown_x1_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x1_1.DecimalPlaces = 2;
            this.numericUpDown_x1_1.Location = new System.Drawing.Point(676, 33);
            this.numericUpDown_x1_1.Name = "numericUpDown_x1_1";
            this.numericUpDown_x1_1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x1_1.TabIndex = 1;
            this.numericUpDown_x1_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_x1_2
            // 
            this.numericUpDown_x1_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x1_2.DecimalPlaces = 2;
            this.numericUpDown_x1_2.Location = new System.Drawing.Point(676, 59);
            this.numericUpDown_x1_2.Name = "numericUpDown_x1_2";
            this.numericUpDown_x1_2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x1_2.TabIndex = 2;
            this.numericUpDown_x1_2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDown_x1_3
            // 
            this.numericUpDown_x1_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x1_3.DecimalPlaces = 2;
            this.numericUpDown_x1_3.Location = new System.Drawing.Point(675, 85);
            this.numericUpDown_x1_3.Name = "numericUpDown_x1_3";
            this.numericUpDown_x1_3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x1_3.TabIndex = 3;
            this.numericUpDown_x1_3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_x1_4
            // 
            this.numericUpDown_x1_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x1_4.DecimalPlaces = 2;
            this.numericUpDown_x1_4.Location = new System.Drawing.Point(675, 111);
            this.numericUpDown_x1_4.Name = "numericUpDown_x1_4";
            this.numericUpDown_x1_4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x1_4.TabIndex = 4;
            this.numericUpDown_x1_4.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x1";
            // 
            // button_Accept
            // 
            this.button_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Accept.Location = new System.Drawing.Point(678, 415);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(118, 23);
            this.button_Accept.TabIndex = 12;
            this.button_Accept.Text = "Build";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "x2";
            // 
            // numericUpDown_x2_4
            // 
            this.numericUpDown_x2_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x2_4.DecimalPlaces = 2;
            this.numericUpDown_x2_4.Location = new System.Drawing.Point(674, 257);
            this.numericUpDown_x2_4.Name = "numericUpDown_x2_4";
            this.numericUpDown_x2_4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x2_4.TabIndex = 8;
            this.numericUpDown_x2_4.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDown_x2_3
            // 
            this.numericUpDown_x2_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x2_3.DecimalPlaces = 2;
            this.numericUpDown_x2_3.Location = new System.Drawing.Point(674, 231);
            this.numericUpDown_x2_3.Name = "numericUpDown_x2_3";
            this.numericUpDown_x2_3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x2_3.TabIndex = 7;
            this.numericUpDown_x2_3.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown_x2_2
            // 
            this.numericUpDown_x2_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x2_2.DecimalPlaces = 2;
            this.numericUpDown_x2_2.Location = new System.Drawing.Point(675, 205);
            this.numericUpDown_x2_2.Name = "numericUpDown_x2_2";
            this.numericUpDown_x2_2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x2_2.TabIndex = 6;
            this.numericUpDown_x2_2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown_x2_1
            // 
            this.numericUpDown_x2_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x2_1.DecimalPlaces = 2;
            this.numericUpDown_x2_1.Location = new System.Drawing.Point(675, 179);
            this.numericUpDown_x2_1.Name = "numericUpDown_x2_1";
            this.numericUpDown_x2_1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x2_1.TabIndex = 5;
            this.numericUpDown_x2_1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_x_amount
            // 
            this.numericUpDown_x_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_x_amount.Location = new System.Drawing.Point(674, 318);
            this.numericUpDown_x_amount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_x_amount.Name = "numericUpDown_x_amount";
            this.numericUpDown_x_amount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_x_amount.TabIndex = 10;
            this.numericUpDown_x_amount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(675, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "x points amount (square)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "y points amount";
            // 
            // numericUpDown_y_amount
            // 
            this.numericUpDown_y_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_y_amount.Location = new System.Drawing.Point(674, 362);
            this.numericUpDown_y_amount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_y_amount.Name = "numericUpDown_y_amount";
            this.numericUpDown_y_amount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_y_amount.TabIndex = 11;
            this.numericUpDown_y_amount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_y_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_x_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_x2_4);
            this.Controls.Add(this.numericUpDown_x2_3);
            this.Controls.Add(this.numericUpDown_x2_2);
            this.Controls.Add(this.numericUpDown_x2_1);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_x1_4);
            this.Controls.Add(this.numericUpDown_x1_3);
            this.Controls.Add(this.numericUpDown_x1_2);
            this.Controls.Add(this.numericUpDown_x1_1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Zadeh\'s rule";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_x_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_y_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDown_x1_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_x1_2;
        private System.Windows.Forms.NumericUpDown numericUpDown_x1_3;
        private System.Windows.Forms.NumericUpDown numericUpDown_x1_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_x2_4;
        private System.Windows.Forms.NumericUpDown numericUpDown_x2_3;
        private System.Windows.Forms.NumericUpDown numericUpDown_x2_2;
        private System.Windows.Forms.NumericUpDown numericUpDown_x2_1;
        private System.Windows.Forms.NumericUpDown numericUpDown_x_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_y_amount;
    }
}

