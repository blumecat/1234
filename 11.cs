using AUTO_BUS.DBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTO_BUS
{
    public partial class Form1 : Form
    {
        



        private void HideControlsBasedOnRole(string role)
        {
            if (role == "бан")
            {

                tabControl1.Visible = false;
                button1.Visible = false;
            }
        }

        public Form1(string role)
        {
            InitializeComponent();
            HideControlsBasedOnRole(role);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.транспорт". При необходимости она может быть перемещена или удалена.
            this.транспортTableAdapter.Fill(this.dBDataSet.транспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Пути". При необходимости она может быть перемещена или удалена.
            this.путиTableAdapter.Fill(this.dBDataSet.Пути);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.номер_маршрута". При необходимости она может быть перемещена или удалена.
            this.номер_маршрутаTableAdapter.Fill(this.dBDataSet.номер_маршрута);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add addusers = new add();
            addusers.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add_Puti add_Puti = new add_Puti();
            add_Puti.ShowDialog();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            add_marshrut add_marshrut = new add_marshrut();
            add_marshrut.ShowDialog();
        }
       

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)
                {
            транспортTableAdapter.Update(dBDataSet);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            путиTableAdapter.Update(dBDataSet);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            номер_маршрутаTableAdapter.Update(dBDataSet);
        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Users". При необходимости она может быть перемещена или удалена.
            usersTableAdapter.Update(this.dBDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.транспорт". При необходимости она может быть перемещена или удалена.
            транспортTableAdapter.Update(this.dBDataSet.транспорт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Пути". При необходимости она может быть перемещена или удалена.
            путиTableAdapter.Update(this.dBDataSet.Пути);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.номер_маршрута". При необходимости она может быть перемещена или удалена.
            номер_маршрутаTableAdapter.Update(this.dBDataSet.номер_маршрута);
        }
    }
}
