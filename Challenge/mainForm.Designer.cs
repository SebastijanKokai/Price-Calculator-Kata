namespace Challenge
{
    partial class mainForm
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
            this.txtBoxChangedTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeTaxButton = new System.Windows.Forms.Button();
            this.displayRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.cbBoxProducts = new System.Windows.Forms.ComboBox();
            this.writeProductsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxChangedDiscount = new System.Windows.Forms.TextBox();
            this.changeDiscountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.writeProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxChangedTax
            // 
            this.txtBoxChangedTax.Location = new System.Drawing.Point(138, 66);
            this.txtBoxChangedTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxChangedTax.Name = "txtBoxChangedTax";
            this.txtBoxChangedTax.Size = new System.Drawing.Size(100, 22);
            this.txtBoxChangedTax.TabIndex = 0;
            this.txtBoxChangedTax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Tax:";
            // 
            // changeTaxButton
            // 
            this.changeTaxButton.Location = new System.Drawing.Point(244, 59);
            this.changeTaxButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeTaxButton.Name = "changeTaxButton";
            this.changeTaxButton.Size = new System.Drawing.Size(131, 36);
            this.changeTaxButton.TabIndex = 2;
            this.changeTaxButton.Text = "Change tax";
            this.changeTaxButton.UseVisualStyleBackColor = true;
            this.changeTaxButton.Click += new System.EventHandler(this.changeTaxButton_Click);
            // 
            // displayRichTxtBox
            // 
            this.displayRichTxtBox.Location = new System.Drawing.Point(12, 193);
            this.displayRichTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayRichTxtBox.Name = "displayRichTxtBox";
            this.displayRichTxtBox.ReadOnly = true;
            this.displayRichTxtBox.Size = new System.Drawing.Size(667, 144);
            this.displayRichTxtBox.TabIndex = 3;
            this.displayRichTxtBox.Text = "";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(244, 13);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(131, 36);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Add product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // cbBoxProducts
            // 
            this.cbBoxProducts.FormattingEnabled = true;
            this.cbBoxProducts.Location = new System.Drawing.Point(138, 20);
            this.cbBoxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxProducts.Name = "cbBoxProducts";
            this.cbBoxProducts.Size = new System.Drawing.Size(100, 24);
            this.cbBoxProducts.TabIndex = 5;
            this.cbBoxProducts.SelectedIndexChanged += new System.EventHandler(this.cbBoxProducts_SelectedIndexChanged);
            // 
            // writeProductsButton
            // 
            this.writeProductsButton.Location = new System.Drawing.Point(558, 155);
            this.writeProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.writeProductsButton.Name = "writeProductsButton";
            this.writeProductsButton.Size = new System.Drawing.Size(121, 31);
            this.writeProductsButton.TabIndex = 6;
            this.writeProductsButton.Text = "Write products";
            this.writeProductsButton.UseVisualStyleBackColor = true;
            this.writeProductsButton.Click += new System.EventHandler(this.writeProductsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Discount: ";
            // 
            // txtBoxChangedDiscount
            // 
            this.txtBoxChangedDiscount.Location = new System.Drawing.Point(138, 108);
            this.txtBoxChangedDiscount.Name = "txtBoxChangedDiscount";
            this.txtBoxChangedDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtBoxChangedDiscount.TabIndex = 8;
            // 
            // changeDiscountButton
            // 
            this.changeDiscountButton.Location = new System.Drawing.Point(244, 99);
            this.changeDiscountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDiscountButton.Name = "changeDiscountButton";
            this.changeDiscountButton.Size = new System.Drawing.Size(131, 36);
            this.changeDiscountButton.TabIndex = 9;
            this.changeDiscountButton.Text = "Change discount";
            this.changeDiscountButton.UseVisualStyleBackColor = true;
            this.changeDiscountButton.Click += new System.EventHandler(this.changeDiscountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product:";
            // 
            // writeProductButton
            // 
            this.writeProductButton.Location = new System.Drawing.Point(12, 148);
            this.writeProductButton.Name = "writeProductButton";
            this.writeProductButton.Size = new System.Drawing.Size(140, 38);
            this.writeProductButton.TabIndex = 11;
            this.writeProductButton.Text = "Write one product";
            this.writeProductButton.UseVisualStyleBackColor = true;
            this.writeProductButton.Click += new System.EventHandler(this.WriteProductButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 382);
            this.Controls.Add(this.writeProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeDiscountButton);
            this.Controls.Add(this.txtBoxChangedDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.writeProductsButton);
            this.Controls.Add(this.cbBoxProducts);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.displayRichTxtBox);
            this.Controls.Add(this.changeTaxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxChangedTax);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitChallenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxChangedTax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeTaxButton;
        private System.Windows.Forms.RichTextBox displayRichTxtBox;
        private System.Windows.Forms.Button addProductButton;
        public System.Windows.Forms.ComboBox cbBoxProducts;
        private System.Windows.Forms.Button writeProductsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxChangedDiscount;
        private System.Windows.Forms.Button changeDiscountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeProductButton;
    }
}

