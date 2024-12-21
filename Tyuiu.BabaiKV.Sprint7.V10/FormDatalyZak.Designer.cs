namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormDatalyZak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatalyZak));
            panel1 = new Panel();
            tabControlDetalyZak_BKV = new TabControl();
            tabPageDetalyZak1 = new TabPage();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            textBox2 = new TextBox();
            tabPage1 = new TabPage();
            textBoxDetalyZak = new TextBox();
            buttonOK_BKV = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tabControlDetalyZak_BKV.SuspendLayout();
            tabPageDetalyZak1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tabControlDetalyZak_BKV);
            panel1.Controls.Add(buttonOK_BKV);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(282, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 561);
            panel1.TabIndex = 0;
            // 
            // tabControlDetalyZak_BKV
            // 
            tabControlDetalyZak_BKV.Controls.Add(tabPageDetalyZak1);
            tabControlDetalyZak_BKV.Controls.Add(tabPage2);
            tabControlDetalyZak_BKV.Controls.Add(tabPage1);
            tabControlDetalyZak_BKV.Location = new Point(6, 3);
            tabControlDetalyZak_BKV.Name = "tabControlDetalyZak_BKV";
            tabControlDetalyZak_BKV.SelectedIndex = 0;
            tabControlDetalyZak_BKV.Size = new Size(513, 492);
            tabControlDetalyZak_BKV.TabIndex = 2;
            // 
            // tabPageDetalyZak1
            // 
            tabPageDetalyZak1.BackColor = Color.Thistle;
            tabPageDetalyZak1.BorderStyle = BorderStyle.Fixed3D;
            tabPageDetalyZak1.Controls.Add(textBox1);
            tabPageDetalyZak1.Location = new Point(4, 24);
            tabPageDetalyZak1.Name = "tabPageDetalyZak1";
            tabPageDetalyZak1.Padding = new Padding(3);
            tabPageDetalyZak1.Size = new Size(505, 464);
            tabPageDetalyZak1.TabIndex = 0;
            tabPageDetalyZak1.Text = "Оплата";
            tabPageDetalyZak1.ToolTipText = "Оплата";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(6, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 447);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Thistle;
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(505, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Доставка";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(6, 6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(493, 452);
            textBox2.TabIndex = 0;
            textBox2.Text = resources.GetString("textBox2.Text");
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Thistle;
            tabPage1.Controls.Add(textBoxDetalyZak);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(505, 464);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Этапы доставки";
            // 
            // textBoxDetalyZak
            // 
            textBoxDetalyZak.BackColor = Color.Thistle;
            textBoxDetalyZak.BorderStyle = BorderStyle.None;
            textBoxDetalyZak.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxDetalyZak.Location = new Point(6, 3);
            textBoxDetalyZak.Multiline = true;
            textBoxDetalyZak.Name = "textBoxDetalyZak";
            textBoxDetalyZak.Size = new Size(493, 445);
            textBoxDetalyZak.TabIndex = 0;
            textBoxDetalyZak.Text = resources.GetString("textBoxDetalyZak.Text");
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = Color.Thistle;
            buttonOK_BKV.FlatStyle = FlatStyle.Popup;
            buttonOK_BKV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_BKV.ForeColor = SystemColors.ActiveCaptionText;
            buttonOK_BKV.Location = new Point(178, 501);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(154, 47);
            buttonOK_BKV.TabIndex = 1;
            buttonOK_BKV.Text = "OK";
            buttonOK_BKV.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.сакура;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 561);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.console_controller__2_4;
            pictureBox1.Location = new Point(58, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormDatalyZak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(813, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "FormDatalyZak";
            Text = "О доставке";
            panel1.ResumeLayout(false);
            tabControlDetalyZak_BKV.ResumeLayout(false);
            tabPageDetalyZak1.ResumeLayout(false);
            tabPageDetalyZak1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button buttonOK_BKV;
        private TabControl tabControlDetalyZak_BKV;
        private TabPage tabPageDetalyZak1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TextBox textBoxDetalyZak;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}