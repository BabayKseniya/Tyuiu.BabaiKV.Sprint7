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
            button1 = new Button();
            groupBoxOtziv = new GroupBox();
            dataGridViewOtziv_BKV = new DataGridView();
            buttonOstavOtziv_BKV = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBoxOtziv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtziv_BKV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(536, 621);
            button1.Name = "button1";
            button1.Size = new Size(131, 59);
            button1.TabIndex = 1;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBoxOtziv
            // 
            groupBoxOtziv.Controls.Add(dataGridViewOtziv_BKV);
            groupBoxOtziv.Location = new Point(284, 98);
            groupBoxOtziv.Name = "groupBoxOtziv";
            groupBoxOtziv.Size = new Size(604, 504);
            groupBoxOtziv.TabIndex = 2;
            groupBoxOtziv.TabStop = false;
            // 
            // dataGridViewOtziv_BKV
            // 
            dataGridViewOtziv_BKV.BackgroundColor = Color.Thistle;
            dataGridViewOtziv_BKV.BorderStyle = BorderStyle.None;
            dataGridViewOtziv_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOtziv_BKV.ColumnHeadersVisible = false;
            dataGridViewOtziv_BKV.Location = new Point(6, 11);
            dataGridViewOtziv_BKV.Name = "dataGridViewOtziv_BKV";
            dataGridViewOtziv_BKV.ReadOnly = true;
            dataGridViewOtziv_BKV.RowHeadersVisible = false;
            dataGridViewOtziv_BKV.Size = new Size(592, 487);
            dataGridViewOtziv_BKV.TabIndex = 0;
            // 
            // buttonOstavOtziv_BKV
            // 
            buttonOstavOtziv_BKV.BackColor = Color.Thistle;
            buttonOstavOtziv_BKV.FlatStyle = FlatStyle.Popup;
            buttonOstavOtziv_BKV.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOstavOtziv_BKV.Location = new Point(673, 621);
            buttonOstavOtziv_BKV.Name = "buttonOstavOtziv_BKV";
            buttonOstavOtziv_BKV.Size = new Size(209, 61);
            buttonOstavOtziv_BKV.TabIndex = 3;
            buttonOstavOtziv_BKV.Text = "Оставить отзыв";
            buttonOstavOtziv_BKV.UseVisualStyleBackColor = false;
            buttonOstavOtziv_BKV.Click += buttonOstavOtziv_BKV_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.Thistle;
            textBox1.Location = new Point(284, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
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
            panel1.Size = new Size(277, 694);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.console_controller__2_8;
            pictureBox1.Location = new Point(38, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormOtziv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(891, 691);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(buttonOstavOtziv_BKV);
            Controls.Add(groupBoxOtziv);
            Controls.Add(button1);
            Name = "FormOtziv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Отзывы";
            groupBoxOtziv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtziv_BKV).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private GroupBox groupBoxOtziv;
        private DataGridView dataGridViewOtziv_BKV;
        private Button buttonOstavOtziv_BKV;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}