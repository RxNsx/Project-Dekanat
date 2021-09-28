using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		public List<User> Users = new List<User>();

		private void Form1_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable();

			MessageBox.Show("Программа запущена");

			dataGridView1.AllowUserToAddRows = false;

			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("LastName", typeof(string));
			table.Columns.Add("PhoneNumber", typeof(string));

			User user = new User("Вадим", "Потороча", "777");
			Users.Add(user);

			table.Rows.Add(Users[0].Name, Users[0].LastName,Users[0].PhoneNumber);

			dataGridView1.DataSource = table;

		}

		


	}
}
