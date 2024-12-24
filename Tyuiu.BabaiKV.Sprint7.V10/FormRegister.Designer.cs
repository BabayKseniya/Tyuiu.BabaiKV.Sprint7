namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormRegister
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
            textBox1 = new TextBox();
            textBoxResult_BKV = new TextBox();
            textBoxAddress_BKV = new TextBox();
            textBoxNumber_BKV = new TextBox();
            lblTotalAmount = new TextBox();
            buttonOK_BKV = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            labelTime_BKV = new Label();
            buttonOtziv_BKV = new Button();
            toolTipRegister = new ToolTip(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Pink;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(85, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Поздравляем! Ваш заказ успешно оформлен!";
            // 
            // textBoxResult_BKV
            // 
            textBoxResult_BKV.BackColor = Color.Pink;
            textBoxResult_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxResult_BKV.Location = new Point(12, 109);
            textBoxResult_BKV.Multiline = true;
            textBoxResult_BKV.Name = "textBoxResult_BKV";
            textBoxResult_BKV.ReadOnly = true;
            textBoxResult_BKV.Size = new Size(527, 31);
            textBoxResult_BKV.TabIndex = 1;
            // 
            // textBoxAddress_BKV
            // 
            textBoxAddress_BKV.BackColor = Color.Pink;
            textBoxAddress_BKV.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxAddress_BKV.Location = new Point(12, 186);
            textBoxAddress_BKV.Multiline = true;
            textBoxAddress_BKV.Name = "textBoxAddress_BKV";
            textBoxAddress_BKV.ReadOnly = true;
            textBoxAddress_BKV.Size = new Size(264, 27);
            textBoxAddress_BKV.TabIndex = 2;
            // 
            // textBoxNumber_BKV
            // 
            textBoxNumber_BKV.BackColor = Color.Pink;
            textBoxNumber_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNumber_BKV.Location = new Point(307, 186);
            textBoxNumber_BKV.Multiline = true;
            textBoxNumber_BKV.Name = "textBoxNumber_BKV";
            textBoxNumber_BKV.ReadOnly = true;
            textBoxNumber_BKV.Size = new Size(216, 27);
            textBoxNumber_BKV.TabIndex = 3;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.BackColor = Color.Pink;
            lblTotalAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalAmount.Location = new Point(12, 258);
            lblTotalAmount.Multiline = true;
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.ReadOnly = true;
            lblTotalAmount.Size = new Size(264, 28);
            lblTotalAmount.TabIndex = 4;
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = Color.Pink;
            buttonOK_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_BKV.Location = new Point(296, 305);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(134, 34);
            buttonOK_BKV.TabIndex = 5;
            buttonOK_BKV.Text = "Закрыть";
            toolTipRegister.SetToolTip(buttonOK_BKV, "Закрыть приложение");
            buttonOK_BKV.UseVisualStyleBackColor = false;
            buttonOK_BKV.Click += buttonOK_BKV_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Indigo;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.ForeColor = Color.Thistle;
            textBox4.Location = new Point(24, 80);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(50, 23);
            textBox4.TabIndex = 6;
            textBox4.Text = "ФИО";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Indigo;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox5.ForeColor = Color.Thistle;
            textBox5.Location = new Point(24, 157);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(57, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Адрес";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Indigo;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox6.ForeColor = Color.Thistle;
            textBox6.Location = new Point(318, 157);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 23);
            textBox6.TabIndex = 8;
            textBox6.Text = "Номер заказа";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.Indigo;
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox7.ForeColor = Color.Thistle;
            textBox7.Location = new Point(24, 229);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(123, 23);
            textBox7.TabIndex = 9;
            textBox7.Text = "Способ оплаты";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Indigo;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.Thistle;
            textBox2.Location = new Point(307, 229);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 23);
            textBox2.TabIndex = 11;
            textBox2.Text = "Дата оформления заказа";
            // 
            // labelTime_BKV
            // 
            labelTime_BKV.AutoSize = true;
            labelTime_BKV.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTime_BKV.ForeColor = Color.Pink;
            labelTime_BKV.Location = new Point(309, 258);
            labelTime_BKV.Name = "labelTime_BKV";
            labelTime_BKV.Size = new Size(65, 25);
            labelTime_BKV.TabIndex = 12;
            labelTime_BKV.Text = "label1";
            // 
            // buttonOtziv_BKV
            // 
            buttonOtziv_BKV.BackColor = Color.Pink;
            buttonOtziv_BKV.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOtziv_BKV.Location = new Point(154, 305);
            buttonOtziv_BKV.Name = "buttonOtziv_BKV";
            buttonOtziv_BKV.Size = new Size(122, 33);
            buttonOtziv_BKV.TabIndex = 13;
            buttonOtziv_BKV.Text = "Отзыв";
            toolTipRegister.SetToolTip(buttonOtziv_BKV, "Оставьте свой отзыв,\r\n ваше мнение важно для нас!");
            buttonOtziv_BKV.UseVisualStyleBackColor = false;
            buttonOtziv_BKV.Click += buttonOtziv_BKV_Click;
            // 
            // toolTipRegister
            // 
            toolTipRegister.IsBalloon = true;
            toolTipRegister.ToolTipIcon = ToolTipIcon.Info;
            toolTipRegister.ToolTipTitle = "Подсказка";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(546, 351);
            Controls.Add(buttonOtziv_BKV);
            Controls.Add(labelTime_BKV);
            Controls.Add(textBox2);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(buttonOK_BKV);
            Controls.Add(lblTotalAmount);
            Controls.Add(textBoxNumber_BKV);
            Controls.Add(textBoxAddress_BKV);
            Controls.Add(textBoxResult_BKV);
            Controls.Add(textBox1);
            MaximizeBox = false;
            MaximumSize = new Size(562, 390);
            MinimumSize = new Size(562, 390);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Подтверждение заказа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxResult_BKV;
        private TextBox textBoxAddress_BKV;
        private TextBox textBoxNumber_BKV;
        private TextBox lblTotalAmount;
        private Button buttonOK_BKV;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        
        private TextBox textBox2;
        private Label labelTime_BKV;
        private Button buttonOtziv_BKV;
        private ToolTip toolTipRegister;
    }
}