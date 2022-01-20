using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomReservationApp.Models;
/*
namespace RoomReservationApp
{
   public partial class CustomerForm : Form
    {
        RoomReservationContext context = new RoomReservationContext();
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = context.Customers.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                int age;
                if (!string.IsNullOrEmpty(txtAddName.Text) && !string.IsNullOrEmpty(txtAddAddress.Text) && !string.IsNullOrEmpty(txtAddPhone.Text)
                    && !string.IsNullOrEmpty(txtAddGender.Text) && !string.IsNullOrEmpty(txtAddAge.Text) && int.TryParse(txtAddAge.Text, out age))
                {
                    context.Customers.Add(new Customer
                    {
                        Name = txtAddName.Text,
                        Address = txtAddAddress.Text,
                        Phone = txtAddPhone.Text,
                        Gender = txtAddGender.Text,
                        Age = age
                    });
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Customers.ToList();
                    txtAddAddress.Clear();
                    txtAddAge.Clear();
                    txtAddGender.Clear();
                    txtAddName.Clear();
                    txtAddPhone.Clear();
                    txtSearch.Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                int age;
                if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtPhone.Text)
                    && !string.IsNullOrEmpty(txtGender.Text) && !string.IsNullOrEmpty(txtAge.Text) && int.TryParse(txtAge.Text, out age))
                {
                    var customer = context.Customers.Find(int.Parse(txtId.Text));
                    customer.Name = txtName.Text;
                    customer.Address = txtAddress.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Gender = txtGender.Text;
                    customer.Age = age;
                    context.SaveChanges();
                    dataGridView1.DataSource = context.Customers.ToList();
                    txtSearch.Clear();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    var customer = (Customer)row.DataBoundItem;
                    txtId.Text = customer.Id.ToString();
                    txtName.Text = customer.Name;
                    txtAddress.Text = customer.Address;
                    txtPhone.Text = customer.Phone;
                    txtGender.Text = customer.Gender;
                    txtAge.Text = customer.Age.ToString();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.DataSource = context.Customers
                    .Where(i => i.Name.Contains(txtSearch.Text))
                    .ToList();
            }
        }
    }
}
*/