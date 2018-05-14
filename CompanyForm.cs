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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            
            InitializeComponent();
            DisplayCompanyInformation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company
            {
                name = txtname.Text,
                address = txtAddress.Text,
                phoneNumber = txtPhoneNo.Text

            };
           bool a= Company.WriteCompanyDatatoXml(company);
            if (a)
            {
                MessageBox.Show("Company information store sucessfully");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int n=dataGridView.Rows.Add();
            //dataGridView.Rows[n].Cells[0].Value = txtname.Text;
            //dataGridView.Rows[n].Cells[1].Value = txtAddress.Text;
            //dataGridView.Rows[n].Cells[2].Value = txtPhoneNo.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
        //    DataSet ds = new DataSet();
        //    DataTable dt = new DataTable();
        //    dt.TableName = "CompanyTable";
        //    dt.Columns.Add("Company");
        //    dt.Columns.Add("Address");
        //    dt.Columns.Add("Phone");
        //    ds.Tables.Add(dt);
            
        //    foreach (DataGridViewRow r in dataGridView.Rows)
        //    {
        //        int cout = dt.Rows.Count;
        //        if(r.Cells[0].Value.ToString()=="")
        //        {
        //            int b = 4;
        //        }
        //        DataRow row = ds.Tables["CompanyTable"].NewRow();
        //        row["Company"] = r.Cells[0].Value.ToString();
        //        row["Address"] = r.Cells[1].Value.ToString();
        //        row["Phone"] = r.Cells[2].Value.ToString();
        //        ds.Tables["CompanyTable"].Rows.Add(row);
        //    }
        //    ds.WriteXml("C:\\Temp\\Data.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Company c = Company.GetCompanyData();
            txtname.Text = c.name;
            txtAddress.Text = c.address;
            txtPhoneNo.Text = c.phoneNumber.ToString();
            //  DisplayCompanyInformation();
        }
        private void DisplayCompanyInformation()
        {
            Company c = Company.GetCompanyData();
            txtname.Text = c.name.ToString();
            txtAddress.Text = c.address.ToString();
            txtPhoneNo.Text = c.phoneNumber.ToString();
        }
        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            //txtname.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //txtAddress.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            //txtPhoneNo.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView.SelectedRows[0].Cells[0].Value = txtname.Text;
            //dataGridView.SelectedRows[0].Cells[0].Value = txtAddress.Text;
            //dataGridView.SelectedRows[0].Cells[0].Value = txtPhoneNo.Text;
            txtname.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNo.Enabled = true;
            //txtname.ReadOnly = true;
            //txtAddress.ReadOnly = true;
            //txtPhoneNo.ReadOnly = true;
            //Company company = new Company
            //{
            //    name = txtname.Text,
            //    address = txtAddress.Text,
            //    phoneNumber = int.Parse("txtPhoneNo.Text")

            //};
            //bool a = Company.WriteCompanyDatatoXml(company);
            //if (a)
            //{
            //    MessageBox.Show("Company information Supdated sucessfully");
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtname.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("No Item to delete");
            }
            else
            {
                //dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                Company company = new Company
                {
                    name = "",
                    address = "",
                    phoneNumber = ""

                };
                bool a = Company.WriteCompanyDatatoXml(company);
                if (a)
                {
                    MessageBox.Show("Company information Deleted sucessfully");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtname.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Enter fields details");
            }
            else
            {
                Company company = new Company
                {
                    name = txtname.Text,
                    address = txtAddress.Text,
                    phoneNumber = txtPhoneNo.Text

                };
                bool a = Company.WriteCompanyDatatoXml(company);
                if (a)
                {
                    MessageBox.Show("Company information store sucessfully");
                    txtname.Enabled = false;
                    txtAddress.Enabled = false;
                    txtPhoneNo.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
