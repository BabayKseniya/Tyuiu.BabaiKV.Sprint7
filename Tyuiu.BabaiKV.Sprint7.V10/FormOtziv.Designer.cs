namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormOtziv
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonOK_BKV = new Button();
            groupBoxOtziv = new GroupBox();
            chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOtziv_BKV = new DataGridView();
            buttonOstavOtziv_BKV = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonChartAddLine_BKV = new Button();
            toolTipOtziv = new ToolTip(components);
            groupBoxOtziv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtziv_BKV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = Color.Thistle;
            buttonOK_BKV.FlatStyle = FlatStyle.Popup;
            buttonOK_BKV.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_BKV.Location = new Point(300, 683);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(131, 59);
            buttonOK_BKV.TabIndex = 1;
            buttonOK_BKV.Text = "Закрыть";
            toolTipOtziv.SetToolTip(buttonOK_BKV, "Закрыть отзывы");
            buttonOK_BKV.UseVisualStyleBackColor = false;
            buttonOK_BKV.Click += buttonOK_BKV_Click_1;
            // 
            // groupBoxOtziv
            // 
            groupBoxOtziv.Controls.Add(chartProduct);
            groupBoxOtziv.Controls.Add(dataGridViewOtziv_BKV);
            groupBoxOtziv.Location = new Point(284, 98);
            groupBoxOtziv.Name = "groupBoxOtziv";
            groupBoxOtziv.Size = new Size(1111, 562);
            groupBoxOtziv.TabIndex = 2;
            groupBoxOtziv.TabStop = false;
            // 
            // chartProduct
            // 
            chartProduct.BackColor = Color.Thistle;
            chartArea1.Name = "ChartArea1";
            chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartProduct.Legends.Add(legend1);
            chartProduct.Location = new Point(625, 20);
            chartProduct.Name = "chartProduct";
            chartProduct.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartProduct.Series.Add(series1);
            chartProduct.Size = new Size(482, 535);
            chartProduct.TabIndex = 1;
            chartProduct.Text = "chart1";
            // 
            // dataGridViewOtziv_BKV
            // 
            dataGridViewOtziv_BKV.BackgroundColor = Color.Thistle;
            dataGridViewOtziv_BKV.BorderStyle = BorderStyle.None;
            dataGridViewOtziv_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOtziv_BKV.ColumnHeadersVisible = false;
            dataGridViewOtziv_BKV.Location = new Point(6, 15);
            dataGridViewOtziv_BKV.Name = "dataGridViewOtziv_BKV";
            dataGridViewOtziv_BKV.ReadOnly = true;
            dataGridViewOtziv_BKV.RowHeadersVisible = false;
            dataGridViewOtziv_BKV.Size = new Size(605, 540);
            dataGridViewOtziv_BKV.TabIndex = 0;
            // 
            // buttonOstavOtziv_BKV
            // 
            buttonOstavOtziv_BKV.BackColor = Color.Thistle;
            buttonOstavOtziv_BKV.FlatStyle = FlatStyle.Popup;
            buttonOstavOtziv_BKV.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOstavOtziv_BKV.Location = new Point(446, 683);
            buttonOstavOtziv_BKV.Name = "buttonOstavOtziv_BKV";
            buttonOstavOtziv_BKV.Size = new Size(209, 59);
            buttonOstavOtziv_BKV.TabIndex = 3;
            buttonOstavOtziv_BKV.Text = "Оставить отзыв";
            toolTipOtziv.SetToolTip(buttonOstavOtziv_BKV, "Оставьте своё мнение о нашей продукции ");
            buttonOstavOtziv_BKV.UseVisualStyleBackColor = false;
            buttonOstavOtziv_BKV.Click += buttonOstavOtziv_BKV_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Thistle;
            textBox1.Location = new Point(554, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(548, 46);
            textBox1.TabIndex = 4;
            textBox1.Text = "Отзывы наших дорогих покупателей";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._46ff11e9639aa58905bdb6084e39fdee;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 773);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.console_controller__2_8;
            pictureBox1.Location = new Point(36, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonChartAddLine_BKV
            // 
            buttonChartAddLine_BKV.BackColor = Color.Thistle;
            buttonChartAddLine_BKV.FlatStyle = FlatStyle.Popup;
            buttonChartAddLine_BKV.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonChartAddLine_BKV.Location = new Point(908, 683);
            buttonChartAddLine_BKV.Name = "buttonChartAddLine_BKV";
            buttonChartAddLine_BKV.Size = new Size(182, 59);
            buttonChartAddLine_BKV.TabIndex = 6;
            buttonChartAddLine_BKV.Text = "Добавить ";
            toolTipOtziv.SetToolTip(buttonChartAddLine_BKV, "Посмотреть график оценок");
            buttonChartAddLine_BKV.UseVisualStyleBackColor = false;
            buttonChartAddLine_BKV.Click += buttonChartAddLine_BKV_Click;
            // 
            // toolTipOtziv
            // 
            toolTipOtziv.BackColor = Color.Thistle;
            toolTipOtziv.IsBalloon = true;
            toolTipOtziv.ToolTipTitle = "Подсказка";
            // 
            // FormOtziv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1398, 773);
            Controls.Add(buttonChartAddLine_BKV);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(buttonOstavOtziv_BKV);
            Controls.Add(groupBoxOtziv);
            Controls.Add(buttonOK_BKV);
            MaximizeBox = false;
            MaximumSize = new Size(1414, 812);
            MinimumSize = new Size(1414, 812);
            Name = "FormOtziv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отзывы";
            groupBoxOtziv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtziv_BKV).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOK_BKV;
        private GroupBox groupBoxOtziv;
        private DataGridView dataGridViewOtziv_BKV;
        private Button buttonOstavOtziv_BKV;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonChartAddLine_BKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private ToolTip toolTipOtziv;
    }
}