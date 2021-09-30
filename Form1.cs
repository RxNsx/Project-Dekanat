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
		public List<Student> Users = new List<Student>();
		//Список групп
		public List<string> Groups = new List<string>();
		
		/// <summary>
		/// Таблица данных
		/// </summary>
		DataTable table = new DataTable();
		int[] AllCourses = { 1, 2, 3, 4, 5 };
		string[] FormsOfEducation = { "Очная", "Заочная" };
		//TODO: Добавить обработку массива списка групп
		//string[] groups = { "M11", "M12", "M13", "M14", "M15"};


		/// <summary>
		/// Загрузка программы, подгрузка столбцов таблицы для начала работы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Программа запущена");

			dataGridView1.AllowUserToAddRows = false;

			table.Columns.Add("Имя", typeof(string));
			table.Columns.Add("Фамилия", typeof(string));
			table.Columns.Add("Отчество", typeof(string));
			//table.Columns.Add("Курс", typeof(int));
			//table.Columns.Add("Группа", typeof(string));
			table.Columns.Add("Форма обучения", typeof(string));
			table.Columns.Add("Номер телефона", typeof(string));

			var CourseNumber = new DataGridViewComboBoxColumn();
			CourseNumber.Name = "Курс";
			CourseNumber.MaxDropDownItems = 5;
			
			//Внесение всех курсов в дроплист
			for(int i = 0; i < AllCourses.Length; i++)
			{
				CourseNumber.Items.Add(AllCourses[i]);
			}
			dataGridView1.Columns.Insert(3, CourseNumber);

			var GroupNumber = new DataGridViewComboBoxColumn();
			GroupNumber.Name = "Группа";
			//TODO: Уточнить полное количество групп, или отталкиваться от созданных групп в лист боксе
			GroupNumber.MaxDropDownItems = 5;
			for(int i = 0; i < grou)

			//Внесение всех груп в зависимости от курса



			
			

			//Присваивание таблицы к ДГВ
			dataGridView1.DataSource = table;
		}

		/// <summary>
		/// Добавление пользователя в таблицу datagridView1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void but_AddUser_Click(object sender, EventArgs e)
		{
			Student student = new Student(nameBox_1.Text,lastnameBox_1.Text,phoneNumberBox_1.Text);
			Users.Add(student);

			nameBox_1.Clear();
			lastnameBox_1.Clear();
			phoneNumberBox_1.Clear();

			table.Rows.Add(student.Name,student.LastName,student.PhoneNumber);
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
				DefaultExt = "bin",
				Filter = @"Текстовые файлы(*.txt)|*.txt|CSV-файл (*.csv)|*.csv|Bin-файл (*.bin)|*.bin",
				FilterIndex = 2,
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
							if (!first)
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
			var filepath = string.Empty;

			var openfile = new OpenFileDialog()
			{
				InitialDirectory = "c:\\",
				Filter = @"Текстовые файлы(*.txt)|*.txt|CSV-файл (*.csv)|*.csv|Bin-файл (*.bin)|*.bin",
				FilterIndex = 2,
				RestoreDirectory = true
			};

			//Если открытие файла подтвердилось кнопкой ОК
			if(openfile.ShowDialog() == DialogResult.OK)
			{
				filepath = openfile.FileName;

				//Считывание данные файла в поток
				var filestream = openfile.OpenFile();

				using (var sr = new StreamReader(filestream))
				{
					//Наполняем массиув столбцами (столбец #имя 
					string[] columnnames = sr.ReadLine().Split(' ');
					DataTable dt = new DataTable();

					//Считываем все столбцы
					foreach (string c in columnnames)
					{
						dt.Columns.Add(c);
					}
					string newline;
					while ((newline = sr.ReadLine()) != null)
					{
						DataRow dr = dt.NewRow();
						string[] values = newline.Split(' ');
						for (int i = 0; i < values.Length; i++)
						{
							dr[i] = values[i];
						}
						dt.Rows.Add(dr);
					}
					dataGridView1.DataSource = dt;
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
	}
}
