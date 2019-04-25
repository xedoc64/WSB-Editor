namespace WSB_Editor
{
    partial class frmMain
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
            this.btnLoadWSB = new System.Windows.Forms.Button();
            this.btnSaveWSB = new System.Windows.Forms.Button();
            this.chkGPUSharing = new System.Windows.Forms.CheckBox();
            this.chkNetwork = new System.Windows.Forms.CheckBox();
            this.lstFolders = new System.Windows.Forms.ListView();
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmReadOnly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSharedFolder = new System.Windows.Forms.Button();
            this.btnRemoveSharedFolder = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.lblLogonCommand = new System.Windows.Forms.Label();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.stslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstCommand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.grpSharedFolders = new System.Windows.Forms.GroupBox();
            this.grpLogonCommand = new System.Windows.Forms.GroupBox();
            this.stsStatus.SuspendLayout();
            this.grpSharedFolders.SuspendLayout();
            this.grpLogonCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadWSB
            // 
            this.btnLoadWSB.Location = new System.Drawing.Point(12, 12);
            this.btnLoadWSB.Name = "btnLoadWSB";
            this.btnLoadWSB.Size = new System.Drawing.Size(75, 23);
            this.btnLoadWSB.TabIndex = 0;
            this.btnLoadWSB.Text = "&Load WSB";
            this.btnLoadWSB.UseVisualStyleBackColor = true;
            this.btnLoadWSB.Click += new System.EventHandler(this.btnLoadWSB_Click);
            // 
            // btnSaveWSB
            // 
            this.btnSaveWSB.Location = new System.Drawing.Point(126, 12);
            this.btnSaveWSB.Name = "btnSaveWSB";
            this.btnSaveWSB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWSB.TabIndex = 1;
            this.btnSaveWSB.Text = "&Save WSB";
            this.btnSaveWSB.UseVisualStyleBackColor = true;
            this.btnSaveWSB.Click += new System.EventHandler(this.btnSaveWSB_Click);
            // 
            // chkGPUSharing
            // 
            this.chkGPUSharing.AutoSize = true;
            this.chkGPUSharing.Location = new System.Drawing.Point(12, 51);
            this.chkGPUSharing.Name = "chkGPUSharing";
            this.chkGPUSharing.Size = new System.Drawing.Size(122, 17);
            this.chkGPUSharing.TabIndex = 2;
            this.chkGPUSharing.Text = "Enable GPU sharing";
            this.chkGPUSharing.UseVisualStyleBackColor = true;
            // 
            // chkNetwork
            // 
            this.chkNetwork.AutoSize = true;
            this.chkNetwork.Location = new System.Drawing.Point(12, 74);
            this.chkNetwork.Name = "chkNetwork";
            this.chkNetwork.Size = new System.Drawing.Size(100, 17);
            this.chkNetwork.TabIndex = 3;
            this.chkNetwork.Text = "Enable network";
            this.chkNetwork.UseVisualStyleBackColor = true;
            // 
            // lstFolders
            // 
            this.lstFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPath,
            this.clmReadOnly});
            this.lstFolders.FullRowSelect = true;
            this.lstFolders.GridLines = true;
            this.lstFolders.HideSelection = false;
            this.lstFolders.Location = new System.Drawing.Point(6, 23);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Scrollable = false;
            this.lstFolders.Size = new System.Drawing.Size(414, 118);
            this.lstFolders.TabIndex = 5;
            this.lstFolders.UseCompatibleStateImageBehavior = false;
            this.lstFolders.View = System.Windows.Forms.View.Details;
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path";
            this.clmPath.Width = 351;
            // 
            // clmReadOnly
            // 
            this.clmReadOnly.Text = "ReadOnly";
            // 
            // btnAddSharedFolder
            // 
            this.btnAddSharedFolder.Location = new System.Drawing.Point(426, 23);
            this.btnAddSharedFolder.Name = "btnAddSharedFolder";
            this.btnAddSharedFolder.Size = new System.Drawing.Size(27, 29);
            this.btnAddSharedFolder.TabIndex = 6;
            this.btnAddSharedFolder.Text = "+";
            this.btnAddSharedFolder.UseVisualStyleBackColor = true;
            this.btnAddSharedFolder.Click += new System.EventHandler(this.btnAddSharedFolder_Click);
            // 
            // btnRemoveSharedFolder
            // 
            this.btnRemoveSharedFolder.Location = new System.Drawing.Point(426, 58);
            this.btnRemoveSharedFolder.Name = "btnRemoveSharedFolder";
            this.btnRemoveSharedFolder.Size = new System.Drawing.Size(27, 29);
            this.btnRemoveSharedFolder.TabIndex = 7;
            this.btnRemoveSharedFolder.Text = "-";
            this.btnRemoveSharedFolder.UseVisualStyleBackColor = true;
            this.btnRemoveSharedFolder.Click += new System.EventHandler(this.btnRemoveSharedFolder_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(94, 149);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(326, 20);
            this.txtCommand.TabIndex = 9;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // lblLogonCommand
            // 
            this.lblLogonCommand.AutoSize = true;
            this.lblLogonCommand.Location = new System.Drawing.Point(5, 152);
            this.lblLogonCommand.Name = "lblLogonCommand";
            this.lblLogonCommand.Size = new System.Drawing.Size(89, 13);
            this.lblLogonCommand.TabIndex = 11;
            this.lblLogonCommand.Text = "Logon command:";
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslblStatus});
            this.stsStatus.Location = new System.Drawing.Point(0, 550);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(541, 22);
            this.stsStatus.TabIndex = 11;
            // 
            // stslblStatus
            // 
            this.stslblStatus.Name = "stslblStatus";
            this.stslblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lstCommand
            // 
            this.lstCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstCommand.FullRowSelect = true;
            this.lstCommand.GridLines = true;
            this.lstCommand.HideSelection = false;
            this.lstCommand.Location = new System.Drawing.Point(6, 25);
            this.lstCommand.Name = "lstCommand";
            this.lstCommand.Scrollable = false;
            this.lstCommand.Size = new System.Drawing.Size(414, 118);
            this.lstCommand.TabIndex = 12;
            this.lstCommand.UseCompatibleStateImageBehavior = false;
            this.lstCommand.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 409;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Location = new System.Drawing.Point(6, 184);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(90, 23);
            this.btnAddCommand.TabIndex = 13;
            this.btnAddCommand.Text = "Add command";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Location = new System.Drawing.Point(108, 184);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveCommand.TabIndex = 14;
            this.btnRemoveCommand.Text = "Remove Command";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            this.btnRemoveCommand.Click += new System.EventHandler(this.btnRemoveCommand_Click);
            // 
            // grpSharedFolders
            // 
            this.grpSharedFolders.Controls.Add(this.lstFolders);
            this.grpSharedFolders.Controls.Add(this.btnRemoveSharedFolder);
            this.grpSharedFolders.Controls.Add(this.btnAddSharedFolder);
            this.grpSharedFolders.Location = new System.Drawing.Point(12, 97);
            this.grpSharedFolders.Name = "grpSharedFolders";
            this.grpSharedFolders.Size = new System.Drawing.Size(500, 184);
            this.grpSharedFolders.TabIndex = 15;
            this.grpSharedFolders.TabStop = false;
            this.grpSharedFolders.Text = "Shared folders";
            // 
            // grpLogonCommand
            // 
            this.grpLogonCommand.Controls.Add(this.lblLogonCommand);
            this.grpLogonCommand.Controls.Add(this.lstCommand);
            this.grpLogonCommand.Controls.Add(this.btnRemoveCommand);
            this.grpLogonCommand.Controls.Add(this.txtCommand);
            this.grpLogonCommand.Controls.Add(this.btnAddCommand);
            this.grpLogonCommand.Location = new System.Drawing.Point(18, 303);
            this.grpLogonCommand.Name = "grpLogonCommand";
            this.grpLogonCommand.Size = new System.Drawing.Size(494, 244);
            this.grpLogonCommand.TabIndex = 16;
            this.grpLogonCommand.TabStop = false;
            this.grpLogonCommand.Text = "Logon Commands";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 572);
            this.Controls.Add(this.grpLogonCommand);
            this.Controls.Add(this.grpSharedFolders);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.btnSaveWSB);
            this.Controls.Add(this.btnLoadWSB);
            this.Controls.Add(this.chkGPUSharing);
            this.Controls.Add(this.chkNetwork);
            this.Name = "frmMain";
            this.Text = "WSB-Editor";
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.grpSharedFolders.ResumeLayout(false);
            this.grpLogonCommand.ResumeLayout(false);
            this.grpLogonCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWSB;
        private System.Windows.Forms.Button btnSaveWSB;
        private System.Windows.Forms.CheckBox chkGPUSharing;
        private System.Windows.Forms.CheckBox chkNetwork;
        private System.Windows.Forms.ListView lstFolders;
        private System.Windows.Forms.Button btnAddSharedFolder;
        private System.Windows.Forms.Button btnRemoveSharedFolder;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel stslblStatus;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmReadOnly;
        private System.Windows.Forms.Label lblLogonCommand;
        private System.Windows.Forms.ListView lstCommand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRemoveCommand;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.GroupBox grpSharedFolders;
        private System.Windows.Forms.GroupBox grpLogonCommand;
    }
}

