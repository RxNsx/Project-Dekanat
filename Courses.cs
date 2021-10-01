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

		List<string> groups = new List<string>();

		public Courses(byte courseNumber)
		{
			CourseNumber = courseNumber;
		}
	}
}
