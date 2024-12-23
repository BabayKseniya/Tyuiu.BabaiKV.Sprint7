namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormCalculation
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
            buttonMax = new Button();
            buttonSum = new Button();
            buttonMin = new Button();
            buttonMid = new Button();
            buttonCount = new Button();
            textBoxResult = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonMax
            // 
            buttonMax.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMax.Location = new Point(12, 255);
            buttonMax.Name = "buttonMax";
            buttonMax.Size = new Size(245, 45);
            buttonMax.TabIndex = 0;
            buttonMax.Text = "Максимальное";
            buttonMax.UseVisualStyleBackColor = true;
            buttonMax.Click += buttonMax_Click;
            // 
            // buttonSum
            // 
            buttonSum.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSum.Location = new Point(12, 12);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(245, 45);
            buttonSum.TabIndex = 1;
            buttonSum.Text = "Сумма";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonMin
            // 
            buttonMin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMin.Location = new Point(12, 167);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(245, 45);
            buttonMin.TabIndex = 2;
            buttonMin.Text = "Минимальное";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // buttonMid
            // 
            buttonMid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonMid.Location = new Point(12, 86);
            buttonMid.Name = "buttonMid";
            buttonMid.Size = new Size(245, 45);
            buttonMid.TabIndex = 3;
            buttonMid.Text = "Среднее";
            buttonMid.UseVisualStyleBackColor = true;
            buttonMid.Click += buttonMid_Click;
            // 
            // buttonCount
            // 
            buttonCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCount.Location = new Point(12, 336);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(245, 45);
            buttonCount.TabIndex = 4;
            buttonCount.Text = "Количество строк";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(278, 255);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(216, 147);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(278, 206);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 43);
            textBox2.TabIndex = 6;
            textBox2.Text = "Операции над строками таблицы отзывов";
            // 
            // FormCalculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(506, 414);
            Controls.Add(textBox2);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCount);
            Controls.Add(buttonMid);
            Controls.Add(buttonMin);
            Controls.Add(buttonSum);
            Controls.Add(buttonMax);
            MaximizeBox = false;
            MaximumSize = new Size(522, 453);
            MinimizeBox = false;
            MinimumSize = new Size(522, 453);
            Name = "FormCalculation";
            Text = "Операции";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMax;
        private Button buttonSum;
        private Button buttonMin;
        private Button buttonMid;
        private Button buttonCount;
        private TextBox textBoxResult;
        private TextBox textBox2;
    }
}