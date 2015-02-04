namespace FriendQueue
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lvFriends = new System.Windows.Forms.ListView();
            this.clNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLv.SuspendLayout();
            this.cmsListItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFriends
            // 
            this.lvFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNumber,
            this.chName,
            this.chLastDate});
            this.lvFriends.ContextMenuStrip = this.cmsLv;
            this.lvFriends.FullRowSelect = true;
            this.lvFriends.Location = new System.Drawing.Point(13, 13);
            this.lvFriends.Name = "lvFriends";
            this.lvFriends.Size = new System.Drawing.Size(259, 237);
            this.lvFriends.TabIndex = 0;
            this.lvFriends.UseCompatibleStateImageBehavior = false;
            this.lvFriends.View = System.Windows.Forms.View.Details;
            this.lvFriends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFriends_MouseClick);
            // 
            // clNumber
            // 
            this.clNumber.Text = "#";
            this.clNumber.Width = 30;
            // 
            // chName
            // 
            this.chName.Text = "Nom";
            this.chName.Width = 115;
            // 
            // chLastDate
            // 
            this.chLastDate.Text = "Dernière date";
            this.chLastDate.Width = 106;
            // 
            // cmsLv
            // 
            this.cmsLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd});
            this.cmsLv.Name = "cmsLv";
            this.cmsLv.Size = new System.Drawing.Size(114, 26);
            this.cmsLv.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLv_Opening);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(113, 22);
            this.tsmiAdd.Text = "Ajouter";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // cmsListItem
            // 
            this.cmsListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tmsiDelete});
            this.cmsListItem.Name = "cmsListItem";
            this.cmsListItem.Size = new System.Drawing.Size(130, 48);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(129, 22);
            this.tsmiEdit.Text = "Éditer";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tmsiDelete
            // 
            this.tmsiDelete.Name = "tmsiDelete";
            this.tmsiDelete.Size = new System.Drawing.Size(129, 22);
            this.tmsiDelete.Text = "Supprimer";
            this.tmsiDelete.Click += new System.EventHandler(this.tmsiDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lvFriends);
            this.Name = "Form1";
            this.Text = "FriendQueue";
            this.cmsLv.ResumeLayout(false);
            this.cmsListItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFriends;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLastDate;
        private System.Windows.Forms.ColumnHeader clNumber;
        private System.Windows.Forms.ContextMenuStrip cmsLv;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ContextMenuStrip cmsListItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tmsiDelete;
    }
}

