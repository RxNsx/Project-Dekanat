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
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			DataTable table = new DataTable();

			table.Columns.Add("Name", typeof(string));
			table.Columns.Add("LastName", typeof(string));
			table.Columns.Add("PhoneNumber", typeof(string));
			table.Columns.Add("Group", typeof(string));
			table.Columns.Add("MarksJournal", typeof(double));

			dataGridView1.DataSource = table;
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
