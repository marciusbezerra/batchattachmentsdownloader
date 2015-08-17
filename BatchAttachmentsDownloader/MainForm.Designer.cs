namespace WindowsFormsApplication3
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ListAttachmentsButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AttachmentsListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.FoldersComboBox = new System.Windows.Forms.ComboBox();
            this.FromColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.DownloadAttachmentsButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(16, 25);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.Text = "marciusbezerra@outlook.com";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(182, 25);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(160, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "outlook0306";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ListAttachmentsButton
            // 
            this.ListAttachmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListAttachmentsButton.Enabled = false;
            this.ListAttachmentsButton.Location = new System.Drawing.Point(348, 68);
            this.ListAttachmentsButton.Name = "ListAttachmentsButton";
            this.ListAttachmentsButton.Size = new System.Drawing.Size(94, 23);
            this.ListAttachmentsButton.TabIndex = 5;
            this.ListAttachmentsButton.Text = "Listar anexos";
            this.ListAttachmentsButton.UseVisualStyleBackColor = true;
            this.ListAttachmentsButton.Click += new System.EventHandler(this.ListAttachmentsButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.Location = new System.Drawing.Point(348, 25);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(94, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tspbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DownloadAttachmentsButton);
            this.groupBox1.Controls.Add(this.AttachmentsListView);
            this.groupBox1.Location = new System.Drawing.Point(11, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anexos";
            // 
            // AttachmentsListView
            // 
            this.AttachmentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsListView.CheckBoxes = true;
            this.AttachmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FromColumnHeader,
            this.SubjectColumnHeader,
            this.DateColumnHeader,
            this.AttCountColumnHeader});
            this.AttachmentsListView.Location = new System.Drawing.Point(5, 19);
            this.AttachmentsListView.Name = "AttachmentsListView";
            this.AttachmentsListView.Size = new System.Drawing.Size(617, 199);
            this.AttachmentsListView.TabIndex = 5;
            this.AttachmentsListView.UseCompatibleStateImageBehavior = false;
            this.AttachmentsListView.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pastas";
            // 
            // FoldersComboBox
            // 
            this.FoldersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoldersComboBox.Enabled = false;
            this.FoldersComboBox.FormattingEnabled = true;
            this.FoldersComboBox.Location = new System.Drawing.Point(16, 68);
            this.FoldersComboBox.Name = "FoldersComboBox";
            this.FoldersComboBox.Size = new System.Drawing.Size(326, 21);
            this.FoldersComboBox.TabIndex = 10;
            // 
            // FromColumnHeader
            // 
            this.FromColumnHeader.Text = "De";
            this.FromColumnHeader.Width = 219;
            // 
            // SubjectColumnHeader
            // 
            this.SubjectColumnHeader.Text = "Assunto";
            this.SubjectColumnHeader.Width = 211;
            // 
            // DateColumnHeader
            // 
            this.DateColumnHeader.Text = "Data";
            this.DateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateColumnHeader.Width = 98;
            // 
            // AttCountColumnHeader
            // 
            this.AttCountColumnHeader.Text = "Anexos";
            this.AttCountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tsslStatus
            // 
            this.tsslStatus.AutoSize = false;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(434, 17);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "...";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspbProgress
            // 
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(200, 16);
            // 
            // DownloadAttachmentsButton
            // 
            this.DownloadAttachmentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadAttachmentsButton.Enabled = false;
            this.DownloadAttachmentsButton.Location = new System.Drawing.Point(528, 224);
            this.DownloadAttachmentsButton.Name = "DownloadAttachmentsButton";
            this.DownloadAttachmentsButton.Size = new System.Drawing.Size(94, 23);
            this.DownloadAttachmentsButton.TabIndex = 6;
            this.DownloadAttachmentsButton.Text = "Baixar anexos!";
            this.DownloadAttachmentsButton.UseVisualStyleBackColor = true;
            this.DownloadAttachmentsButton.Click += new System.EventHandler(this.DownloadAttachmentsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 376);
            this.Controls.Add(this.FoldersComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ListAttachmentsButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Batch Attachments Downloader";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button ListAttachmentsButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView AttachmentsListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FoldersComboBox;
        private System.Windows.Forms.ColumnHeader FromColumnHeader;
        private System.Windows.Forms.ColumnHeader SubjectColumnHeader;
        private System.Windows.Forms.ColumnHeader DateColumnHeader;
        private System.Windows.Forms.ColumnHeader AttCountColumnHeader;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.Button DownloadAttachmentsButton;
    }
}

