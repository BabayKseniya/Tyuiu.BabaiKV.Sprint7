namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormAboutUs_BKV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutUs_BKV));
            panelInfo = new Panel();
            buttonOKAboutUs_BKV = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.Indigo;
            panelInfo.Controls.Add(buttonOKAboutUs_BKV);
            panelInfo.Controls.Add(textBox2);
            panelInfo.Controls.Add(textBox1);
            panelInfo.Dock = DockStyle.Right;
            panelInfo.Location = new Point(279, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(605, 561);
            panelInfo.TabIndex = 0;
            // 
            // buttonOKAboutUs_BKV
            // 
            buttonOKAboutUs_BKV.BackColor = Color.MediumPurple;
            buttonOKAboutUs_BKV.FlatStyle = FlatStyle.Popup;
            buttonOKAboutUs_BKV.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOKAboutUs_BKV.ForeColor = Color.Indigo;
            buttonOKAboutUs_BKV.Location = new Point(240, 509);
            buttonOKAboutUs_BKV.Name = "buttonOKAboutUs_BKV";
            buttonOKAboutUs_BKV.Size = new Size(160, 40);
            buttonOKAboutUs_BKV.TabIndex = 2;
            buttonOKAboutUs_BKV.Text = "OK";
            buttonOKAboutUs_BKV.TextAlign = ContentAlignment.TopCenter;
            buttonOKAboutUs_BKV.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Indigo;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.Control;
            textBox2.Location = new Point(16, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(586, 491);
            textBox2.TabIndex = 1;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(27, 35);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 167);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 561);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "100;100";
            pictureBox1.Location = new Point(45, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormAboutUs_BKV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(panelInfo);
            MaximizeBox = false;
            MaximumSize = new Size(900, 600);
            MinimumSize = new Size(900, 600);
            Name = "FormAboutUs_BKV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О Нашей компании";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button buttonOKAboutUs_BKV;
    }
}