namespace LibraryManagementSystemWF
{
	partial class AdminHomeScreen
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnNotifications = new System.Windows.Forms.Button();
			this.btnBookTransaction = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(38, 230);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(575, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// btnAddBook
			// 
			this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddBook.Location = new System.Drawing.Point(662, 23);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(114, 29);
			this.btnAddBook.TabIndex = 2;
			this.btnAddBook.Text = "Add Book";
			this.btnAddBook.UseVisualStyleBackColor = true;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(662, 81);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(114, 29);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update Book";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(662, 139);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(114, 29);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete Book";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(662, 198);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(114, 29);
			this.btnRefresh.TabIndex = 5;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(662, 394);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(114, 29);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "LogOut";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(553, 333);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Location = new System.Drawing.Point(662, 253);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(114, 29);
			this.btnAddUser.TabIndex = 8;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(196, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(228, 40);
			this.button2.TabIndex = 10;
			this.button2.Text = "Admin\'s Home Page ";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnNotifications
			// 
			this.btnNotifications.Location = new System.Drawing.Point(662, 306);
			this.btnNotifications.Name = "btnNotifications";
			this.btnNotifications.Size = new System.Drawing.Size(75, 23);
			this.btnNotifications.TabIndex = 11;
			this.btnNotifications.Text = "Notifications";
			this.btnNotifications.UseVisualStyleBackColor = true;
			this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
			// 
			// btnBookTransaction
			// 
			this.btnBookTransaction.Location = new System.Drawing.Point(662, 354);
			this.btnBookTransaction.Name = "btnBookTransaction";
			this.btnBookTransaction.Size = new System.Drawing.Size(114, 23);
			this.btnBookTransaction.TabIndex = 12;
			this.btnBookTransaction.Text = "Book Transaction";
			this.btnBookTransaction.UseVisualStyleBackColor = true;
			this.btnBookTransaction.Click += new System.EventHandler(this.button3_Click);
			// 
			// AdminHomeScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBookTransaction);
			this.Controls.Add(this.btnNotifications);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAddBook);
			this.Controls.Add(this.progressBar1);
			this.Name = "AdminHomeScreen";
			this.Text = "HomeScreen";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnAddBook;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnBookTransaction;
    }
}