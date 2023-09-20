using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TaskListWinf
{
    internal class DB
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=user_database.db;Version=3;");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("Открыто");
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Закрыто");
            }
        }
        public SQLiteConnection getConnection() { return connection; }
    }
}
