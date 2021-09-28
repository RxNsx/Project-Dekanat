namespace WFA
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
			this.button_AddUser = new System.Windows.Forms.Button();
			this.GroupBox_1 = new System.Windows.Forms.TextBox();
			this.MarksBox_1 = new System.Windows.Forms.TextBox();
			this.phoneNumberBox_1 = new System.Windows.Forms.TextBox();
			this.lastnameBox_1 = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.nameBox_1 = new System.Windows.Forms.TextBox();
			this.button_DeleteUser = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button_AddUser
			// 
			this.button_AddUser.Location = new System.Drawing.Point(0, 0);
			this.button_AddUser.Name = "button_AddUser";
			this.button_AddUser.Size = new System.Drawing.Size(75, 23);
			this.button_AddUser.TabIndex = 153;
			// 
			// GroupBox_1
			// 
			this.GroupBox_1.Location = new System.Drawing.Point(928, 210);
			this.GroupBox_1.Name = "GroupBox_1";
			this.GroupBox_1.Size = new System.Drawing.Size(254, 20);
			this.GroupBox_1.TabIndex = 4;
			// 
			// MarksBox_1
			// 
			this.MarksBox_1.Location = new System.Drawing.Point(928, 256);
			this.MarksBox_1.Name = "MarksBox_1";
			this.MarksBox_1.Size = new System.Drawing.Size(254, 20);
			this.MarksBox_1.TabIndex = 5;
			// 
			// phoneNumberBox_1
			// 
			this.phoneNumberBox_1.Location = new System.Drawing.Point(928, 165);
			this.phoneNumberBox_1.Name = "phoneNumberBox_1";
			this.phoneNumberBox_1.Size = new System.Drawing.Size(254, 20);
			this.phoneNumberBox_1.TabIndex = 3;
			// 
			// lastnameBox_1
			// 
			this.lastnameBox_1.Location = new System.Drawing.Point(928, 123);
			this.lastnameBox_1.Name = "lastnameBox_1";
			this.lastnameBox_1.Size = new System.Drawing.Size(254, 20);
			this.lastnameBox_1.TabIndex = 2;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(928, 359);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(253, 29);
			this.progressBar1.TabIndex = 150;
			// 
			// nameBox_1
			// 
			this.nameBox_1.Location = new System.Drawing.Point(928, 75);
			this.nameBox_1.Name = "nameBox_1";
			this.nameBox_1.Size = new System.Drawing.Size(252, 20);
			this.nameBox_1.TabIndex = 1;
			// 
			// button_DeleteUser
			// 
			this.button_DeleteUser.Location = new System.Drawing.Point(0, 0);
			this.button_DeleteUser.Name = "button_DeleteUser";
			this.button_DeleteUser.Size = new System.Drawing.Size(75, 23);
			this.button_DeleteUser.TabIndex = 152;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(795, 594);
			this.dataGridView1.TabIndex = 151;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1271, 618);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button_DeleteUser);
			this.Controls.Add(this.nameBox_1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lastnameBox_1);
			this.Controls.Add(this.phoneNumberBox_1);
			this.Controls.Add(this.MarksBox_1);
			this.Controls.Add(this.GroupBox_1);
			this.Controls.Add(this.button_AddUser);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_AddUser;
		private System.Windows.Forms.TextBox GroupBox_1;
		private System.Windows.Forms.TextBox MarksBox_1;
		private System.Windows.Forms.TextBox phoneNumberBox_1;
		private System.Windows.Forms.TextBox lastnameBox_1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox nameBox_1;
		private System.Windows.Forms.Button button_DeleteUser;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

