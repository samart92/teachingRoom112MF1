namespace teachingRoom112MF.controll
{
    partial class ucProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblProName = new System.Windows.Forms.Label();
            this.lblPrices = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(12, 5);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(47, 29);
            this.lblSKU.TabIndex = 0;
            this.lblSKU.Text = "SKU";
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.Location = new System.Drawing.Point(12, 42);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(151, 34);
            this.lblProName.TabIndex = 1;
            this.lblProName.Text = "Product Name";
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.Font = new System.Drawing.Font("Khmer OS Battambang", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrices.Location = new System.Drawing.Point(12, 84);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(62, 31);
            this.lblPrices.TabIndex = 2;
            this.lblPrices.Text = "Prices";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.lblSKU);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ucProductItem";
            this.Size = new System.Drawing.Size(232, 120);
            this.Click += new System.EventHandler(this.ucProductItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Button btnAdd;
    }
}
