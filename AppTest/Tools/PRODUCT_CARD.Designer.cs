namespace AppTest.Tools
{
    partial class PRODUCT_CARD
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
            this.CardPicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CardPicture
            // 
            this.CardPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPicture.Location = new System.Drawing.Point(8, 68);
            this.CardPicture.Name = "CardPicture";
            this.CardPicture.Size = new System.Drawing.Size(234, 145);
            this.CardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardPicture.TabIndex = 0;
            this.CardPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.Location = new System.Drawing.Point(3, 19);
            this.NameLabel.MaximumSize = new System.Drawing.Size(250, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(80, 19);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Iphone 14";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.PriceLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PriceLabel.Location = new System.Drawing.Point(121, 314);
            this.PriceLabel.MaximumSize = new System.Drawing.Size(70, 32);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(38, 32);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "--";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("NewsGoth BT", 8.75F);
            this.DescriptionLabel.Location = new System.Drawing.Point(5, 227);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(250, 150);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(154, 60);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Iphone 14Pro Max 256 GB ,\r\n USA Version Iphone 14Pro \r\nMax 256 GB , USA Version \r" +
    "\n ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(198, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = " $";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.25F, System.Drawing.FontStyle.Bold);
            this.QuantityLabel.ForeColor = System.Drawing.Color.Teal;
            this.QuantityLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.QuantityLabel.Location = new System.Drawing.Point(192, 78);
            this.QuantityLabel.MaximumSize = new System.Drawing.Size(70, 32);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(43, 32);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "--";
            // 
            // PRODUCT_CARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CardPicture);
            this.Name = "PRODUCT_CARD";
            this.Size = new System.Drawing.Size(291, 350);
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CardPicture;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuantityLabel;
    }
}
