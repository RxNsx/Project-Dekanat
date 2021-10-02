using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
	public class Course
	{
		public int CourseNumber = 0;

		//TODO: Список групп
		//Cписок групп на курсе
		List<Group> groups = new List<Group>();

		//Список предметов
		public List<Subject> subjects = new List<Subject>();

		public Course(int courseNumber)
		{
			CourseNumber = courseNumber;
		}
		
	}
}
