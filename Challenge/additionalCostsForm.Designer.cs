namespace Challenge
{
    partial class additionalCostsForm
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
            this.applyAdditionalCostsButton = new System.Windows.Forms.Button();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.radioButtonAmount = new System.Windows.Forms.RadioButton();
            this.radioButtonPerc = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBoxAmount = new System.Windows.Forms.GroupBox();
            this.groupBoxAdditionalCost = new System.Windows.Forms.GroupBox();
            this.radioButtonAdministrative = new System.Windows.Forms.RadioButton();
            this.radioButtonPackaging = new System.Windows.Forms.RadioButton();
            this.radioButtonTransport = new System.Windows.Forms.RadioButton();
            this.groupBoxAmount.SuspendLayout();
            this.groupBoxAdditionalCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyAdditionalCostsButton
            // 
            this.applyAdditionalCostsButton.Location = new System.Drawing.Point(12, 186);
            this.applyAdditionalCostsButton.Name = "applyAdditionalCostsButton";
            this.applyAdditionalCostsButton.Size = new System.Drawing.Size(75, 31);
            this.applyAdditionalCostsButton.TabIndex = 23;
            this.applyAdditionalCostsButton.Text = "Apply";
            this.applyAdditionalCostsButton.UseVisualStyleBackColor = true;
            this.applyAdditionalCostsButton.Click += new System.EventHandler(this.ApplyAdditionalCostsButton_Click);
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(126, 126);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAmount.TabIndex = 22;
            this.txtBoxAmount.TextChanged += new System.EventHandler(this.TxtBoxAmount_TextChanged);
            // 
            // radioButtonAmount
            // 
            this.radioButtonAmount.AutoSize = true;
            this.radioButtonAmount.Location = new System.Drawing.Point(6, 48);
            this.radioButtonAmount.Name = "radioButtonAmount";
            this.radioButtonAmount.Size = new System.Drawing.Size(81, 21);
            this.radioButtonAmount.TabIndex = 19;
            this.radioButtonAmount.Text = "Amount:";
            this.radioButtonAmount.UseVisualStyleBackColor = true;
            this.radioButtonAmount.CheckedChanged += new System.EventHandler(this.RadioButtonAmount_CheckedChanged);
            // 
            // radioButtonPerc
            // 
            this.radioButtonPerc.AutoSize = true;
            this.radioButtonPerc.Checked = true;
            this.radioButtonPerc.Location = new System.Drawing.Point(6, 21);
            this.radioButtonPerc.Name = "radioButtonPerc";
            this.radioButtonPerc.Size = new System.Drawing.Size(92, 21);
            this.radioButtonPerc.TabIndex = 18;
            this.radioButtonPerc.TabStop = true;
            this.radioButtonPerc.Text = "% of price";
            this.radioButtonPerc.UseVisualStyleBackColor = true;
            this.radioButtonPerc.CheckedChanged += new System.EventHandler(this.RadioButtonPerc_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(93, 186);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 31);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBoxAmount
            // 
            this.groupBoxAmount.Controls.Add(this.radioButtonPerc);
            this.groupBoxAmount.Controls.Add(this.radioButtonAmount);
            this.groupBoxAmount.Location = new System.Drawing.Point(12, 89);
            this.groupBoxAmount.Name = "groupBoxAmount";
            this.groupBoxAmount.Size = new System.Drawing.Size(108, 91);
            this.groupBoxAmount.TabIndex = 25;
            this.groupBoxAmount.TabStop = false;
            this.groupBoxAmount.Text = "Payment in";
            // 
            // groupBoxAdditionalCost
            // 
            this.groupBoxAdditionalCost.Controls.Add(this.radioButtonAdministrative);
            this.groupBoxAdditionalCost.Controls.Add(this.radioButtonPackaging);
            this.groupBoxAdditionalCost.Controls.Add(this.radioButtonTransport);
            this.groupBoxAdditionalCost.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAdditionalCost.Name = "groupBoxAdditionalCost";
            this.groupBoxAdditionalCost.Size = new System.Drawing.Size(363, 69);
            this.groupBoxAdditionalCost.TabIndex = 26;
            this.groupBoxAdditionalCost.TabStop = false;
            this.groupBoxAdditionalCost.Text = "Type";
            // 
            // radioButtonAdministrative
            // 
            this.radioButtonAdministrative.AutoSize = true;
            this.radioButtonAdministrative.Location = new System.Drawing.Point(205, 22);
            this.radioButtonAdministrative.Name = "radioButtonAdministrative";
            this.radioButtonAdministrative.Size = new System.Drawing.Size(147, 21);
            this.radioButtonAdministrative.TabIndex = 2;
            this.radioButtonAdministrative.Text = "Administrative cost";
            this.radioButtonAdministrative.UseVisualStyleBackColor = true;
            // 
            // radioButtonPackaging
            // 
            this.radioButtonPackaging.AutoSize = true;
            this.radioButtonPackaging.Location = new System.Drawing.Point(104, 21);
            this.radioButtonPackaging.Name = "radioButtonPackaging";
            this.radioButtonPackaging.Size = new System.Drawing.Size(95, 21);
            this.radioButtonPackaging.TabIndex = 1;
            this.radioButtonPackaging.Text = "Packaging";
            this.radioButtonPackaging.UseVisualStyleBackColor = true;
            // 
            // radioButtonTransport
            // 
            this.radioButtonTransport.AutoSize = true;
            this.radioButtonTransport.Checked = true;
            this.radioButtonTransport.Location = new System.Drawing.Point(7, 21);
            this.radioButtonTransport.Name = "radioButtonTransport";
            this.radioButtonTransport.Size = new System.Drawing.Size(91, 21);
            this.radioButtonTransport.TabIndex = 0;
            this.radioButtonTransport.TabStop = true;
            this.radioButtonTransport.Text = "Transport";
            this.radioButtonTransport.UseVisualStyleBackColor = true;
            // 
            // additionalCostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 283);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdditionalCost);
            this.Controls.Add(this.groupBoxAmount);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.applyAdditionalCostsButton);
            this.Controls.Add(this.txtBoxAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "additionalCostsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add additional costs";
            this.groupBoxAmount.ResumeLayout(false);
            this.groupBoxAmount.PerformLayout();
            this.groupBoxAdditionalCost.ResumeLayout(false);
            this.groupBoxAdditionalCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyAdditionalCostsButton;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.RadioButton radioButtonAmount;
        private System.Windows.Forms.RadioButton radioButtonPerc;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBoxAmount;
        private System.Windows.Forms.GroupBox groupBoxAdditionalCost;
        private System.Windows.Forms.RadioButton radioButtonAdministrative;
        private System.Windows.Forms.RadioButton radioButtonPackaging;
        private System.Windows.Forms.RadioButton radioButtonTransport;
    }
}