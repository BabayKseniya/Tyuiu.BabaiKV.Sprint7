namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelup = new Panel();
            textBoxDeviz_BKV = new TextBox();
            textBoxNazvanie_BKV = new TextBox();
            panel1 = new Panel();
            buttonOtzivi_BKV = new Button();
            buttonHelp_BKV = new Button();
            buttonCatalog_BKV = new Button();
            textBoxKatalog_BKV = new TextBox();
            buttonDetalyZak_BKV = new Button();
            buttonAboutUs_BKV = new Button();
            buttonGlavMeny_BKV = new Button();
            toolTipGlavMeny_BKV = new ToolTip(components);
            panelup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelup
            // 
            panelup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelup.BackColor = Color.MediumPurple;
            panelup.BackgroundImage = (Image)resources.GetObject("panelup.BackgroundImage");
            panelup.BackgroundImageLayout = ImageLayout.Stretch;
            panelup.Controls.Add(textBoxDeviz_BKV);
            panelup.Controls.Add(textBoxNazvanie_BKV);
            panelup.Location = new Point(-1, 147);
            panelup.Name = "panelup";
            panelup.Size = new Size(786, 414);
            panelup.TabIndex = 0;
            // 
            // textBoxDeviz_BKV
            // 
            textBoxDeviz_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDeviz_BKV.BackColor = Color.Black;
            textBoxDeviz_BKV.BorderStyle = BorderStyle.None;
            textBoxDeviz_BKV.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxDeviz_BKV.ForeColor = Color.Thistle;
            textBoxDeviz_BKV.Location = new Point(13, 92);
            textBoxDeviz_BKV.Multiline = true;
            textBoxDeviz_BKV.Name = "textBoxDeviz_BKV";
            textBoxDeviz_BKV.ReadOnly = true;
            textBoxDeviz_BKV.Size = new Size(282, 52);
            textBoxDeviz_BKV.TabIndex = 1;
            textBoxDeviz_BKV.Text = "при выборе нас, мы гарантируем тебе качество!";
            // 
            // textBoxNazvanie_BKV
            // 
            textBoxNazvanie_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNazvanie_BKV.BackColor = Color.Black;
            textBoxNazvanie_BKV.BorderStyle = BorderStyle.None;
            textBoxNazvanie_BKV.Font = new Font("Palatino Linotype", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNazvanie_BKV.ForeColor = Color.Thistle;
            textBoxNazvanie_BKV.ImeMode = ImeMode.NoControl;
            textBoxNazvanie_BKV.Location = new Point(13, 3);
            textBoxNazvanie_BKV.Multiline = true;
            textBoxNazvanie_BKV.Name = "textBoxNazvanie_BKV";
            textBoxNazvanie_BKV.ReadOnly = true;
            textBoxNazvanie_BKV.Size = new Size(251, 83);
            textBoxNazvanie_BKV.TabIndex = 0;
            textBoxNazvanie_BKV.Text = "I Game";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(buttonOtzivi_BKV);
            panel1.Controls.Add(buttonHelp_BKV);
            panel1.Controls.Add(buttonCatalog_BKV);
            panel1.Controls.Add(textBoxKatalog_BKV);
            panel1.Controls.Add(buttonDetalyZak_BKV);
            panel1.Controls.Add(buttonAboutUs_BKV);
            panel1.Controls.Add(buttonGlavMeny_BKV);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 142);
            panel1.TabIndex = 1;
            // 
            // buttonOtzivi_BKV
            // 
            buttonOtzivi_BKV.FlatStyle = FlatStyle.Popup;
            buttonOtzivi_BKV.Image = Properties.Resources._9b6795c5_4542_43f4_9d79_6bec83fd7af9;
            buttonOtzivi_BKV.Location = new Point(355, 41);
            buttonOtzivi_BKV.Name = "buttonOtzivi_BKV";
            buttonOtzivi_BKV.Size = new Size(62, 65);
            buttonOtzivi_BKV.TabIndex = 6;
            toolTipGlavMeny_BKV.SetToolTip(buttonOtzivi_BKV, "Во вкладке \"Отзывы\" вы сможете найти отзывы других пользователей на наш магазин.\r\n");
            buttonOtzivi_BKV.UseVisualStyleBackColor = true;
            buttonOtzivi_BKV.Click += buttonOtzivi_BKV_Click;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.FlatStyle = FlatStyle.Popup;
            buttonHelp_BKV.Image = Properties.Resources._1c1d8fa7_6bfc_4df3_8529_bf9ccf2e5b92;
            buttonHelp_BKV.Location = new Point(287, 41);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(62, 65);
            buttonHelp_BKV.TabIndex = 5;
            toolTipGlavMeny_BKV.SetToolTip(buttonHelp_BKV, "Во вкладке \"Помощь\" вы сможете найти краткое руководство пользователя, ответы на актуальные вопросы, а также контакты для связи с поддержкой.");
            buttonHelp_BKV.UseVisualStyleBackColor = true;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // buttonCatalog_BKV
            // 
            buttonCatalog_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCatalog_BKV.BackColor = Color.Thistle;
            buttonCatalog_BKV.FlatStyle = FlatStyle.Popup;
            buttonCatalog_BKV.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCatalog_BKV.ForeColor = Color.Indigo;
            buttonCatalog_BKV.Location = new Point(473, 64);
            buttonCatalog_BKV.Name = "buttonCatalog_BKV";
            buttonCatalog_BKV.Size = new Size(277, 54);
            buttonCatalog_BKV.TabIndex = 4;
            buttonCatalog_BKV.Text = "Наш Ассортимент";
            toolTipGlavMeny_BKV.SetToolTip(buttonCatalog_BKV, "Во вкладке \"Наш ассортимент\" вы сможете найти интересующий вас товар. ");
            buttonCatalog_BKV.UseVisualStyleBackColor = false;
            buttonCatalog_BKV.Click += buttonCatalog_BKV_Click;
            // 
            // textBoxKatalog_BKV
            // 
            textBoxKatalog_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxKatalog_BKV.BackColor = Color.Indigo;
            textBoxKatalog_BKV.BorderStyle = BorderStyle.None;
            textBoxKatalog_BKV.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxKatalog_BKV.ForeColor = Color.Thistle;
            textBoxKatalog_BKV.Location = new Point(461, 13);
            textBoxKatalog_BKV.Multiline = true;
            textBoxKatalog_BKV.Name = "textBoxKatalog_BKV";
            textBoxKatalog_BKV.ReadOnly = true;
            textBoxKatalog_BKV.Size = new Size(277, 45);
            textBoxKatalog_BKV.TabIndex = 3;
            textBoxKatalog_BKV.Text = "Перейти в каталог";
            textBoxKatalog_BKV.TextAlign = HorizontalAlignment.Right;
            textBoxKatalog_BKV.WordWrap = false;
            // 
            // buttonDetalyZak_BKV
            // 
            buttonDetalyZak_BKV.FlatStyle = FlatStyle.Popup;
            buttonDetalyZak_BKV.Image = (Image)resources.GetObject("buttonDetalyZak_BKV.Image");
            buttonDetalyZak_BKV.Location = new Point(219, 41);
            buttonDetalyZak_BKV.Name = "buttonDetalyZak_BKV";
            buttonDetalyZak_BKV.Size = new Size(62, 65);
            buttonDetalyZak_BKV.TabIndex = 2;
            buttonDetalyZak_BKV.Text = "\r\n\r\n\r\n";
            toolTipGlavMeny_BKV.SetToolTip(buttonDetalyZak_BKV, "В вкладке \"Оплата и доставка\" вы можете ознакомиться со способами оплаты и доставки. Также здесь вы найдёте этапы доставки.\r\n");
            buttonDetalyZak_BKV.UseVisualStyleBackColor = true;
            buttonDetalyZak_BKV.Click += buttonDetalyZak_BKV_Click;
            // 
            // buttonAboutUs_BKV
            // 
            buttonAboutUs_BKV.FlatStyle = FlatStyle.Popup;
            buttonAboutUs_BKV.Image = (Image)resources.GetObject("buttonAboutUs_BKV.Image");
            buttonAboutUs_BKV.Location = new Point(148, 41);
            buttonAboutUs_BKV.Name = "buttonAboutUs_BKV";
            buttonAboutUs_BKV.Size = new Size(65, 65);
            buttonAboutUs_BKV.TabIndex = 1;
            toolTipGlavMeny_BKV.SetToolTip(buttonAboutUs_BKV, "В вкладке \"О нас\" вы можете лучше ознакомиться с нашей компанией.\r\n");
            buttonAboutUs_BKV.UseVisualStyleBackColor = true;
            buttonAboutUs_BKV.Click += buttonAboutUs_BKV_Click;
            // 
            // buttonGlavMeny_BKV
            // 
            buttonGlavMeny_BKV.FlatStyle = FlatStyle.Popup;
            buttonGlavMeny_BKV.Image = (Image)resources.GetObject("buttonGlavMeny_BKV.Image");
            buttonGlavMeny_BKV.Location = new Point(30, 26);
            buttonGlavMeny_BKV.Name = "buttonGlavMeny_BKV";
            buttonGlavMeny_BKV.Size = new Size(101, 99);
            buttonGlavMeny_BKV.TabIndex = 0;
            buttonGlavMeny_BKV.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonGlavMeny_BKV.UseVisualStyleBackColor = true;
            buttonGlavMeny_BKV.Click += buttonGlavMeny_BKV_Click;
            // 
            // toolTipGlavMeny_BKV
            // 
            toolTipGlavMeny_BKV.BackColor = Color.Thistle;
            toolTipGlavMeny_BKV.IsBalloon = true;
            toolTipGlavMeny_BKV.ToolTipIcon = ToolTipIcon.Info;
            toolTipGlavMeny_BKV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Indigo;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(panelup);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            panelup.ResumeLayout(false);
            panelup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelup;
        private Panel panel1;
        private Button buttonGlavMeny_BKV;
        private Button buttonAboutUs_BKV;
        private Button buttonDetalyZak_BKV;
        private TextBox textBoxKatalog_BKV;
        private Button buttonCatalog_BKV;
        private TextBox textBoxNazvanie_BKV;
        private TextBox textBoxDeviz_BKV;
        private Button buttonHelp_BKV;
        private Button buttonOtzivi_BKV;
        private ToolTip toolTipGlavMeny_BKV;
    }
}
