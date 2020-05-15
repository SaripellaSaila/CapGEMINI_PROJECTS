namespace LibraryManagementSystemWF
{
	partial class AcceptBook
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
			this.dvgAcceptBooks = new System.Windows.Forms.DataGridView();
			this.btnAcceptBook = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnRejectBook = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.dvgAcceptBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgAcceptBooks
			// 
			this.dvgAcceptBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgAcceptBooks.Location = new System.Drawing.Point(12, 12);
			this.dvgAcceptBooks.Name = "dvgAcceptBooks";
			this.dvgAcceptBooks.Size = new System.Drawing.Size(593, 348);
			this.dvgAcceptBooks.TabIndex = 0;
			this.dvgAcceptBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgAcceptBook_RowHeaderMouseClick_1);
			// 
			// btnAcceptBook
			// 
			this.btnAcceptBook.Location = new System.Drawing.Point(680, 37);
			this.btnAcceptBook.Name = "btnAcceptBook";
			this.btnAcceptBook.Size = new System.Drawing.Size(97, 23);
			this.btnAcceptBook.TabIndex = 1;
			this.btnAcceptBook.Text = "Issue Book";
			this.btnAcceptBook.UseVisualStyleBackColor = true;
			this.btnAcceptBook.Click += new System.EventHandler(this.btnAcceptBook_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(680, 253);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnRejectBook
			// 
			this.btnRejectBook.Location = new System.Drawing.Point(680, 119);
			this.btnRejectBook.Name = "btnRejectBook";
			this.btnRejectBook.Size = new System.Drawing.Size(75, 23);
			this.btnRejectBook.TabIndex = 3;
			this.btnRejectBook.Text = "Reject Book";
			this.btnRejectBook.UseVisualStyleBackColor = true;
			this.btnRejectBook.Click += new System.EventHandler(this.btnRejectBook_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(680, 190);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 190);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(593, 23);
			this.progressBar1.TabIndex = 5;
			// 
			// AcceptBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnRejectBook);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAcceptBook);
			this.Controls.Add(this.dvgAcceptBooks);
			this.Name = "AcceptBook";
			this.Text = "BookTransactions";
			((System.ComponentModel.ISupportInitialize)(this.dvgAcceptBooks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dvgAcceptBooks;
		private System.Windows.Forms.Button btnAcceptBook;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnRejectBook;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}