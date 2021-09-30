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
		public string PhoneNumber { get; }
		#endregion


		/// <summary>
		/// Данные пользователя
		/// </summary>
		/// <param name="name">Имя</param>
		/// <param name="lastName">Фамилия</param>
		/// <param name="phoneNumber">Номер телефона</param>
		public Student(string name,string lastName,string phoneNumber)
		{
			if(string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("Недопустимое значение имени", nameof(name));
			}
			if (string.IsNullOrEmpty(lastName))
			{
				throw new ArgumentNullException("Недопустимое значение имени", nameof(lastName));
			}
			if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 0 || phoneNumber.Length < 10)
			{
				throw new ArgumentNullException("Недопустимое значение номера телефона", nameof(phoneNumber));
			}

			Name = name;
			LastName = lastName;
			PhoneNumber = phoneNumber;
		}
	}
}
