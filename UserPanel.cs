using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selhoz
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selhozDataSet.Предприятие". При необходимости она может быть перемещена или удалена.
            this.предприятиеTableAdapter.Fill(this.selhozDataSet.Предприятие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "selhozDataSet.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.selhozDataSet.Поставка);

        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }


       
    }
}
