namespace WFA
{
	partial class Form2
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
			this.infoBoxAboutSelectedStudent = new System.Windows.Forms.TextBox();
			this.infoLabelAboutSelectedStudent = new System.Windows.Forms.TextBox();
			this.firstSubjectBox = new System.Windows.Forms.TextBox();
			this.secondSubjectBox = new System.Windows.Forms.TextBox();
			this.thirdSubjectBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.firstSubjectMarkBox = new System.Windows.Forms.TextBox();
			this.secondSubjectMarkBox = new System.Windows.Forms.TextBox();
			this.thirdSubjectMarkBox = new System.Windows.Forms.TextBox();
			this.button_SetMarksOnSubjects = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// infoBoxAboutSelectedStudent
			// 
			this.infoBoxAboutSelectedStudent.BackColor = System.Drawing.Color.Linen;
			this.infoBoxAboutSelectedStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.infoBoxAboutSelectedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoBoxAboutSelectedStudent.Location = new System.Drawing.Point(12, 35);
			this.infoBoxAboutSelectedStudent.Name = "infoBoxAboutSelectedStudent";
			this.infoBoxAboutSelectedStudent.Size = new System.Drawing.Size(527, 13);
			this.infoBoxAboutSelectedStudent.TabIndex = 0;
			// 
			// infoLabelAboutSelectedStudent
			// 
			this.infoLabelAboutSelectedStudent.BackColor = System.Drawing.Color.Linen;
			this.infoLabelAboutSelectedStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.infoLabelAboutSelectedStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.infoLabelAboutSelectedStudent.Location = new System.Drawing.Point(12, 9);
			this.infoLabelAboutSelectedStudent.Name = "infoLabelAboutSelectedStudent";
			this.infoLabelAboutSelectedStudent.Size = new System.Drawing.Size(430, 23);
			this.infoLabelAboutSelectedStudent.TabIndex = 1;
			this.infoLabelAboutSelectedStudent.TabStop = false;
			this.infoLabelAboutSelectedStudent.Text = "Информация о студенте";
			// 
			// firstSubjectBox
			// 
			this.firstSubjectBox.Location = new System.Drawing.Point(12, 87);
			this.firstSubjectBox.Name = "firstSubjectBox";
			this.firstSubjectBox.ReadOnly = true;
			this.firstSubjectBox.Size = new System.Drawing.Size(247, 20);
			this.firstSubjectBox.TabIndex = 2;
			this.firstSubjectBox.TextChanged += new System.EventHandler(this.firstSubjectBox_TextChanged);
			// 
			// secondSubjectBox
			// 
			this.secondSubjectBox.Location = new System.Drawing.Point(12, 123);
			this.secondSubjectBox.Name = "secondSubjectBox";
			this.secondSubjectBox.ReadOnly = true;
			this.secondSubjectBox.Size = new System.Drawing.Size(246, 20);
			this.secondSubjectBox.TabIndex = 3;
			// 
			// thirdSubjectBox
			// 
			this.thirdSubjectBox.Location = new System.Drawing.Point(12, 161);
			this.thirdSubjectBox.Name = "thirdSubjectBox";
			this.thirdSubjectBox.ReadOnly = true;
			this.thirdSubjectBox.Size = new System.Drawing.Size(245, 20);
			this.thirdSubjectBox.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Linen;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(246, 16);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "Предметы";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Linen;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(293, 54);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(153, 16);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "Оценка";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// firstSubjectMarkBox
			// 
			this.firstSubjectMarkBox.Location = new System.Drawing.Point(341, 87);
			this.firstSubjectMarkBox.MaxLength = 1;
			this.firstSubjectMarkBox.Name = "firstSubjectMarkBox";
			this.firstSubjectMarkBox.Size = new System.Drawing.Size(60, 20);
			this.firstSubjectMarkBox.TabIndex = 7;
			// 
			// secondSubjectMarkBox
			// 
			this.secondSubjectMarkBox.Location = new System.Drawing.Point(341, 123);
			this.secondSubjectMarkBox.MaxLength = 1;
			this.secondSubjectMarkBox.Name = "secondSubjectMarkBox";
			this.secondSubjectMarkBox.Size = new System.Drawing.Size(60, 20);
			this.secondSubjectMarkBox.TabIndex = 8;
			// 
			// thirdSubjectMarkBox
			// 
			this.thirdSubjectMarkBox.Location = new System.Drawing.Point(341, 161);
			this.thirdSubjectMarkBox.MaxLength = 1;
			this.thirdSubjectMarkBox.Name = "thirdSubjectMarkBox";
			this.thirdSubjectMarkBox.Size = new System.Drawing.Size(60, 20);
			this.thirdSubjectMarkBox.TabIndex = 9;
			// 
			// button_SetMarksOnSubjects
			// 
			this.button_SetMarksOnSubjects.Location = new System.Drawing.Point(447, 96);
			this.button_SetMarksOnSubjects.Name = "button_SetMarksOnSubjects";
			this.button_SetMarksOnSubjects.Size = new System.Drawing.Size(221, 73);
			this.button_SetMarksOnSubjects.TabIndex = 10;
			this.button_SetMarksOnSubjects.Text = "Проставить оценки";
			this.button_SetMarksOnSubjects.UseVisualStyleBackColor = true;
			this.button_SetMarksOnSubjects.Click += new System.EventHandler(this.button_SetMarksOnSubjects_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Linen;
			this.ClientSize = new System.Drawing.Size(705, 225);
			this.Controls.Add(this.button_SetMarksOnSubjects);
			this.Controls.Add(this.thirdSubjectMarkBox);
			this.Controls.Add(this.secondSubjectMarkBox);
			this.Controls.Add(this.firstSubjectMarkBox);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.thirdSubjectBox);
			this.Controls.Add(this.secondSubjectBox);
			this.Controls.Add(this.firstSubjectBox);
			this.Controls.Add(this.infoLabelAboutSelectedStudent);
			this.Controls.Add(this.infoBoxAboutSelectedStudent);
			this.Name = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox infoBoxAboutSelectedStudent;
		private System.Windows.Forms.TextBox infoLabelAboutSelectedStudent;
		private System.Windows.Forms.TextBox firstSubjectBox;
		private System.Windows.Forms.TextBox secondSubjectBox;
		private System.Windows.Forms.TextBox thirdSubjectBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox firstSubjectMarkBox;
		private System.Windows.Forms.TextBox secondSubjectMarkBox;
		private System.Windows.Forms.TextBox thirdSubjectMarkBox;
		private System.Windows.Forms.Button button_SetMarksOnSubjects;
	}
}