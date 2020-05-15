namespace LibraryManagementSystemWF
{
	partial class BookTransactions
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
			this.dvgBookTransaction = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dvgBookTransaction)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgBookTransaction
			// 
			this.dvgBookTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgBookTransaction.Location = new System.Drawing.Point(12, 31);
			this.dvgBookTransaction.Name = "dvgBookTransaction";
			this.dvgBookTransaction.Size = new System.Drawing.Size(622, 407);
			this.dvgBookTransaction.TabIndex = 0;
			this.dvgBookTransaction.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgBookTransaction_RowHeaderMouseClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(690, 109);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// BookTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dvgBookTransaction);
			this.Name = "BookTransactions";
			this.Text = "BookTransactions";
			((System.ComponentModel.ISupportInitialize)(this.dvgBookTransaction)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dvgBookTransaction;
		private System.Windows.Forms.Button btnClose;
	}
}