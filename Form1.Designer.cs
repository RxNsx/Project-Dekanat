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
			System.Windows.Forms.TextBox textBox1;
			System.Windows.Forms.TextBox textBox3;
			System.Windows.Forms.TextBox textBox4;
			System.Windows.Forms.TextBox textBox5;
			System.Windows.Forms.TextBox textBox6;
			System.Windows.Forms.TextBox textBox7;
			System.Windows.Forms.TextBox textBox8;
			System.Windows.Forms.TextBox textBox2;
			this.groupBox = new System.Windows.Forms.TextBox();
			this.phoneNumberBox = new System.Windows.Forms.TextBox();
			this.lastNameBox = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.button_DeleteUser = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.but_AddUser = new System.Windows.Forms.Button();
			this.button_WriteDataInFile = new System.Windows.Forms.Button();
			this.button_ReadDB = new System.Windows.Forms.Button();
			this.middleNameBox = new System.Windows.Forms.TextBox();
			this.birthdayBox = new System.Windows.Forms.TextBox();
			this.educationFormBox = new System.Windows.Forms.TextBox();
			this.courseBox = new System.Windows.Forms.TextBox();
			this.button_AddUserObjectsMarks = new System.Windows.Forms.Button();
			textBox1 = new System.Windows.Forms.TextBox();
			textBox3 = new System.Windows.Forms.TextBox();
			textBox4 = new System.Windows.Forms.TextBox();
			textBox5 = new System.Windows.Forms.TextBox();
			textBox6 = new System.Windows.Forms.TextBox();
			textBox7 = new System.Windows.Forms.TextBox();
			textBox8 = new System.Windows.Forms.TextBox();
			textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = System.Drawing.Color.Wheat;
			textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox1.Location = new System.Drawing.Point(1063, 104);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new System.Drawing.Size(253, 13);
			textBox1.TabIndex = 157;
			textBox1.Text = "Имя";
			textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox3
			// 
			textBox3.BackColor = System.Drawing.Color.Wheat;
			textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox3.Location = new System.Drawing.Point(1063, 154);
			textBox3.Name = "textBox3";
			textBox3.ReadOnly = true;
			textBox3.Size = new System.Drawing.Size(253, 13);
			textBox3.TabIndex = 157;
			textBox3.Text = "Отчество";
			textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox4
			// 
			textBox4.BackColor = System.Drawing.Color.Wheat;
			textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox4.Location = new System.Drawing.Point(1063, 204);
			textBox4.Name = "textBox4";
			textBox4.ReadOnly = true;
			textBox4.Size = new System.Drawing.Size(253, 13);
			textBox4.TabIndex = 157;
			textBox4.Text = "Дата рождения";
			textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox5
			// 
			textBox5.BackColor = System.Drawing.Color.Wheat;
			textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox5.Location = new System.Drawing.Point(1063, 254);
			textBox5.Name = "textBox5";
			textBox5.ReadOnly = true;
			textBox5.Size = new System.Drawing.Size(253, 13);
			textBox5.TabIndex = 157;
			textBox5.Text = "Форма обучения";
			textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox6
			// 
			textBox6.BackColor = System.Drawing.Color.Wheat;
			textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox6.Location = new System.Drawing.Point(1063, 304);
			textBox6.Name = "textBox6";
			textBox6.ReadOnly = true;
			textBox6.Size = new System.Drawing.Size(253, 13);
			textBox6.TabIndex = 157;
			textBox6.Text = "Курс";
			textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox7
			// 
			textBox7.BackColor = System.Drawing.Color.Wheat;
			textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox7.Location = new System.Drawing.Point(1063, 354);
			textBox7.Name = "textBox7";
			textBox7.ReadOnly = true;
			textBox7.Size = new System.Drawing.Size(253, 13);
			textBox7.TabIndex = 157;
			textBox7.Text = "Группа";
			textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox8
			// 
			textBox8.BackColor = System.Drawing.Color.Wheat;
			textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox8.Location = new System.Drawing.Point(1063, 404);
			textBox8.Name = "textBox8";
			textBox8.ReadOnly = true;
			textBox8.Size = new System.Drawing.Size(253, 13);
			textBox8.TabIndex = 157;
			textBox8.Text = "Номер телефона";
			textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			textBox2.BackColor = System.Drawing.Color.Wheat;
			textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			textBox2.Location = new System.Drawing.Point(1063, 54);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new System.Drawing.Size(253, 13);
			textBox2.TabIndex = 157;
			textBox2.Text = "Фамилия";
			textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox
			// 
			this.groupBox.Location = new System.Drawing.Point(1067, 373);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(249, 20);
			this.groupBox.TabIndex = 7;
			// 
			// phoneNumberBox
			// 
			this.phoneNumberBox.Location = new System.Drawing.Point(1067, 423);
			this.phoneNumberBox.Name = "phoneNumberBox";
			this.phoneNumberBox.Size = new System.Drawing.Size(250, 20);
			this.phoneNumberBox.TabIndex = 8;
			// 
			// lastNameBox
			// 
			this.lastNameBox.Location = new System.Drawing.Point(1067, 73);
			this.lastNameBox.Name = "lastNameBox";
			this.lastNameBox.Size = new System.Drawing.Size(250, 20);
			this.lastNameBox.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 609);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(841, 29);
			this.progressBar1.TabIndex = 150;
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(1067, 123);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(250, 20);
			this.nameBox.TabIndex = 2;
			// 
			// button_DeleteUser
			// 
			this.button_DeleteUser.BackColor = System.Drawing.Color.Transparent;
			this.button_DeleteUser.Location = new System.Drawing.Point(1217, 449);
			this.button_DeleteUser.Name = "button_DeleteUser";
			this.button_DeleteUser.Size = new System.Drawing.Size(100, 50);
			this.button_DeleteUser.TabIndex = 152;
			this.button_DeleteUser.Text = "Удалить пользователя";
			this.button_DeleteUser.UseVisualStyleBackColor = false;
			this.button_DeleteUser.Click += new System.EventHandler(this.button_DeleteUser_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 72);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(841, 531);
			this.dataGridView1.TabIndex = 151;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// but_AddUser
			// 
			this.but_AddUser.Location = new System.Drawing.Point(1067, 449);
			this.but_AddUser.Name = "but_AddUser";
			this.but_AddUser.Size = new System.Drawing.Size(100, 50);
			this.but_AddUser.TabIndex = 154;
			this.but_AddUser.Text = "Добавить пользователя";
			this.but_AddUser.UseVisualStyleBackColor = true;
			this.but_AddUser.Click += new System.EventHandler(this.but_AddUser_Click);
			// 
			// button_WriteDataInFile
			// 
			this.button_WriteDataInFile.Location = new System.Drawing.Point(12, 12);
			this.button_WriteDataInFile.Name = "button_WriteDataInFile";
			this.button_WriteDataInFile.Size = new System.Drawing.Size(250, 54);
			this.button_WriteDataInFile.TabIndex = 155;
			this.button_WriteDataInFile.Text = "Записать БД";
			this.button_WriteDataInFile.UseVisualStyleBackColor = true;
			this.button_WriteDataInFile.Click += new System.EventHandler(this.button_WriteDataInFile_Click);
			// 
			// button_ReadDB
			// 
			this.button_ReadDB.Location = new System.Drawing.Point(280, 12);
			this.button_ReadDB.Name = "button_ReadDB";
			this.button_ReadDB.Size = new System.Drawing.Size(250, 55);
			this.button_ReadDB.TabIndex = 156;
			this.button_ReadDB.Text = "Прочитать БД";
			this.button_ReadDB.UseVisualStyleBackColor = true;
			this.button_ReadDB.Click += new System.EventHandler(this.button_ReadDB_Click);
			// 
			// middleNameBox
			// 
			this.middleNameBox.Location = new System.Drawing.Point(1067, 173);
			this.middleNameBox.Name = "middleNameBox";
			this.middleNameBox.Size = new System.Drawing.Size(249, 20);
			this.middleNameBox.TabIndex = 3;
			// 
			// birthdayBox
			// 
			this.birthdayBox.Location = new System.Drawing.Point(1067, 223);
			this.birthdayBox.Name = "birthdayBox";
			this.birthdayBox.Size = new System.Drawing.Size(249, 20);
			this.birthdayBox.TabIndex = 4;
			// 
			// educationFormBox
			// 
			this.educationFormBox.Location = new System.Drawing.Point(1067, 273);
			this.educationFormBox.Name = "educationFormBox";
			this.educationFormBox.Size = new System.Drawing.Size(250, 20);
			this.educationFormBox.TabIndex = 5;
			// 
			// courseBox
			// 
			this.courseBox.Location = new System.Drawing.Point(1067, 323);
			this.courseBox.Name = "courseBox";
			this.courseBox.Size = new System.Drawing.Size(249, 20);
			this.courseBox.TabIndex = 6;
			// 
			// button_AddUserObjectsMarks
			// 
			this.button_AddUserObjectsMarks.Location = new System.Drawing.Point(576, 12);
			this.button_AddUserObjectsMarks.Name = "button_AddUserObjectsMarks";
			this.button_AddUserObjectsMarks.Size = new System.Drawing.Size(277, 53);
			this.button_AddUserObjectsMarks.TabIndex = 158;
			this.button_AddUserObjectsMarks.Text = "Внести данные по Учёбе";
			this.button_AddUserObjectsMarks.UseVisualStyleBackColor = true;
			this.button_AddUserObjectsMarks.Click += new System.EventHandler(this.button_AddUserObjectsMarks_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1328, 656);
			this.Controls.Add(this.button_AddUserObjectsMarks);
			this.Controls.Add(textBox8);
			this.Controls.Add(textBox7);
			this.Controls.Add(textBox6);
			this.Controls.Add(textBox5);
			this.Controls.Add(textBox4);
			this.Controls.Add(textBox3);
			this.Controls.Add(textBox2);
			this.Controls.Add(textBox1);
			this.Controls.Add(this.courseBox);
			this.Controls.Add(this.educationFormBox);
			this.Controls.Add(this.birthdayBox);
			this.Controls.Add(this.middleNameBox);
			this.Controls.Add(this.button_ReadDB);
			this.Controls.Add(this.button_WriteDataInFile);
			this.Controls.Add(this.but_AddUser);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button_DeleteUser);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lastNameBox);
			this.Controls.Add(this.phoneNumberBox);
			this.Controls.Add(this.groupBox);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "Form1";
			this.Text = "Номер телефона";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox groupBox;
		private System.Windows.Forms.TextBox phoneNumberBox;
		private System.Windows.Forms.TextBox lastNameBox;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Button button_DeleteUser;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button but_AddUser;
		private System.Windows.Forms.Button button_WriteDataInFile;
		private System.Windows.Forms.Button button_ReadDB;
		private System.Windows.Forms.TextBox middleNameBox;
		private System.Windows.Forms.TextBox birthdayBox;
		private System.Windows.Forms.TextBox educationFormBox;
		private System.Windows.Forms.TextBox courseBox;
		private System.Windows.Forms.Button button_AddUserObjectsMarks;
	}
}

