namespace ServiceManager
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
			this.btnRefresh = new System.Windows.Forms.Button();
			this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(340, 472);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 0;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// checkedListBoxServices
			// 
			this.checkedListBoxServices.FormattingEnabled = true;
			this.checkedListBoxServices.Location = new System.Drawing.Point(12, 25);
			this.checkedListBoxServices.Name = "checkedListBoxServices";
			this.checkedListBoxServices.Size = new System.Drawing.Size(730, 429);
			this.checkedListBoxServices.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 517);
			this.Controls.Add(this.checkedListBoxServices);
			this.Controls.Add(this.btnRefresh);
			this.Name = "Form1";
			this.Text = "ServiceManager";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.CheckedListBox checkedListBoxServices;
	}
}

