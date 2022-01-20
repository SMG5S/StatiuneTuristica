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

namespace repetitie
{
    public partial class RoomFrm : Form
    {

        RoomReservationContext context = new RoomReservationContext();

        public RoomFrm()
        {
            InitializeComponent();

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RoomFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Rooms.ToList();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            double price;

            if (!string.IsNullOrEmpty(txtAddPrice.Text) && !string.IsNullOrEmpty(txtAddName.Text) && double.TryParse(txtAddPrice.Text, out price))
            {
                context.Rooms.Add(new Room
                {
                    Name = txtAddName.Text,
                    Price = price,
                    IsActive = true
                });
                context.SaveChanges();
                dataGridView1.DataSource = context.Rooms.ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var room = (Room)row.DataBoundItem;
                txtId.Text = room.Id.ToString();
                txtName.Text = room.Name;
                txtPrice.Text = room.Price.ToString();
                checkActive.Checked = room.IsActive;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                double price;
                try
                {
                    if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtName.Text)
                        && !string.IsNullOrEmpty(txtPrice.Text) && double.TryParse(txtPrice.Text, out price))
                    {
                        var room = context.Rooms.Find(int.Parse(txtId.Text));
                        room.Name = txtName.Text;
                        room.Price = price;
                        room.IsActive = checkActive.Checked;
                        context.SaveChanges();
                        dataGridView1.DataSource = context.Rooms.ToList();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
