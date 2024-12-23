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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox2 = new TextBox();
            tabPage2 = new TabPage();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            buttonOKAboutUs_BKV = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelInfo.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.Indigo;
            panelInfo.Controls.Add(tabControl1);
            panelInfo.Controls.Add(buttonOKAboutUs_BKV);
            panelInfo.Controls.Add(textBox1);
            panelInfo.Dock = DockStyle.Right;
            panelInfo.Location = new Point(279, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(605, 561);
            panelInfo.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(599, 500);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Thistle;
            tabPage1.Controls.Add(textBox2);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(591, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "О нас";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(11, 10);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(574, 457);
            textBox2.TabIndex = 0;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Thistle;
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(591, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Разработчик";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ари;
            pictureBox2.Location = new Point(6, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(216, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Thistle;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(228, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(357, 200);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // buttonOKAboutUs_BKV
            // 
            buttonOKAboutUs_BKV.BackColor = Color.Thistle;
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
            buttonOKAboutUs_BKV.Click += buttonOKAboutUs_BKV_Click;
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
            pictureBox1.Image = Properties.Resources.console_controller__2_10;
            pictureBox1.Location = new Point(49, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private TextBox textBox1;
        private Panel panel1;
        private Button buttonOKAboutUs_BKV;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}