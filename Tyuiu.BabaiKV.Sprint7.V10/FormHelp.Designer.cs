namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            buttonOK_BKV = new Button();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            vScrollBar1 = new VScrollBar();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOK_BKV);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(276, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 529);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources._787ece12d99080845884c23aec541ca1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 529);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.console_controller__2_7;
            pictureBox1.Location = new Point(-11, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(534, 466);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Thistle;
            tabPage1.Controls.Add(textBox2);
            tabPage1.ForeColor = Color.Thistle;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(526, 438);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Часто задаваемые вопросы";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Thistle;
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(vScrollBar1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(526, 438);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Краткое руководство пользоватля";
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = Color.Thistle;
            buttonOK_BKV.FlatStyle = FlatStyle.Popup;
            buttonOK_BKV.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_BKV.Location = new Point(233, 485);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(115, 31);
            buttonOK_BKV.TabIndex = 1;
            buttonOK_BKV.Text = "OK";
            buttonOK_BKV.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Thistle;
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(526, 438);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Связь с нами";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(15, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(503, 416);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(11, 6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(509, 436);
            textBox2.TabIndex = 0;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(510, 11);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(13, 419);
            vScrollBar1.TabIndex = 0;
            vScrollBar1.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Thistle;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(16, 11);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(491, 411);
            textBox3.TabIndex = 1;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(834, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimumSize = new Size(850, 568);
            Name = "FormHelp";
            Text = "Помощь";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonOK_BKV;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private VScrollBar vScrollBar1;
    }
}