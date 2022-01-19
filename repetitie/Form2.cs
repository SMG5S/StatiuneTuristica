using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace repetitie
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }
        private void LoadData()
        {
            using (RestaurantDbContext mdb = new RestaurantDbContext())
            {
                var res = from p in mdb.Clienti
                          select new
                          {
                              p.IdClient,
                              p.Nume,
                              p.Prenume,
                              p.DataIntrare,
                              p.Telefon
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {



        }

        private async Task AddClient(Client cl)
        {
            using (RestaurantDbContext rdc = new RestaurantDbContext())
            {
                rdc.Clienti.Add(cl);

                await rdc.SaveChangesAsync();
            }
            this.DialogResult = DialogResult.OK;
        }
        public delegate void DelegateDB();
        private async void btnVerificareTask_Click(object sender, EventArgs e)
        {
            if (txtParola.Text.Equals("handybutton"))
            {
                try
                {
                    var res = Task.Run(() => VerificareParola());
                    Console.WriteLine("Checking to see if the password is correct...");
                    res.Wait();
                    Console.WriteLine("Done.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else return;
        }

        private async Task VerificareParola()
        {
            this.BeginInvoke(new DelegateDB(LoadData));
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (RestaurantDbContext context = new RestaurantDbContext())
            {
                Client s = new Client();
                try
                {
                    s.Nume = this.textBox1.Text;
                    s.Prenume = this.textBox2.Text;
                    s.DataIntrare = this.dateTimePicker1.Value;
                    s.Telefon = int.Parse(textBox3.Text);

                    s.DataIntrare = DateTime.Now;

                    var res = Task.Run(() => AddClient(s));
                    Console.WriteLine("Waiting for the add process to finish...");
                    res.Wait();
                    Console.WriteLine("Done.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
