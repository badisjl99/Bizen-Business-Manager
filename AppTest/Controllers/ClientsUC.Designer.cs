namespace AppTest.Controllers
{
    partial class ClientsUC
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
            this.Clients_Container = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NormalClientButton = new System.Windows.Forms.Button();
            this.Clients_Container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clients_Container
            // 
            this.Clients_Container.Controls.Add(this.panel2);
            this.Clients_Container.Controls.Add(this.panel1);
            this.Clients_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clients_Container.Location = new System.Drawing.Point(0, 0);
            this.Clients_Container.Name = "Clients_Container";
            this.Clients_Container.Size = new System.Drawing.Size(1240, 686);
            this.Clients_Container.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(724, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 494);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entreprise";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(126, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NormalClientButton);
            this.panel1.Location = new System.Drawing.Point(131, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 494);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Normal Client";
            // 
            // NormalClientButton
            // 
            this.NormalClientButton.BackColor = System.Drawing.Color.Silver;
            this.NormalClientButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalClientButton.Location = new System.Drawing.Point(115, 336);
            this.NormalClientButton.Name = "NormalClientButton";
            this.NormalClientButton.Size = new System.Drawing.Size(134, 40);
            this.NormalClientButton.TabIndex = 0;
            this.NormalClientButton.Text = "Edit";
            this.NormalClientButton.UseVisualStyleBackColor = false;
            this.NormalClientButton.Click += new System.EventHandler(this.NormalClientButton_Click);
            // 
            // ClientsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Clients_Container);
            this.Name = "ClientsUC";
            this.Size = new System.Drawing.Size(1240, 686);
            this.Clients_Container.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Clients_Container;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NormalClientButton;
    }
}
