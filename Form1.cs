using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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

		//Cписок пользователей
		List<Student> Students = new List<Student>();

		/// <summary>
		/// Таблица данных для заполнения
		/// </summary>
		DataTable table = new DataTable();

		/// <summary>
		/// Загрузка программы, подгрузка столбцов таблицы для начала работы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{


			MessageBox.Show("Программа запущена");

			dataGridView1.AllowUserToAddRows = false;

			///Отрисовка столбцов главной таблицы dataGridView1
			table.Columns.Add("Фамилия", typeof(string));
			table.Columns.Add("Имя", typeof(string));
			table.Columns.Add("Отчество", typeof(string));
			table.Columns.Add("Дата рождения", typeof(string));
			table.Columns.Add("Форма обучения", typeof(string));
			table.Columns.Add("Курс", typeof(string));
			table.Columns.Add("Группа", typeof(string));
			table.Columns.Add("Номер телефона", typeof(string));
			table.Columns.Add("Cредний балл студента по итогам курса", typeof(string));

			dataGridView1.DataSource = table;

		}

		/// <summary>
		/// Добавление пользователя в таблицу datagridView1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void but_AddUser_Click(object sender, EventArgs e)
		{

			Student student = new Student(lastNameBox.Text,nameBox.Text,middleNameBox.Text, birthdayBox.Text, educationFormBox.Text, courseBox.Text,groupBox.Text,phoneNumberBox.Text);
			Students.Add(student);

			table.Rows.Add(student.LastName, student.Name, student.MiddleName, student.DayOfBirth, student.EducationForm, student.Course, student.GroupNumber, student.PhoneNumber);

			//Разные таблицы для реализации добавления
			//TableForWriting.Rows.Add(student.LastName, student.Name, student.MiddleName, student.DayOfBirth, student.EducationForm, student.Course, student.GroupNumber, student.PhoneNumber);

			lastNameBox.Clear();
			nameBox.Clear();
			middleNameBox.Clear();
			birthdayBox.Clear();
			educationFormBox.Clear();
			courseBox.Clear();
			groupBox.Clear();
			phoneNumberBox.Clear();

		}

		/// <summary>
		/// Удаление выбранной строки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_DeleteUser_Click(object sender, EventArgs e)
		{
			int delete = dataGridView1.SelectedCells[0].RowIndex;
			dataGridView1.Rows.RemoveAt(delete);
			Students.RemoveAt(delete);
		}

		/// <summary>  
		/// Запись данных в файл
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_WriteDataInFile_Click(object sender, EventArgs e)
		{
			var save = new SaveFileDialog
			{
				AddExtension = true,
				InitialDirectory = "c:\\",
				DefaultExt = "txt",
				Filter = @"Текстовые файлы(*.txt)|*.txt",
				FilterIndex = 1,
				RestoreDirectory = false

			};

			if(save.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			//Открытие и закрытие поток записи базы в файл
			//Используется имя файла и директория указанная в ФайлДиалоге save
			using (var sw = new StreamWriter(save.FileName,true,Encoding.UTF8))
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					//Проверка является ли строка новой для записи
					if (!row.IsNewRow)
					{

						bool first = true;

						foreach (DataGridViewCell cell in row.Cells)
						{
							if(!first)
							{
								sw.Write(" ");
							}


							sw.Write(cell.Value.ToString());

							first = false;

						}

						sw.WriteLine();
					}
				}
			}
		}

		/// <summary>
		/// Считывание файла БД
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_ReadDB_Click(object sender, EventArgs e)
		{

			var openfile = new OpenFileDialog()
			{
				InitialDirectory = "c:\\",
				Filter = @"Текстовые файлы(*.txt)|*.txt",
				FilterIndex = 1,
				RestoreDirectory = true
			};

			//Если открытие файла подтвердилось кнопкой ОК
			if(openfile.ShowDialog() == DialogResult.OK)
			{

				//Считывание данные файла в поток
				var filestream = openfile.OpenFile();

				using (var sr = new StreamReader(filestream,Encoding.UTF8,true))
				{
					string newline;

					while ((newline = sr.ReadLine()) != null)
					{
						DataRow dr = table.NewRow();

						string[] values = newline.Split(' ');

						for (int i = 0; i < values.Length; i++)
						{
							dr[i] = values[i];
						}
						table.Rows.Add(dr);
					}

				}
			}
		}

		/// <summary>
		/// Отображение формы успеваемости студента
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			
		}

		/// <summary>
		/// Всплывающая форма для проставления оценок студенту
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_AddUserObjectsMarks_Click(object sender, EventArgs e)
		{
			//Выбрать всю строку целиком

			int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
			int rowIndex = dataGridView1.CurrentCell.RowIndex;

			if(columnIndex > 0)
			{
				columnIndex = 0;
			}

			string LastNameDataForForm2 = dataGridView1[columnIndex, rowIndex].Value.ToString();
			string NameDataForForm2 = dataGridView1["Имя", rowIndex].Value.ToString();
			int CourseDataForForm2 = Convert.ToInt32(dataGridView1["Курс", rowIndex].Value);
			string GroupDataForForm2 = "Группа " + dataGridView1["Группа", rowIndex].Value.ToString();


			//TODO: Добавить данные из датагрида из выделенной ячейки выдернуть нужное
			Form frm2 = new Form2(LastNameDataForForm2, NameDataForForm2,CourseDataForForm2,GroupDataForForm2);
			frm2.Show();
			frm2.Activate();
		}

		public void button_RefreshDataGridView_Click(object sender, EventArgs e)
		{
			dataGridView1.Refresh();
		}
	}
}
