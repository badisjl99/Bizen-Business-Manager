namespace AppTest.Tools
{
    partial class TrendItemUC
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
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CardPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.PriceLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.PriceLabel.Location = new System.Drawing.Point(12, 273);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(38, 32);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "--";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NameLabel.Location = new System.Drawing.Point(3, 13);
            this.NameLabel.MaximumSize = new System.Drawing.Size(250, 100);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 18);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Iphone 14";
            // 
            // CardPicture
            // 
            this.CardPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPicture.Location = new System.Drawing.Point(6, 63);
            this.CardPicture.Name = "CardPicture";
            this.CardPicture.Size = new System.Drawing.Size(205, 181);
            this.CardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardPicture.TabIndex = 6;
            this.CardPicture.TabStop = false;
            // 
            // TrendItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CardPicture);
            this.Name = "TrendItemUC";
            this.Size = new System.Drawing.Size(224, 320);
            ((System.ComponentModel.ISupportInitialize)(this.CardPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox CardPicture;
    }
}
