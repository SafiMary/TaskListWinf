﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TaskListWinf
{
    public partial class AuthorizationForm : Form
    {
        private List<User> users;
        private string findUsers = $"SELECT * FROM USERLIST  WHERE NAME = @name AND PASSWORD = @pass";//поиск зарегистрированного  пользователя
        UsersBase UsersBase = null;
        public AuthorizationForm()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//невидимый бордюр формы
            users = new List<User>();
            UsersBase = new UsersBase();
          
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin.Text;
            string Pass = maskedTxtBoxPass.Text;
            DataTable table = new DataTable();
            DB dBWork = new DB();
            SQLiteCommand sqlCommand = new SQLiteCommand(findUsers, dBWork.getConnection());
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlCommand);
            sqlCommand.Parameters.Add("@name", DbType.String).Value = Login;
            sqlCommand.Parameters.Add("@pass", DbType.String).Value = Pass;
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь существует!");
                //переход от одной формы в другую
                UsersBase.Tag = this;
                UsersBase.Show(this);
                Hide();
            }
            else
            {
                MessageBox.Show("У вас нет доступа");
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
