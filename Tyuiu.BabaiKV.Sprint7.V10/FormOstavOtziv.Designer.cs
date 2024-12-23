namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormOstavOtziv
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
            groupBoxOstavOtziv = new GroupBox();
            textBoxRating = new TextBox();
            buttonSubmit = new Button();
            textBoxOtziv = new TextBox();
            textBoxTovar = new TextBox();
            textBoxName = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox = new TextBox();
            textBox10 = new TextBox();
            groupBoxOstavOtziv.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOstavOtziv
            // 
            groupBoxOstavOtziv.Controls.Add(textBoxRating);
            groupBoxOstavOtziv.Controls.Add(buttonSubmit);
            groupBoxOstavOtziv.Controls.Add(textBoxOtziv);
            groupBoxOstavOtziv.Controls.Add(textBoxTovar);
            groupBoxOstavOtziv.Controls.Add(textBoxName);
            groupBoxOstavOtziv.Controls.Add(textBox4);
            groupBoxOstavOtziv.Controls.Add(textBox3);
            groupBoxOstavOtziv.Controls.Add(textBox2);
            groupBoxOstavOtziv.Controls.Add(textBox);
            groupBoxOstavOtziv.Controls.Add(textBox10);
            groupBoxOstavOtziv.Location = new Point(3, 2);
            groupBoxOstavOtziv.Name = "groupBoxOstavOtziv";
            groupBoxOstavOtziv.Size = new Size(598, 615);
            groupBoxOstavOtziv.TabIndex = 0;
            groupBoxOstavOtziv.TabStop = false;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(375, 165);
            textBoxRating.Multiline = true;
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(127, 37);
            textBoxRating.TabIndex = 13;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.Indigo;
            buttonSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSubmit.ForeColor = Color.Thistle;
            buttonSubmit.Location = new Point(502, 529);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(90, 66);
            buttonSubmit.TabIndex = 12;
            buttonSubmit.Text = "Отправить";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textBoxOtziv
            // 
            textBoxOtziv.Location = new Point(22, 317);
            textBoxOtziv.Multiline = true;
            textBoxOtziv.Name = "textBoxOtziv";
            textBoxOtziv.Size = new Size(474, 278);
            textBoxOtziv.TabIndex = 8;
            // 
            // textBoxTovar
            // 
            textBoxTovar.Location = new Point(22, 242);
            textBoxTovar.Multiline = true;
            textBoxTovar.Name = "textBoxTovar";
            textBoxTovar.Size = new Size(245, 43);
            textBoxTovar.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(22, 165);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(245, 43);
            textBoxName.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Thistle;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(22, 291);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(211, 30);
            textBox4.TabIndex = 4;
            textBox4.Text = "Введите ваш отзыв";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Thistle;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(366, 136);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Введите оценку";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(22, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(203, 22);
            textBox2.TabIndex = 2;
            textBox2.Text = "Введите товар";
            // 
            // textBox
            // 
            textBox.BackColor = Color.Thistle;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox.Location = new Point(22, 136);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(203, 23);
            textBox.TabIndex = 1;
            textBox.Text = "Введите ваше имя";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.Indigo;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox10.ForeColor = Color.Thistle;
            textBox10.Location = new Point(63, 43);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(491, 66);
            textBox10.TabIndex = 0;
            textBox10.Text = "Мы благодарны каждому отзыву, ведь это помогает нам делать нашу продукцию ещё лучше.";
            // 
            // FormOstavOtziv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(608, 622);
            Controls.Add(groupBoxOstavOtziv);
            Name = "FormOstavOtziv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление отзыва";
            groupBoxOstavOtziv.ResumeLayout(false);
            groupBoxOstavOtziv.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOstavOtziv;
        private TextBox textBox10;
        private TextBox textBoxOtziv;
        private TextBox textBoxTovar;
        private TextBox textBoxName;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox;
        private Button buttonSubmit;
        private TextBox textBoxRating;
    }
}