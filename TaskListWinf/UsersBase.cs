using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;

namespace TaskListWinf
{
    public partial class UsersBase : Form
    {
        string sql = "SELECT * FROM Task";// показать таблицу с заданиями
        string insert = "INSERT INTO Task(responsible, task, deadline, check_mark) VALUES(@responsible, @task, @deadline, @check_mark);";
        DB dBtask;
        SQLiteDataAdapter adapter;
        SQLiteCommandBuilder commandBuilder;
        SQLiteCommand sqlCommand;
        DataTable table = new DataTable();
        DataSet ds;

        public UsersBase()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//полное выделение строки
            dataGridView1.AllowUserToAddRows = false;//ручное добавление новых строк запрещено
            dBtask = new DB();
            dBtask.OpenConnection(); 
            sqlCommand = new SQLiteCommand(sql, dBtask.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlCommand);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            // делаем недоступным столбец id для изменения
            dataGridView1.Columns["ID"].ReadOnly = true;
            dBtask.CloseConnection();
        }

        // кнопка добавления
        private void addButton_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }
        // кнопка удаления
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }


       
        // кнопка сохранения
        private void saveButton_Click(object sender, EventArgs e)
        {
            dBtask.OpenConnection();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, dBtask.getConnection());
            commandBuilder = new SQLiteCommandBuilder(adapter);
            adapter.InsertCommand = new SQLiteCommand(insert, dBtask.getConnection());
            adapter.InsertCommand.Parameters.Add(new SQLiteParameter("@responsible", DbType.String, 100, "responsible"));
            adapter.InsertCommand.Parameters.Add(new SQLiteParameter("@task", DbType.String, 100, "task"));
            adapter.InsertCommand.Parameters.Add(new SQLiteParameter("@deadline", DbType.Date, 100, "deadline"));
            adapter.InsertCommand.Parameters.Add(new SQLiteParameter("@check_mark", DbType.String, 100, "check_mark"));
            SQLiteParameter parameter = adapter.InsertCommand.Parameters.Add("@ID", DbType.Int64, 0, "ID");
            adapter.Update(ds);
            dBtask.CloseConnection();


        }

    }
}
