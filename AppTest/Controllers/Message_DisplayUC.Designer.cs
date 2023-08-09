namespace AppTest.Controllers
{
    partial class Message_DisplayUC
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SenderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecieverLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DateLabel.Location = new System.Drawing.Point(449, 13);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(100, 24);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "15/06/2022";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.ContentLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContentLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(5, 6);
            this.ContentLabel.MaximumSize = new System.Drawing.Size(560, 75);
            this.ContentLabel.MinimumSize = new System.Drawing.Size(560, 75);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(560, 75);
            this.ContentLabel.TabIndex = 1;
            this.ContentLabel.Text = "Hey . chaamlt fisa3 ";
            this.ContentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ContentLabel);
            this.panel1.Location = new System.Drawing.Point(15, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 87);
            this.panel1.TabIndex = 2;
            // 
            // SenderLabel
            // 
            this.SenderLabel.AutoSize = true;
            this.SenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SenderLabel.Location = new System.Drawing.Point(78, 9);
            this.SenderLabel.Name = "SenderLabel";
            this.SenderLabel.Size = new System.Drawing.Size(127, 18);
            this.SenderLabel.TabIndex = 3;
            this.SenderLabel.Text = "badis@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "From : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "To : ";
            // 
            // RecieverLabel
            // 
            this.RecieverLabel.AutoSize = true;
            this.RecieverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RecieverLabel.Location = new System.Drawing.Point(100, 33);
            this.RecieverLabel.Name = "RecieverLabel";
            this.RecieverLabel.Size = new System.Drawing.Size(127, 18);
            this.RecieverLabel.TabIndex = 5;
            this.RecieverLabel.Text = "badis@gmail.com";
            // 
            // Message_DisplayUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecieverLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SenderLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateLabel);
            this.Name = "Message_DisplayUC";
            this.Size = new System.Drawing.Size(604, 155);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SenderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RecieverLabel;
    }
}
