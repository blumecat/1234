using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSs
{
    public partial class Avtr : Form
    {
        public Avtr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=se.accdb";
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                conn.Open();
                string query = "SELECT Роль FROM Пользователь WHERE логин = @login and пароль = @password";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    object role = cmd.ExecuteScalar();


                    if (role != null)
                    {
                        string userRole = role.ToString();
                        if (userRole == "client")
                        {
                            MenuU changepasswordform = new MenuU();
                            changepasswordform.Show();
                            this.Hide();
                        }
                        else
                        {
                            Menu hub = new Menu();
                            hub.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }
    }
}
