using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
	public class Student
	{
		#region Свойства пользотеля
		public string Name { get; }
		public string LastName { get; }
		public string MiddleName { get; }

		public DateTime Birthdate { get; }
		public string DayOfBirth { get; }

		public string EducationForm { get; }
		public string Course { get; }
		public string GroupNumber { get; }
		public string PhoneNumber { get; }


		string[] FormsOfEducation = { "Очная", "Заочная" };

		#endregion


		/// <summary>
		/// Студент
		/// </summary>
		/// <param name="lastName">Фамилия</param>
		/// <param name="name">Имя</param>
		/// <param name="middleName">Отчество</param>
		/// <param name="birthday">Дата Рождения</param>
		/// <param name="educationForm">Форма обучения</param>
		/// <param name="course">Курс</param>
		/// <param name="groupNumber">Группа</param>
		/// <param name="phoneNumber">Номер телефона</param>
		public Student(string lastName,string name, string middleName,string birthday,string educationForm,string course,string groupNumber,string phoneNumber)
		{
			if (string.IsNullOrEmpty(lastName))
			{
				throw new ArgumentNullException("Недопустимое значение фамилии", nameof(lastName));
			}
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("Недопустимое значение имени", nameof(name));
			}
			if(string.IsNullOrEmpty(middleName))
			{
				throw new ArgumentNullException("Недопустимое значение отчества", nameof(middleName));
			}

			if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 0 || phoneNumber.Length < 10)
			{
				throw new ArgumentNullException("Недопустимое значение номера телефона", nameof(phoneNumber));
			}

			LastName = lastName;
			Name = name;
			MiddleName = middleName;


			//Проверка даты рождения студента
			//TODO: Подумать как избежать лишней переменной в памяти
			Birthdate = DateTime.Parse(birthday);

			if (Birthdate.Day < 0)
			{
				throw new ArgumentException("Недопустимое значение дня");
			}
			if (Birthdate.Month > 12 || Birthdate.Month < 0)
			{
				throw new ArgumentException("Недпустимое значение месяца");
			}
			if (Birthdate.Year > 2100 || Birthdate.Year < 1920)
			{
				throw new ArgumentException("Недопустимое значение года рождения");
			}


			DayOfBirth = birthday;
			EducationForm = educationForm;
			Course = course;
			GroupNumber = groupNumber;
			PhoneNumber = phoneNumber;
		}
	}
}
