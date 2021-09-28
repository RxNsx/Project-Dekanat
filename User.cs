using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
	public class User
	{
		public string Name { get; }
		public string LastName { get; }
		public string PhoneNumber { get; }

		public User(string name,string lastName,string phoneNumber)
		{
			if(string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("Недопустимое значение имени", nameof(name));
			}
			if (string.IsNullOrEmpty(lastName))
			{
				throw new ArgumentNullException("Недопустимое значение имени", nameof(lastName));
			}
			//if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length < 12 || phoneNumber.Length > 15)
			//{
			//	throw new ArgumentNullException("Недопустимое значение имени", nameof(phoneNumber));
			//}


			Name = name;
			LastName = lastName;
			PhoneNumber = phoneNumber;
		}
	}
}
