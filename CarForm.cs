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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> carList = new List<Car>();
            Car c = new Car();
            foreach (DataGridViewRow r in carGridView.Rows)
            {
                if (r.Cells[0].Value != null)
                {
                    c.brand = r.Cells[0].Value.ToString();
                    c.model = r.Cells[1].Value.ToString();
                    c.manufacturingYear = r.Cells[2].Value.ToString();
                    c.mileage = int.Parse(r.Cells[3].Value.ToString());
                    c.price = int.Parse(r.Cells[4].Value.ToString());
                    carList.Add(c);
                }
            }
            bool a = Car.WriteCarDataXmlFormat(carList);
            if(a)
            {
                MessageBox.Show("Car information inserted successfully");
                txtBrand.Text = "";
                txtModel.Text = "";
                txtMileage.Text = "";
                txtPrice.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        int n = carGridView.Rows.Add();

            carGridView.Rows[n].Cells[0].Value = txtBrand.Text;
            carGridView.Rows[n].Cells[1].Value = txtModel.Text;
            carGridView.Rows[n].Cells[2].Value = txtDate.Text;
            carGridView.Rows[n].Cells[3].Value = txtMileage.Text;
            carGridView.Rows[n].Cells[4].Value = txtPrice.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Car> cars = Car.GetAllCars();
            if (cars != null)
            {

                foreach (var item in cars)
                {
                    int n = carGridView.Rows.Add();
                    carGridView.Rows[n].Cells[0].Value = item.brand;
                    carGridView.Rows[n].Cells[1].Value = item.model;
                    carGridView.Rows[n].Cells[2].Value = item.manufacturingYear;
                    carGridView.Rows[n].Cells[3].Value = item.mileage;
                    carGridView.Rows[n].Cells[4].Value = item.price;
                }
            }
            else

            {
                MessageBox.Show("No data fetch");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //txt.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //txtPhoneNo.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void carGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBrand.Text = carGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtModel.Text = carGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtMileage.Text = carGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = carGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carGridView.Rows.RemoveAt(carGridView.SelectedRows[0].Index);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            txtBrand.Text = "";
            txtModel.Text = "";
            txtMileage.Text = "";
            txtPrice.Text = "";
        }
    }
}
