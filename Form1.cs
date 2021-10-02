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
		//Cписок пользователей
		List<Student> Students = new List<Student>();
		Student CurrentStudent { get; set; }

		public Form1()
		{
			InitializeComponent();
		}
		
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

			dataGridView1.DataSource = table;
		}

		/// <summary>
		/// Добавление пользователя в таблицу datagridView1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void but_AddUser_Click(object sender, EventArgs e)
		{

			Student student = new Student(lastNameBox.Text,nameBox.Text,middleNameBox.Text, birthdayBox.Text, educationFormBox.Text, new Course(Convert.ToInt32(courseBox.Text)),new Group(groupBox.Text),phoneNumberBox.Text);
			Students.Add(student);

			table.Rows.Add(student.LastName, student.Name, student.MiddleName, student.DayOfBirth, student.EducationForm, student.Course.CourseNumber, student.Group.Name, student.PhoneNumber);

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

						Student student = new Student(values[0], values[1], values[2], values[3], values[4], new Course(Convert.ToInt32(values[5])), new Group(values[6]),values[7]);
						Students.Add(student);
					}

				}
			}
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

			//Выбираем студента по которому кликнули в данный момент
			CurrentStudent = Students[rowIndex];

			Form frm2 = new Form2(CurrentStudent);

			frm2.Show();
			//Выносим новую форму на передний план
			frm2.Activate();
		}

		/// <summary>
		/// Обновление ДГВ
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void button_RefreshDataGridView_Click(object sender, EventArgs e)
		{
			//Students[dataGridView1.CurrentCell.RowIndex] = frm2.
			dataGridView1.Refresh();
		}

		private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
		{
			//Координаты строки измененной ячейки
			int rowIndex = dataGridView1.CurrentCell.RowIndex;

			//Присваивание новых данных после изменения ячейки студента
			CurrentStudent = new Student(

			dataGridView1[0, rowIndex].Value.ToString(),
			dataGridView1[1, rowIndex].Value.ToString(),
			dataGridView1[2, rowIndex].Value.ToString(),
			dataGridView1[3, rowIndex].Value.ToString(),
			dataGridView1[4, rowIndex].Value.ToString(),
			new Course(Convert.ToInt32(dataGridView1[5, rowIndex].Value.ToString())),
			new Group(dataGridView1[6, rowIndex].Value.ToString()),
			dataGridView1[7, rowIndex].Value.ToString()

			);

			Students[rowIndex] = CurrentStudent;
			
				
		}
	}
}
