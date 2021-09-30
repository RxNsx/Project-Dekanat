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
			this.GroupBox_1 = new System.Windows.Forms.TextBox();
			this.MarksBox_1 = new System.Windows.Forms.TextBox();
			this.phoneNumberBox_1 = new System.Windows.Forms.TextBox();
			this.lastnameBox_1 = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.nameBox_1 = new System.Windows.Forms.TextBox();
			this.button_DeleteUser = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.but_AddUser = new System.Windows.Forms.Button();
			this.button_WriteDataInFile = new System.Windows.Forms.Button();
			this.button_ReadDB = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
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
			this.progressBar1.Location = new System.Drawing.Point(928, 404);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(254, 29);
			this.progressBar1.TabIndex = 150;
			// 
			// nameBox_1
			// 
			this.nameBox_1.Location = new System.Drawing.Point(930, 29);
			this.nameBox_1.Name = "nameBox_1";
			this.nameBox_1.Size = new System.Drawing.Size(252, 20);
			this.nameBox_1.TabIndex = 1;
			// 
			// button_DeleteUser
			// 
			this.button_DeleteUser.Location = new System.Drawing.Point(928, 355);
			this.button_DeleteUser.Name = "button_DeleteUser";
			this.button_DeleteUser.Size = new System.Drawing.Size(254, 43);
			this.button_DeleteUser.TabIndex = 152;
			this.button_DeleteUser.Text = "Удалить пользователя";
			this.button_DeleteUser.Click += new System.EventHandler(this.button_DeleteUser_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 29);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(795, 531);
			this.dataGridView1.TabIndex = 151;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// but_AddUser
			// 
			this.but_AddUser.Location = new System.Drawing.Point(928, 299);
			this.but_AddUser.Name = "but_AddUser";
			this.but_AddUser.Size = new System.Drawing.Size(254, 50);
			this.but_AddUser.TabIndex = 154;
			this.but_AddUser.Text = "Добавить пользователя";
			this.but_AddUser.UseVisualStyleBackColor = true;
			this.but_AddUser.Click += new System.EventHandler(this.but_AddUser_Click);
			// 
			// button_WriteDataInFile
			// 
			this.button_WriteDataInFile.Location = new System.Drawing.Point(928, 451);
			this.button_WriteDataInFile.Name = "button_WriteDataInFile";
			this.button_WriteDataInFile.Size = new System.Drawing.Size(253, 54);
			this.button_WriteDataInFile.TabIndex = 155;
			this.button_WriteDataInFile.Text = "Записать БД";
			this.button_WriteDataInFile.UseVisualStyleBackColor = true;
			this.button_WriteDataInFile.Click += new System.EventHandler(this.button_WriteDataInFile_Click);
			// 
			// button_ReadDB
			// 
			this.button_ReadDB.Location = new System.Drawing.Point(929, 520);
			this.button_ReadDB.Name = "button_ReadDB";
			this.button_ReadDB.Size = new System.Drawing.Size(250, 55);
			this.button_ReadDB.TabIndex = 156;
			this.button_ReadDB.Text = "Прочитать БД";
			this.button_ReadDB.UseVisualStyleBackColor = true;
			this.button_ReadDB.Click += new System.EventHandler(this.button_ReadDB_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1736, 618);
			this.Controls.Add(this.button_ReadDB);
			this.Controls.Add(this.button_WriteDataInFile);
			this.Controls.Add(this.but_AddUser);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button_DeleteUser);
			this.Controls.Add(this.nameBox_1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lastnameBox_1);
			this.Controls.Add(this.phoneNumberBox_1);
			this.Controls.Add(this.MarksBox_1);
			this.Controls.Add(this.GroupBox_1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox GroupBox_1;
		private System.Windows.Forms.TextBox MarksBox_1;
		private System.Windows.Forms.TextBox phoneNumberBox_1;
		private System.Windows.Forms.TextBox lastnameBox_1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox nameBox_1;
		private System.Windows.Forms.Button button_DeleteUser;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button but_AddUser;
		private System.Windows.Forms.Button button_WriteDataInFile;
		private System.Windows.Forms.Button button_ReadDB;
	}
}

