namespace FPageManager.Views
{
    partial class PageManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnpublishedPost = new System.Windows.Forms.Button();
            this.btnPublishedPost = new System.Windows.Forms.Button();
            this.btnCreatePost = new System.Windows.Forms.Button();
            this.dgPosts = new System.Windows.Forms.DataGridView();
            this.lblheader = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPeopleViewedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnUnpublishedPost);
            this.panel1.Controls.Add(this.btnPublishedPost);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnUnpublishedPost
            // 
            this.btnUnpublishedPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUnpublishedPost.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpublishedPost.ForeColor = System.Drawing.Color.White;
            this.btnUnpublishedPost.Location = new System.Drawing.Point(3, 65);
            this.btnUnpublishedPost.Name = "btnUnpublishedPost";
            this.btnUnpublishedPost.Size = new System.Drawing.Size(160, 40);
            this.btnUnpublishedPost.TabIndex = 1;
            this.btnUnpublishedPost.Text = "UnPublished Posts";
            this.btnUnpublishedPost.UseVisualStyleBackColor = false;
            this.btnUnpublishedPost.Click += new System.EventHandler(this.btnUnpublishedPost_Click);
            // 
            // btnPublishedPost
            // 
            this.btnPublishedPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPublishedPost.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishedPost.ForeColor = System.Drawing.Color.White;
            this.btnPublishedPost.Location = new System.Drawing.Point(3, 12);
            this.btnPublishedPost.Name = "btnPublishedPost";
            this.btnPublishedPost.Size = new System.Drawing.Size(160, 47);
            this.btnPublishedPost.TabIndex = 0;
            this.btnPublishedPost.Text = "Published Posts";
            this.btnPublishedPost.UseVisualStyleBackColor = false;
            this.btnPublishedPost.Click += new System.EventHandler(this.btnPublishedPost_Click);
            // 
            // btnCreatePost
            // 
            this.btnCreatePost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreatePost.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePost.ForeColor = System.Drawing.Color.White;
            this.btnCreatePost.Location = new System.Drawing.Point(872, 12);
            this.btnCreatePost.Name = "btnCreatePost";
            this.btnCreatePost.Size = new System.Drawing.Size(136, 35);
            this.btnCreatePost.TabIndex = 1;
            this.btnCreatePost.Text = "+ Create Post";
            this.btnCreatePost.UseVisualStyleBackColor = false;
            this.btnCreatePost.Click += new System.EventHandler(this.btnCreatePost_Click);
            // 
            // dgPosts
            // 
            this.dgPosts.AutoGenerateColumns = false;
            this.dgPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPosts.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.numberOfPeopleViewedDataGridViewTextBoxColumn,
            this.createdTimeDataGridViewTextBoxColumn,
            this.Caption,
            this.Description});
            this.dgPosts.DataSource = this.postBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPosts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPosts.Location = new System.Drawing.Point(192, 53);
            this.dgPosts.Name = "dgPosts";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPosts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPosts.Size = new System.Drawing.Size(816, 534);
            this.dgPosts.TabIndex = 2;
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.Blue;
            this.lblheader.Location = new System.Drawing.Point(189, 29);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(50, 18);
            this.lblheader.TabIndex = 3;
            this.lblheader.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(872, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(136, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "next >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnprevious.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.White;
            this.btnprevious.Location = new System.Drawing.Point(705, 593);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(136, 35);
            this.btnprevious.TabIndex = 5;
            this.btnprevious.Text = "< Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Posts";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // numberOfPeopleViewedDataGridViewTextBoxColumn
            // 
            this.numberOfPeopleViewedDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPeopleViewed";
            this.numberOfPeopleViewedDataGridViewTextBoxColumn.HeaderText = "Viewed";
            this.numberOfPeopleViewedDataGridViewTextBoxColumn.Name = "numberOfPeopleViewedDataGridViewTextBoxColumn";
            // 
            // createdTimeDataGridViewTextBoxColumn
            // 
            this.createdTimeDataGridViewTextBoxColumn.DataPropertyName = "Created_Time";
            this.createdTimeDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.createdTimeDataGridViewTextBoxColumn.Name = "createdTimeDataGridViewTextBoxColumn";
            // 
            // Caption
            // 
            this.Caption.DataPropertyName = "Caption";
            this.Caption.HeaderText = "Caption";
            this.Caption.Name = "Caption";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FPageManager.Objects.Post);
            // 
            // PageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1024, 636);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.dgPosts);
            this.Controls.Add(this.btnCreatePost);
            this.Controls.Add(this.panel1);
            this.Name = "PageManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Page Manager";
            this.Load += new System.EventHandler(this.PageManager_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnpublishedPost;
        private System.Windows.Forms.Button btnPublishedPost;
        private System.Windows.Forms.Button btnCreatePost;
        private System.Windows.Forms.DataGridView dgPosts;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPeopleViewedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnprevious;

    }
}

