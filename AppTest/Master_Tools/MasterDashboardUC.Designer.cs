namespace AppTest.Master_Tools
{
    partial class MasterDashboardUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDashboardUC));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rect2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rect1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientsCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalStaffLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RevenuesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.rect2.SuspendLayout();
            this.rect1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rect2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rect1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1661, 252);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rect2
            // 
            this.rect2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rect2.AutoRoundedCorners = true;
            this.rect2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.rect2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rect2.BackgroundImage")));
            this.rect2.BorderRadius = 87;
            this.rect2.BorderThickness = 1;
            this.rect2.Controls.Add(this.ProductCount);
            this.rect2.Controls.Add(this.label3);
            this.rect2.Location = new System.Drawing.Point(471, 38);
            this.rect2.Name = "rect2";
            this.rect2.Size = new System.Drawing.Size(303, 176);
            this.rect2.TabIndex = 1;
            // 
            // ProductCount
            // 
            this.ProductCount.AutoSize = true;
            this.ProductCount.BackColor = System.Drawing.Color.Transparent;
            this.ProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.ProductCount.Location = new System.Drawing.Point(126, 93);
            this.ProductCount.Name = "ProductCount";
            this.ProductCount.Size = new System.Drawing.Size(52, 55);
            this.ProductCount.TabIndex = 3;
            this.ProductCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Products :";
            // 
            // rect1
            // 
            this.rect1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rect1.AutoRoundedCorners = true;
            this.rect1.BackColor = System.Drawing.Color.Khaki;
            this.rect1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rect1.BackgroundImage")));
            this.rect1.BorderRadius = 87;
            this.rect1.BorderThickness = 1;
            this.rect1.Controls.Add(this.label4);
            this.rect1.Controls.Add(this.ClientsCount);
            this.rect1.Location = new System.Drawing.Point(56, 38);
            this.rect1.Name = "rect1";
            this.rect1.Size = new System.Drawing.Size(303, 176);
            this.rect1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 21.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 42);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Clients :";
            // 
            // ClientsCount
            // 
            this.ClientsCount.AutoSize = true;
            this.ClientsCount.BackColor = System.Drawing.Color.Transparent;
            this.ClientsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientsCount.Location = new System.Drawing.Point(145, 93);
            this.ClientsCount.Name = "ClientsCount";
            this.ClientsCount.Size = new System.Drawing.Size(52, 55);
            this.ClientsCount.TabIndex = 0;
            this.ClientsCount.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TotalStaffLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(886, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 176);
            this.panel2.TabIndex = 2;
            // 
            // TotalStaffLabel
            // 
            this.TotalStaffLabel.AutoSize = true;
            this.TotalStaffLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalStaffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.TotalStaffLabel.Location = new System.Drawing.Point(138, 92);
            this.TotalStaffLabel.Name = "TotalStaffLabel";
            this.TotalStaffLabel.Size = new System.Drawing.Size(52, 55);
            this.TotalStaffLabel.TabIndex = 4;
            this.TotalStaffLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 21.75F);
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Staff :";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RevenuesLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1301, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 176);
            this.panel1.TabIndex = 5;
            // 
            // RevenuesLabel
            // 
            this.RevenuesLabel.AutoSize = true;
            this.RevenuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.RevenuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.RevenuesLabel.Location = new System.Drawing.Point(22, 92);
            this.RevenuesLabel.Name = "RevenuesLabel";
            this.RevenuesLabel.Size = new System.Drawing.Size(43, 46);
            this.RevenuesLabel.TabIndex = 4;
            this.RevenuesLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 21.75F);
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Revenues :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 24.75F);
            this.label1.Location = new System.Drawing.Point(265, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "$";
            // 
            // MasterDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MasterDashboardUC";
            this.Size = new System.Drawing.Size(1667, 877);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.rect2.ResumeLayout(false);
            this.rect2.PerformLayout();
            this.rect1.ResumeLayout(false);
            this.rect1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel rect2;
        private System.Windows.Forms.Label ProductCount;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel rect1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClientsCount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TotalStaffLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RevenuesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
