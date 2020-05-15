namespace LibraryManagementSystemWF
{
	partial class UserBooks
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
			this.dvgUserBooks = new System.Windows.Forms.DataGridView();
			this.btnReturnBook = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dvgUserBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgUserBooks
			// 
			this.dvgUserBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgUserBooks.Location = new System.Drawing.Point(12, 29);
			this.dvgUserBooks.Name = "dvgUserBooks";
			this.dvgUserBooks.Size = new System.Drawing.Size(562, 334);
			this.dvgUserBooks.TabIndex = 0;
			this.dvgUserBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgUserBooks_RowHeaderMouseClick);
			// 
			// btnReturnBook
			// 
			this.btnReturnBook.Location = new System.Drawing.Point(675, 72);
			this.btnReturnBook.Name = "btnReturnBook";
			this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
			this.btnReturnBook.TabIndex = 1;
			this.btnReturnBook.Text = "Return Book";
			this.btnReturnBook.UseVisualStyleBackColor = true;
			this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(675, 134);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// UserBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnReturnBook);
			this.Controls.Add(this.dvgUserBooks);
			this.Name = "UserBooks";
			this.Text = "UserBooks";
			((System.ComponentModel.ISupportInitialize)(this.dvgUserBooks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dvgUserBooks;
		private System.Windows.Forms.Button btnReturnBook;
		private System.Windows.Forms.Button btnClose;
	}
}