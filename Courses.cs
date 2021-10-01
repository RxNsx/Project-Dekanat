using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
	public class Courses
	{
		public byte CourseNumber = 0;

		//Cписок групп на курсе
		List<string> groups = new List<string>();

		//Список предметов
		public List<Subject> subjects = new List<Subject>();

		public Courses(byte courseNumber)
		{
			CourseNumber = courseNumber;
		}
		
	}
}
