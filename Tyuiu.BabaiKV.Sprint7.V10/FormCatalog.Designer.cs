namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormCatalog
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
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1862, 910);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // FormCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1878, 1061);
            Controls.Add(groupBox1);
            Name = "FormCatalog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
    }
}