using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise6
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void addNewCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm com = new CompanyForm();
            com.Show();
        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm();
            car.Show();
        }
    }
}
