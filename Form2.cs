using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
	public partial class Form2 : Form
	{

		//Курсы
		Courses firstCourse = new Courses(1);
		Courses secondCourse = new Courses(2);
		Courses thirdCourse = new Courses(3);
		Courses fourthCourse = new Courses(4);
		Courses fifthCourse = new Courses(5);
		Courses sixthCourse = new Courses(6);


		public Form2(string lastNameBox,string nameBox,int courseBox,string groupBox)
		{
			InitializeComponent();
			infoBoxAboutSelectedStudent.Text = lastNameBox + " " + nameBox + " "  + courseBox  + groupBox;

			#region Курсы и предметы на курсах
			//Предметы первого курса
			firstCourse.subjects.Add(new Subject("Математика"));
			firstCourse.subjects.Add(new Subject("Русскйи язык"));
			firstCourse.subjects.Add(new Subject("Физика"));

			//Предметы второго курса
			secondCourse.subjects.Add(new Subject("Основы проектирования"));
			secondCourse.subjects.Add(new Subject("Программимрование"));
			secondCourse.subjects.Add(new Subject("Алгоритмы и структуры данных"));

			//Предметы третьего курса
			thirdCourse.subjects.Add(new Subject("Разработка микропроцессоров"));
			thirdCourse.subjects.Add(new Subject("Курсовой проект"));
			thirdCourse.subjects.Add(new Subject("Базы данных"));

			//Предметы четвертого курса
			fourthCourse.subjects.Add(new Subject("Интеграция баз данных"));
			fourthCourse.subjects.Add(new Subject("Технический английский язык"));
			fourthCourse.subjects.Add(new Subject("Профессиональное ориентирование"));

			//Предметы пятого курса
			fifthCourse.subjects.Add(new Subject("Программирование на микроконтроллерах"));
			fifthCourse.subjects.Add(new Subject("Дискретная математика"));
			fifthCourse.subjects.Add(new Subject("Теория автоматов"));

			//Предметы шестого курса
			sixthCourse.subjects.Add(new Subject("Дипломный проект"));
			sixthCourse.subjects.Add(new Subject("Паттерны разработки"));
			sixthCourse.subjects.Add(new Subject("Продвинутое проектирование программ"));

			#endregion

			if (courseBox == firstCourse.CourseNumber)
			{
				firstSubjectBox.Text = firstCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = firstCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = firstCourse.subjects[2].Name.ToString();
			}
			if(courseBox == secondCourse.CourseNumber)
			{
				firstSubjectBox.Text = secondCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = secondCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = secondCourse.subjects[2].Name.ToString();
			}
			if (courseBox == thirdCourse.CourseNumber)
			{
				firstSubjectBox.Text = thirdCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = thirdCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = thirdCourse.subjects[2].Name.ToString();
			}
			if (courseBox == fourthCourse.CourseNumber)
			{
				firstSubjectBox.Text = fourthCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = fourthCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = fourthCourse.subjects[2].Name.ToString();
			}
			if (courseBox == fifthCourse.CourseNumber)
			{
				firstSubjectBox.Text = fifthCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = fifthCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = fifthCourse.subjects[2].Name.ToString();
			}
			if (courseBox == sixthCourse.CourseNumber)
			{
				firstSubjectBox.Text = sixthCourse.subjects[0].Name.ToString();
				secondSubjectBox.Text = sixthCourse.subjects[1].Name.ToString();
				thirdSubjectBox.Text = sixthCourse.subjects[2].Name.ToString();
			}

		}

		private void button_SetMarksOnSubjects_Click(object sender, EventArgs e)
		{
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void firstSubjectBox_TextChanged(object sender, EventArgs e)
		{

		}


	}
}
