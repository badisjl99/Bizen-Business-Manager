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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenuesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rect2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rect1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientsCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TotalStaffLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ToDoGauge = new LiveCharts.WinForms.SolidGauge();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rect2.SuspendLayout();
            this.rect1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1661, 252);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RevenuesLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1301, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 176);
            this.panel1.TabIndex = 5;
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
            // RevenuesLabel
            // 
            this.RevenuesLabel.AutoSize = true;
            this.RevenuesLabel.BackColor = System.Drawing.Color.Transparent;
            this.RevenuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.RevenuesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RevenuesLabel.Location = new System.Drawing.Point(29, 101);
            this.RevenuesLabel.Name = "RevenuesLabel";
            this.RevenuesLabel.Size = new System.Drawing.Size(43, 46);
            this.RevenuesLabel.TabIndex = 4;
            this.RevenuesLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 21.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Revenues :";
            // 
            // rect2
            // 
            this.rect2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rect2.AutoRoundedCorners = true;
            this.rect2.BackColor = System.Drawing.Color.Transparent;
            this.rect2.BorderRadius = 87;
            this.rect2.BorderThickness = 1;
            this.rect2.Controls.Add(this.pictureBox2);
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
            this.ProductCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ProductCount.Location = new System.Drawing.Point(126, 102);
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
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Products :";
            // 
            // rect1
            // 
            this.rect1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rect1.AutoRoundedCorners = true;
            this.rect1.BackColor = System.Drawing.Color.Transparent;
            this.rect1.BorderRadius = 87;
            this.rect1.BorderThickness = 1;
            this.rect1.Controls.Add(this.pictureBox1);
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
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(40, 51);
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
            this.ClientsCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientsCount.Location = new System.Drawing.Point(98, 102);
            this.ClientsCount.Name = "ClientsCount";
            this.ClientsCount.Size = new System.Drawing.Size(52, 55);
            this.ClientsCount.TabIndex = 0;
            this.ClientsCount.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
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
            this.TotalStaffLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalStaffLabel.Location = new System.Drawing.Point(126, 94);
            this.TotalStaffLabel.Name = "TotalStaffLabel";
            this.TotalStaffLabel.Size = new System.Drawing.Size(52, 55);
            this.TotalStaffLabel.TabIndex = 4;
            this.TotalStaffLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 21.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(44, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Staff :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ToDoGauge, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(167, 316);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1355, 481);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // ToDoGauge
            // 
            this.ToDoGauge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToDoGauge.Location = new System.Drawing.Point(749, 99);
            this.ToDoGauge.Name = "ToDoGauge";
            this.ToDoGauge.Size = new System.Drawing.Size(534, 282);
            this.ToDoGauge.TabIndex = 0;
            this.ToDoGauge.Text = "solidGauge1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(242, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(242, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // MasterDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MasterDashboardUC";
            this.Size = new System.Drawing.Size(1667, 877);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rect2.ResumeLayout(false);
            this.rect2.PerformLayout();
            this.rect1.ResumeLayout(false);
            this.rect1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LiveCharts.WinForms.SolidGauge ToDoGauge;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
