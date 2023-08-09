namespace AppTest.Controllers
{
    partial class MailUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessageContainer = new System.Windows.Forms.Panel();
            this.MessagesTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.RecipientBox = new System.Windows.Forms.ComboBox();
            this.MessageBody = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MailsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MessageContainer);
            this.panel1.Controls.Add(this.MessagesTable);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 606);
            this.panel1.TabIndex = 0;
            // 
            // MessageContainer
            // 
            this.MessageContainer.BackColor = System.Drawing.Color.Ivory;
            this.MessageContainer.Location = new System.Drawing.Point(54, 178);
            this.MessageContainer.Name = "MessageContainer";
            this.MessageContainer.Size = new System.Drawing.Size(617, 165);
            this.MessageContainer.TabIndex = 15;
            // 
            // MessagesTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MessagesTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessagesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MessagesTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MessagesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessagesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MessagesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.MessagesTable.GridColor = System.Drawing.SystemColors.Highlight;
            this.MessagesTable.Location = new System.Drawing.Point(54, 349);
            this.MessagesTable.Name = "MessagesTable";
            this.MessagesTable.Size = new System.Drawing.Size(617, 179);
            this.MessagesTable.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.SendMessageButton);
            this.panel3.Controls.Add(this.RecipientBox);
            this.panel3.Controls.Add(this.MessageBody);
            this.panel3.Location = new System.Drawing.Point(704, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 350);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contact Emails";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessageButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SendMessageButton.Location = new System.Drawing.Point(104, 262);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(105, 32);
            this.SendMessageButton.TabIndex = 6;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // RecipientBox
            // 
            this.RecipientBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RecipientBox.FormattingEnabled = true;
            this.RecipientBox.Items.AddRange(new object[] {
            "badisinq@gmail.com",
            "eya.jemai@gmail.com"});
            this.RecipientBox.Location = new System.Drawing.Point(16, 59);
            this.RecipientBox.Name = "RecipientBox";
            this.RecipientBox.Size = new System.Drawing.Size(300, 21);
            this.RecipientBox.TabIndex = 3;
            this.RecipientBox.Text = "Recipient ...";
            // 
            // MessageBody
            // 
            this.MessageBody.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MessageBody.Location = new System.Drawing.Point(16, 124);
            this.MessageBody.Name = "MessageBody";
            this.MessageBody.Size = new System.Drawing.Size(300, 92);
            this.MessageBody.TabIndex = 5;
            this.MessageBody.Text = "Message Subject .....";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MailsCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StaffPic);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.SearchBar);
            this.panel2.Location = new System.Drawing.Point(40, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 62);
            this.panel2.TabIndex = 2;
            // 
            // MailsCount
            // 
            this.MailsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MailsCount.AutoSize = true;
            this.MailsCount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.MailsCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.MailsCount.Location = new System.Drawing.Point(763, 18);
            this.MailsCount.Name = "MailsCount";
            this.MailsCount.Size = new System.Drawing.Size(52, 23);
            this.MailsCount.TabIndex = 3;
            this.MailsCount.Text = "( 48 )";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mails : ";
            // 
            // StaffPic
            // 
            this.StaffPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StaffPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPic.Location = new System.Drawing.Point(832, 7);
            this.StaffPic.Name = "StaffPic";
            this.StaffPic.Size = new System.Drawing.Size(51, 47);
            this.StaffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StaffPic.TabIndex = 4;
            this.StaffPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.Font = new System.Drawing.Font("OCR A Extended", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Newest",
            "Oldest"});
            this.comboBox1.Location = new System.Drawing.Point(422, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Filter";
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SearchBar.Location = new System.Drawing.Point(26, 19);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(288, 20);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.Text = "Search...";
            // 
            // MailUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel1);
            this.Name = "MailUC";
            this.Size = new System.Drawing.Size(1102, 686);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox StaffPic;
        private System.Windows.Forms.Label MailsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RecipientBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.RichTextBox MessageBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MessagesTable;
        private System.Windows.Forms.Panel MessageContainer;
    }
}
