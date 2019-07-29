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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxChangedDiscount = new System.Windows.Forms.TextBox();
            this.changeDiscountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.writeProductButton = new System.Windows.Forms.Button();
            this.txtBoxUniDisc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.applyUniDiscButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDiscCap = new System.Windows.Forms.TextBox();
            this.applyDiscCapButton = new System.Windows.Forms.Button();
            this.radioButtonPercentageCap = new System.Windows.Forms.RadioButton();
            this.radioButtonAmountCap = new System.Windows.Forms.RadioButton();
            this.radioButtonAdditiveDisc = new System.Windows.Forms.RadioButton();
            this.groupBoxDiscountCap = new System.Windows.Forms.GroupBox();
            this.groupBoxDiscountType = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplicativeDisc = new System.Windows.Forms.RadioButton();
            this.groupBoxSelDisc = new System.Windows.Forms.GroupBox();
            this.rdButtonBTSelective = new System.Windows.Forms.RadioButton();
            this.rdButtonATSelective = new System.Windows.Forms.RadioButton();
            this.groupBoxUniDisc = new System.Windows.Forms.GroupBox();
            this.rdButtonBTUniversal = new System.Windows.Forms.RadioButton();
            this.rdButtonATUniversal = new System.Windows.Forms.RadioButton();
            this.groupBoxDiscountCap.SuspendLayout();
            this.groupBoxDiscountType.SuspendLayout();
            this.groupBoxSelDisc.SuspendLayout();
            this.groupBoxUniDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxChangedTax
            // 
            this.txtBoxChangedTax.Location = new System.Drawing.Point(148, 58);
            this.txtBoxChangedTax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxChangedTax.Name = "txtBoxChangedTax";
            this.txtBoxChangedTax.Size = new System.Drawing.Size(100, 22);
            this.txtBoxChangedTax.TabIndex = 0;
            this.txtBoxChangedTax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tax:";
            // 
            // changeTaxButton
            // 
            this.changeTaxButton.Location = new System.Drawing.Point(254, 51);
            this.changeTaxButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeTaxButton.Name = "changeTaxButton";
            this.changeTaxButton.Size = new System.Drawing.Size(131, 36);
            this.changeTaxButton.TabIndex = 2;
            this.changeTaxButton.Text = "Apply";
            this.changeTaxButton.UseVisualStyleBackColor = true;
            this.changeTaxButton.Click += new System.EventHandler(this.changeTaxButton_Click);
            // 
            // displayRichTxtBox
            // 
            this.displayRichTxtBox.Location = new System.Drawing.Point(15, 361);
            this.displayRichTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayRichTxtBox.Name = "displayRichTxtBox";
            this.displayRichTxtBox.ReadOnly = true;
            this.displayRichTxtBox.Size = new System.Drawing.Size(444, 144);
            this.displayRichTxtBox.TabIndex = 3;
            this.displayRichTxtBox.Text = "";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(254, 9);
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
            this.cbBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxProducts.FormattingEnabled = true;
            this.cbBoxProducts.Location = new System.Drawing.Point(148, 16);
            this.cbBoxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBoxProducts.Name = "cbBoxProducts";
            this.cbBoxProducts.Size = new System.Drawing.Size(100, 24);
            this.cbBoxProducts.TabIndex = 5;
            this.cbBoxProducts.SelectedIndexChanged += new System.EventHandler(this.cbBoxProducts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selective discount:";
            // 
            // txtBoxChangedDiscount
            // 
            this.txtBoxChangedDiscount.Location = new System.Drawing.Point(148, 100);
            this.txtBoxChangedDiscount.Name = "txtBoxChangedDiscount";
            this.txtBoxChangedDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtBoxChangedDiscount.TabIndex = 8;
            // 
            // changeDiscountButton
            // 
            this.changeDiscountButton.Location = new System.Drawing.Point(254, 93);
            this.changeDiscountButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeDiscountButton.Name = "changeDiscountButton";
            this.changeDiscountButton.Size = new System.Drawing.Size(131, 36);
            this.changeDiscountButton.TabIndex = 9;
            this.changeDiscountButton.Text = "Apply";
            this.changeDiscountButton.UseVisualStyleBackColor = true;
            this.changeDiscountButton.Click += new System.EventHandler(this.changeDiscountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product:";
            // 
            // writeProductButton
            // 
            this.writeProductButton.Location = new System.Drawing.Point(15, 326);
            this.writeProductButton.Name = "writeProductButton";
            this.writeProductButton.Size = new System.Drawing.Size(190, 30);
            this.writeProductButton.TabIndex = 11;
            this.writeProductButton.Text = "Show selected product";
            this.writeProductButton.UseVisualStyleBackColor = true;
            this.writeProductButton.Click += new System.EventHandler(this.WriteProductButton_Click);
            // 
            // txtBoxUniDisc
            // 
            this.txtBoxUniDisc.Location = new System.Drawing.Point(148, 143);
            this.txtBoxUniDisc.Name = "txtBoxUniDisc";
            this.txtBoxUniDisc.Size = new System.Drawing.Size(100, 22);
            this.txtBoxUniDisc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Universal discount:";
            // 
            // applyUniDiscButton
            // 
            this.applyUniDiscButton.Location = new System.Drawing.Point(254, 134);
            this.applyUniDiscButton.Name = "applyUniDiscButton";
            this.applyUniDiscButton.Size = new System.Drawing.Size(131, 36);
            this.applyUniDiscButton.TabIndex = 14;
            this.applyUniDiscButton.Text = "Apply";
            this.applyUniDiscButton.UseVisualStyleBackColor = true;
            this.applyUniDiscButton.Click += new System.EventHandler(this.applyUniDiscButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(402, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Use decimals for percentages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(546, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "(0.1 for 10%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Discount cap:";
            // 
            // txtBoxDiscCap
            // 
            this.txtBoxDiscCap.Location = new System.Drawing.Point(148, 182);
            this.txtBoxDiscCap.Name = "txtBoxDiscCap";
            this.txtBoxDiscCap.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDiscCap.TabIndex = 18;
            // 
            // applyDiscCapButton
            // 
            this.applyDiscCapButton.Location = new System.Drawing.Point(254, 175);
            this.applyDiscCapButton.Name = "applyDiscCapButton";
            this.applyDiscCapButton.Size = new System.Drawing.Size(131, 36);
            this.applyDiscCapButton.TabIndex = 19;
            this.applyDiscCapButton.Text = "Apply";
            this.applyDiscCapButton.UseVisualStyleBackColor = true;
            this.applyDiscCapButton.Click += new System.EventHandler(this.ApplyDiscCapButton_Click);
            // 
            // radioButtonPercentageCap
            // 
            this.radioButtonPercentageCap.AutoSize = true;
            this.radioButtonPercentageCap.Location = new System.Drawing.Point(6, 53);
            this.radioButtonPercentageCap.Name = "radioButtonPercentageCap";
            this.radioButtonPercentageCap.Size = new System.Drawing.Size(102, 21);
            this.radioButtonPercentageCap.TabIndex = 20;
            this.radioButtonPercentageCap.Text = "Percentage";
            this.radioButtonPercentageCap.UseVisualStyleBackColor = true;
            // 
            // radioButtonAmountCap
            // 
            this.radioButtonAmountCap.AutoSize = true;
            this.radioButtonAmountCap.Checked = true;
            this.radioButtonAmountCap.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAmountCap.Name = "radioButtonAmountCap";
            this.radioButtonAmountCap.Size = new System.Drawing.Size(77, 21);
            this.radioButtonAmountCap.TabIndex = 21;
            this.radioButtonAmountCap.TabStop = true;
            this.radioButtonAmountCap.Text = "Amount";
            this.radioButtonAmountCap.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdditiveDisc
            // 
            this.radioButtonAdditiveDisc.AutoSize = true;
            this.radioButtonAdditiveDisc.Checked = true;
            this.radioButtonAdditiveDisc.Location = new System.Drawing.Point(6, 26);
            this.radioButtonAdditiveDisc.Name = "radioButtonAdditiveDisc";
            this.radioButtonAdditiveDisc.Size = new System.Drawing.Size(79, 21);
            this.radioButtonAdditiveDisc.TabIndex = 22;
            this.radioButtonAdditiveDisc.TabStop = true;
            this.radioButtonAdditiveDisc.Text = "Additive";
            this.radioButtonAdditiveDisc.UseVisualStyleBackColor = true;
            // 
            // groupBoxDiscountCap
            // 
            this.groupBoxDiscountCap.Controls.Add(this.radioButtonPercentageCap);
            this.groupBoxDiscountCap.Controls.Add(this.radioButtonAmountCap);
            this.groupBoxDiscountCap.Location = new System.Drawing.Point(15, 214);
            this.groupBoxDiscountCap.Name = "groupBoxDiscountCap";
            this.groupBoxDiscountCap.Size = new System.Drawing.Size(113, 81);
            this.groupBoxDiscountCap.TabIndex = 23;
            this.groupBoxDiscountCap.TabStop = false;
            this.groupBoxDiscountCap.Text = "Cap Type";
            // 
            // groupBoxDiscountType
            // 
            this.groupBoxDiscountType.Controls.Add(this.radioButtonMultiplicativeDisc);
            this.groupBoxDiscountType.Controls.Add(this.radioButtonAdditiveDisc);
            this.groupBoxDiscountType.Location = new System.Drawing.Point(249, 303);
            this.groupBoxDiscountType.Name = "groupBoxDiscountType";
            this.groupBoxDiscountType.Size = new System.Drawing.Size(210, 53);
            this.groupBoxDiscountType.TabIndex = 24;
            this.groupBoxDiscountType.TabStop = false;
            this.groupBoxDiscountType.Text = "Discount Type";
            // 
            // radioButtonMultiplicativeDisc
            // 
            this.radioButtonMultiplicativeDisc.AutoSize = true;
            this.radioButtonMultiplicativeDisc.Location = new System.Drawing.Point(91, 26);
            this.radioButtonMultiplicativeDisc.Name = "radioButtonMultiplicativeDisc";
            this.radioButtonMultiplicativeDisc.Size = new System.Drawing.Size(109, 21);
            this.radioButtonMultiplicativeDisc.TabIndex = 23;
            this.radioButtonMultiplicativeDisc.Text = "Multiplicative";
            this.radioButtonMultiplicativeDisc.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelDisc
            // 
            this.groupBoxSelDisc.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSelDisc.Controls.Add(this.rdButtonBTSelective);
            this.groupBoxSelDisc.Controls.Add(this.rdButtonATSelective);
            this.groupBoxSelDisc.Location = new System.Drawing.Point(407, 93);
            this.groupBoxSelDisc.Name = "groupBoxSelDisc";
            this.groupBoxSelDisc.Size = new System.Drawing.Size(211, 36);
            this.groupBoxSelDisc.TabIndex = 25;
            this.groupBoxSelDisc.TabStop = false;
            this.groupBoxSelDisc.Text = "When to discount";
            // 
            // rdButtonBTSelective
            // 
            this.rdButtonBTSelective.AutoSize = true;
            this.rdButtonBTSelective.Location = new System.Drawing.Point(93, 15);
            this.rdButtonBTSelective.Name = "rdButtonBTSelective";
            this.rdButtonBTSelective.Size = new System.Drawing.Size(93, 21);
            this.rdButtonBTSelective.TabIndex = 28;
            this.rdButtonBTSelective.Text = "Before tax";
            this.rdButtonBTSelective.UseVisualStyleBackColor = true;
            // 
            // rdButtonATSelective
            // 
            this.rdButtonATSelective.AutoSize = true;
            this.rdButtonATSelective.Checked = true;
            this.rdButtonATSelective.Location = new System.Drawing.Point(6, 15);
            this.rdButtonATSelective.Name = "rdButtonATSelective";
            this.rdButtonATSelective.Size = new System.Drawing.Size(81, 21);
            this.rdButtonATSelective.TabIndex = 27;
            this.rdButtonATSelective.TabStop = true;
            this.rdButtonATSelective.Text = "After tax";
            this.rdButtonATSelective.UseVisualStyleBackColor = true;
            // 
            // groupBoxUniDisc
            // 
            this.groupBoxUniDisc.Controls.Add(this.rdButtonBTUniversal);
            this.groupBoxUniDisc.Controls.Add(this.rdButtonATUniversal);
            this.groupBoxUniDisc.Location = new System.Drawing.Point(407, 134);
            this.groupBoxUniDisc.Name = "groupBoxUniDisc";
            this.groupBoxUniDisc.Size = new System.Drawing.Size(211, 36);
            this.groupBoxUniDisc.TabIndex = 26;
            this.groupBoxUniDisc.TabStop = false;
            this.groupBoxUniDisc.Text = "When to discount";
            // 
            // rdButtonBTUniversal
            // 
            this.rdButtonBTUniversal.AutoSize = true;
            this.rdButtonBTUniversal.Location = new System.Drawing.Point(93, 15);
            this.rdButtonBTUniversal.Name = "rdButtonBTUniversal";
            this.rdButtonBTUniversal.Size = new System.Drawing.Size(93, 21);
            this.rdButtonBTUniversal.TabIndex = 29;
            this.rdButtonBTUniversal.Text = "Before tax";
            this.rdButtonBTUniversal.UseVisualStyleBackColor = true;
            // 
            // rdButtonATUniversal
            // 
            this.rdButtonATUniversal.AutoSize = true;
            this.rdButtonATUniversal.Checked = true;
            this.rdButtonATUniversal.Location = new System.Drawing.Point(6, 15);
            this.rdButtonATUniversal.Name = "rdButtonATUniversal";
            this.rdButtonATUniversal.Size = new System.Drawing.Size(81, 21);
            this.rdButtonATUniversal.TabIndex = 28;
            this.rdButtonATUniversal.TabStop = true;
            this.rdButtonATUniversal.Text = "After tax";
            this.rdButtonATUniversal.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 530);
            this.Controls.Add(this.groupBoxUniDisc);
            this.Controls.Add(this.groupBoxSelDisc);
            this.Controls.Add(this.groupBoxDiscountType);
            this.Controls.Add(this.groupBoxDiscountCap);
            this.Controls.Add(this.applyDiscCapButton);
            this.Controls.Add(this.txtBoxDiscCap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.applyUniDiscButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxUniDisc);
            this.Controls.Add(this.writeProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeDiscountButton);
            this.Controls.Add(this.txtBoxChangedDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBoxProducts);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.displayRichTxtBox);
            this.Controls.Add(this.changeTaxButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxChangedTax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDiscountCap.ResumeLayout(false);
            this.groupBoxDiscountCap.PerformLayout();
            this.groupBoxDiscountType.ResumeLayout(false);
            this.groupBoxDiscountType.PerformLayout();
            this.groupBoxSelDisc.ResumeLayout(false);
            this.groupBoxSelDisc.PerformLayout();
            this.groupBoxUniDisc.ResumeLayout(false);
            this.groupBoxUniDisc.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxChangedDiscount;
        private System.Windows.Forms.Button changeDiscountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeProductButton;
        private System.Windows.Forms.TextBox txtBoxUniDisc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyUniDiscButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDiscCap;
        private System.Windows.Forms.Button applyDiscCapButton;
        private System.Windows.Forms.RadioButton radioButtonPercentageCap;
        private System.Windows.Forms.RadioButton radioButtonAmountCap;
        private System.Windows.Forms.RadioButton radioButtonAdditiveDisc;
        private System.Windows.Forms.GroupBox groupBoxDiscountCap;
        private System.Windows.Forms.GroupBox groupBoxDiscountType;
        private System.Windows.Forms.RadioButton radioButtonMultiplicativeDisc;
        private System.Windows.Forms.GroupBox groupBoxSelDisc;
        private System.Windows.Forms.RadioButton rdButtonBTSelective;
        private System.Windows.Forms.RadioButton rdButtonATSelective;
        private System.Windows.Forms.GroupBox groupBoxUniDisc;
        private System.Windows.Forms.RadioButton rdButtonBTUniversal;
        private System.Windows.Forms.RadioButton rdButtonATUniversal;
    }
}

