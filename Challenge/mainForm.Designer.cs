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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeTaxButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.cbBoxProducts = new System.Windows.Forms.ComboBox();
            this.writeProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0.2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Tax:";
            // 
            // changeTaxButton
            // 
            this.changeTaxButton.Location = new System.Drawing.Point(253, 51);
            this.changeTaxButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeTaxButton.Name = "changeTaxButton";
            this.changeTaxButton.Size = new System.Drawing.Size(83, 29);
            this.changeTaxButton.TabIndex = 2;
            this.changeTaxButton.Text = "Change tax";
            this.changeTaxButton.UseVisualStyleBackColor = true;
            this.changeTaxButton.Click += new System.EventHandler(this.changeTaxButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 144);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(501, 118);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(9, 10);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(76, 29);
            this.addProductButton.TabIndex = 4;
            this.addProductButton.Text = "Add product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // cbBoxProducts
            // 
            this.cbBoxProducts.FormattingEnabled = true;
            this.cbBoxProducts.Location = new System.Drawing.Point(9, 54);
            this.cbBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.cbBoxProducts.Name = "cbBoxProducts";
            this.cbBoxProducts.Size = new System.Drawing.Size(92, 21);
            this.cbBoxProducts.TabIndex = 5;
            this.cbBoxProducts.SelectedIndexChanged += new System.EventHandler(this.cbBoxProducts_SelectedIndexChanged);
            // 
            // writeProductsButton
            // 
            this.writeProductsButton.Location = new System.Drawing.Point(9, 114);
            this.writeProductsButton.Margin = new System.Windows.Forms.Padding(2);
            this.writeProductsButton.Name = "writeProductsButton";
            this.writeProductsButton.Size = new System.Drawing.Size(91, 25);
            this.writeProductsButton.TabIndex = 6;
            this.writeProductsButton.Text = "Write products";
            this.writeProductsButton.UseVisualStyleBackColor = true;
            this.writeProductsButton.Click += new System.EventHandler(this.writeProductsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.writeProductsButton);
            this.Controls.Add(this.cbBoxProducts);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.changeTaxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "GitChallenge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeTaxButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addProductButton;
        public System.Windows.Forms.ComboBox cbBoxProducts;
        private System.Windows.Forms.Button writeProductsButton;
    }
}

