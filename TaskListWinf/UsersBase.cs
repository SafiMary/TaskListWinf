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

namespace TaskListWinf
{
    public partial class UsersBase : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder; 
        string connectionString = (@"Data Source=user_database.db;Version=3;");
        string sql = "SELECT * FROM Task";// показать таблицу с заданиями
        public UsersBase()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();
            //    adapter = new SqlDataAdapter(sql, connection);

            //    ds = new DataSet();
            //    adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];
            //    // делаем недоступным столбец id для изменения
            //    dataGridView1.Columns["Id"].ReadOnly = true;
            //}
            DB dBtask = new DB();
            dBtask.getConnection();
            SQLiteCommand sqlCommand = new SQLiteCommand(sql, dBtask.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlCommand);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            // делаем недоступным столбец id для изменения
            dataGridView1.Columns["Id"].ReadOnly = true;

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, 50, "Password"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@role", SqlDbType.NVarChar, 50, "Role"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
