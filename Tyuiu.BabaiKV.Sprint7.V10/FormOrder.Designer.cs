namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormOrder
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
            panel1 = new Panel();
            textBox4 = new TextBox();
            lblTotalAmount = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBoxSurname_BKV = new TextBox();
            textBoxName_BKV = new TextBox();
            textBoxMidname_BKV = new TextBox();
            textBox5 = new TextBox();
            buttonRegister_BKV = new Button();
            saveFileDialog_BKV = new SaveFileDialog();
            radioButtonPayonl_BKV = new RadioButton();
            radioButtonPaypoluch_BKV = new RadioButton();
            textBox6 = new TextBox();
            textBoxAddress_BKV = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(textBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 122);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Indigo;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.ForeColor = Color.Thistle;
            textBox4.Location = new Point(36, 48);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(467, 40);
            textBox4.TabIndex = 5;
            textBox4.Text = "Анкета для составления заказа";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalAmount.Location = new Point(94, 441);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(72, 30);
            lblTotalAmount.TabIndex = 1;
            lblTotalAmount.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(26, 148);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(116, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(207, 148);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(116, 20);
            textBox2.TabIndex = 3;
            textBox2.Text = "Фамилия";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Thistle;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(377, 148);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(116, 22);
            textBox3.TabIndex = 4;
            textBox3.Text = "Отчество";
            // 
            // textBoxSurname_BKV
            // 
            textBoxSurname_BKV.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxSurname_BKV.Location = new Point(205, 176);
            textBoxSurname_BKV.Name = "textBoxSurname_BKV";
            textBoxSurname_BKV.Size = new Size(139, 27);
            textBoxSurname_BKV.TabIndex = 5;
            // 
            // textBoxName_BKV
            // 
            textBoxName_BKV.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxName_BKV.Location = new Point(26, 176);
            textBoxName_BKV.Name = "textBoxName_BKV";
            textBoxName_BKV.Size = new Size(140, 27);
            textBoxName_BKV.TabIndex = 6;
            // 
            // textBoxMidname_BKV
            // 
            textBoxMidname_BKV.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxMidname_BKV.Location = new Point(377, 176);
            textBoxMidname_BKV.Name = "textBoxMidname_BKV";
            textBoxMidname_BKV.Size = new Size(141, 27);
            textBoxMidname_BKV.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Thistle;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(192, 238);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(131, 20);
            textBox5.TabIndex = 8;
            textBox5.Text = "Способы оплаты";
            // 
            // buttonRegister_BKV
            // 
            buttonRegister_BKV.BackColor = Color.Indigo;
            buttonRegister_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegister_BKV.ForeColor = Color.Thistle;
            buttonRegister_BKV.Location = new Point(192, 499);
            buttonRegister_BKV.Name = "buttonRegister_BKV";
            buttonRegister_BKV.Size = new Size(129, 53);
            buttonRegister_BKV.TabIndex = 9;
            buttonRegister_BKV.Text = "Оформить";
            buttonRegister_BKV.UseVisualStyleBackColor = false;
            buttonRegister_BKV.Click += buttonRegister_BKV_Click;
            // 
            // radioButtonPayonl_BKV
            // 
            radioButtonPayonl_BKV.AutoSize = true;
            radioButtonPayonl_BKV.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButtonPayonl_BKV.Location = new Point(192, 264);
            radioButtonPayonl_BKV.Name = "radioButtonPayonl_BKV";
            radioButtonPayonl_BKV.Size = new Size(81, 24);
            radioButtonPayonl_BKV.TabIndex = 10;
            radioButtonPayonl_BKV.TabStop = true;
            radioButtonPayonl_BKV.Text = "Онлайн";
            radioButtonPayonl_BKV.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaypoluch_BKV
            // 
            radioButtonPaypoluch_BKV.AutoSize = true;
            radioButtonPaypoluch_BKV.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButtonPaypoluch_BKV.Location = new Point(192, 294);
            radioButtonPaypoluch_BKV.Name = "radioButtonPaypoluch_BKV";
            radioButtonPaypoluch_BKV.Size = new Size(138, 24);
            radioButtonPaypoluch_BKV.TabIndex = 11;
            radioButtonPaypoluch_BKV.TabStop = true;
            radioButtonPaypoluch_BKV.Text = "При получении";
            radioButtonPaypoluch_BKV.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Thistle;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(216, 335);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(69, 20);
            textBox6.TabIndex = 13;
            textBox6.Text = "Адрес";
            // 
            // textBoxAddress_BKV
            // 
            textBoxAddress_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxAddress_BKV.Location = new Point(143, 361);
            textBoxAddress_BKV.Name = "textBoxAddress_BKV";
            textBoxAddress_BKV.Size = new Size(210, 27);
            textBoxAddress_BKV.TabIndex = 14;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(530, 573);
            Controls.Add(textBoxAddress_BKV);
            Controls.Add(textBox6);
            Controls.Add(radioButtonPaypoluch_BKV);
            Controls.Add(radioButtonPayonl_BKV);
            Controls.Add(buttonRegister_BKV);
            Controls.Add(textBox5);
            Controls.Add(textBoxMidname_BKV);
            Controls.Add(textBoxName_BKV);
            Controls.Add(textBoxSurname_BKV);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTotalAmount);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MaximumSize = new Size(546, 612);
            MinimumSize = new Size(546, 612);
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Анкета заказа";
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTotalAmount;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBoxSurname_BKV;
        private TextBox textBoxName_BKV;
        private TextBox textBoxMidname_BKV;
        private TextBox textBox5;
        private Button buttonRegister_BKV;
        private SaveFileDialog saveFileDialog_BKV;
        private RadioButton radioButtonPayonl_BKV;
        private RadioButton radioButtonPaypoluch_BKV;
        private TextBox textBox6;
        private TextBox textBoxAddress_BKV;
    }
}