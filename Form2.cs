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
		//Переменная для приёма студента которому выставляем оценки
		Student CurrentStudentForm2 { get; }
		////Курсы
		Course firstCourse = new Course(1);
		Course secondCourse = new Course(2);
		Course thirdCourse = new Course(3);
		Course fourthCourse = new Course(4);
		Course fifthCourse = new Course(5);
		Course sixthCourse = new Course(6);

		public Form2()
		{
			InitializeComponent();
		}


		public Form2(Student student)
		{
			InitializeComponent();
			infoBoxAboutSelectedStudent.Text = student.LastName + " " + student.Name + " " + student.Course.CourseNumber + " " +
				student.Group.Name;

			//Вносим текущего пользователя на уровне формы
			CurrentStudentForm2 = student;

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

			#region Заполнение полей предметов

			if (student.Course.CourseNumber == firstCourse.CourseNumber)
			{
				firstSubjectBox.Text = firstCourse.subjects[0].Name;
				secondSubjectBox.Text = firstCourse.subjects[1].Name;
				thirdSubjectBox.Text = firstCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = firstCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = firstCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = firstCourse.subjects[2].Name;
			}
			if (student.Course.CourseNumber == secondCourse.CourseNumber)
			{
				firstSubjectBox.Text = secondCourse.subjects[0].Name;
				secondSubjectBox.Text = secondCourse.subjects[1].Name;
				thirdSubjectBox.Text = secondCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = secondCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = secondCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = secondCourse.subjects[2].Name;
			}
			if (student.Course.CourseNumber == thirdCourse.CourseNumber)
			{
				firstSubjectBox.Text = thirdCourse.subjects[0].Name;
				secondSubjectBox.Text = thirdCourse.subjects[1].Name;
				thirdSubjectBox.Text = thirdCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = thirdCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = thirdCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = thirdCourse.subjects[2].Name;
			}
			if (student.Course.CourseNumber == fourthCourse.CourseNumber)
			{
				firstSubjectBox.Text = fourthCourse.subjects[0].Name;
				secondSubjectBox.Text = fourthCourse.subjects[1].Name;
				thirdSubjectBox.Text = fourthCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = fourthCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = fourthCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = fourthCourse.subjects[2].Name;
			}
			if (student.Course.CourseNumber == fifthCourse.CourseNumber)
			{
				firstSubjectBox.Text = fifthCourse.subjects[0].Name;
				secondSubjectBox.Text = fifthCourse.subjects[1].Name;
				thirdSubjectBox.Text = fifthCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = fifthCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = fifthCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = fifthCourse.subjects[2].Name;
			}
			if (student.Course.CourseNumber == sixthCourse.CourseNumber)
			{
				firstSubjectBox.Text = sixthCourse.subjects[0].Name;
				secondSubjectBox.Text = sixthCourse.subjects[1].Name;
				thirdSubjectBox.Text = sixthCourse.subjects[2].Name;

				firstSubjectAddedMarkBox.Text = sixthCourse.subjects[0].Name;
				secondSubjectAddedMarkBox.Text = sixthCourse.subjects[1].Name;
				thirdSubjectAddedMarkBox.Text = sixthCourse.subjects[2].Name;
			}
			#endregion
		}

		/// <summary>
		/// Внесение оценок студенту по предметам в зависимости от курса
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_SetMarksOnSubjects_Click(object sender, EventArgs e)
		{
			/*
			 * Первому предмету присваивается оценка из первого поля
			 * Второму из второго
			 * Третьему из третьего
			 */

			#region Присваивание оценки студенту

			if (CurrentStudentForm2.Course.CourseNumber == firstCourse.CourseNumber)
			{
				firstCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				firstCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				firstCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);


				addedMarkBoxFirst.Text = firstCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = firstCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = firstCourse.subjects[2].Mark.ToString();
			}
			if (CurrentStudentForm2.Course.CourseNumber == secondCourse.CourseNumber)
			{
				secondCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				secondCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				secondCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);

				addedMarkBoxFirst.Text = secondCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = secondCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = secondCourse.subjects[2].Mark.ToString();
			}
			if (CurrentStudentForm2.Course.CourseNumber == thirdCourse.CourseNumber)
			{
				thirdCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				thirdCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				thirdCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);

				addedMarkBoxFirst.Text = thirdCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = thirdCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = thirdCourse.subjects[2].Mark.ToString();
			}
			if (CurrentStudentForm2.Course.CourseNumber == fourthCourse.CourseNumber)
			{
				fourthCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				fourthCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				fourthCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);

				addedMarkBoxFirst.Text = fourthCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = fourthCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = fourthCourse.subjects[2].Mark.ToString();
			}
			if (CurrentStudentForm2.Course.CourseNumber == fifthCourse.CourseNumber)
			{
				fifthCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				fifthCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				fifthCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);

				addedMarkBoxFirst.Text = fifthCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = fifthCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = fifthCourse.subjects[2].Mark.ToString();
			}
			if (CurrentStudentForm2.Course.CourseNumber == sixthCourse.CourseNumber)
			{
				sixthCourse.subjects[0].Mark = Convert.ToInt32(firstSubjectMarkBox.Text);
				sixthCourse.subjects[1].Mark = Convert.ToInt32(secondSubjectMarkBox.Text);
				sixthCourse.subjects[2].Mark = Convert.ToInt32(thirdSubjectMarkBox.Text);

				addedMarkBoxFirst.Text = sixthCourse.subjects[0].Mark.ToString();
				addedMarkBoxSecond.Text = sixthCourse.subjects[1].Mark.ToString();
				addedMarkBoxThird.Text = sixthCourse.subjects[2].Mark.ToString();
			}

			#endregion

			MessageBox.Show("Оценки проставлены");
			//Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void addedMarkBoxFirst_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
