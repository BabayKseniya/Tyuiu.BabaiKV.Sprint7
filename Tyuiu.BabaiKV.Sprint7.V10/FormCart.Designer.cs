namespace Tyuiu.BabaiKV.Sprint7.V10
{
    partial class FormCart
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
            btnPlaceOrder = new Button();
            dataGridViewCart = new DataGridView();
            textBox1 = new TextBox();
            btnCalculateTotal = new Button();
            txtResult = new TextBox();
            textBox2 = new TextBox();
            toolTipCart = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.LightPink;
            btnPlaceOrder.FlatStyle = FlatStyle.Popup;
            btnPlaceOrder.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnPlaceOrder.Location = new Point(370, 577);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(314, 52);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Оформить заказ";
            toolTipCart.SetToolTip(btnPlaceOrder, "Перейти к заполнению анкеты");
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.BackgroundColor = Color.Pink;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(12, 94);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersVisible = false;
            dataGridViewCart.Size = new Size(506, 441);
            dataGridViewCart.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Thistle;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(331, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 76);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ваш заказ";
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.BackColor = Color.Pink;
            btnCalculateTotal.FlatStyle = FlatStyle.Popup;
            btnCalculateTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCalculateTotal.Location = new Point(543, 452);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(170, 82);
            btnCalculateTotal.TabIndex = 5;
            btnCalculateTotal.Text = "Подсчитать итог";
            toolTipCart.SetToolTip(btnCalculateTotal, "Подсчитать итоговую сумму к оплате");
            btnCalculateTotal.UseVisualStyleBackColor = false;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtResult.Location = new Point(727, 451);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(284, 84);
            txtResult.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Thistle;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(543, 230);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(442, 91);
            textBox2.TabIndex = 7;
            textBox2.Text = "Внимательно проверьте ваш заказ!!! в кредит не даём!!!!";
            // 
            // toolTipCart
            // 
            toolTipCart.IsBalloon = true;
            toolTipCart.ToolTipTitle = "Подсказка";
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1023, 651);
            Controls.Add(textBox2);
            Controls.Add(txtResult);
            Controls.Add(btnCalculateTotal);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewCart);
            Controls.Add(btnPlaceOrder);
            Name = "FormCart";
            Text = "Корзина";
            Load += FormCart_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPlaceOrder;
        private DataGridView dataGridViewCart;
        private TextBox textBox1;
        private Button btnCalculateTotal;
        private TextBox txtResult;
        private TextBox textBox2;
        private ToolTip toolTipCart;
    }
}