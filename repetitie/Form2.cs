using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace repetitie
{
    public partial class Form2 : Form
    {
        private StringBuilder pswrd;
        public Form2()
        {
            pswrd = new StringBuilder();
            pswrd.Append("handybutton");
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
        private void btnVerificareTask_Click(object sender, EventArgs e)
        {
            using (SHA256 hash = SHA256.Create())
            {
                Console.WriteLine("Before: " + pswrd);
                byte[] bytes1;
                bytes1 = hash.ComputeHash(Encoding.UTF8.GetBytes(pswrd.ToString()));
                pswrd.Clear();
                for(int i=0;i<bytes1.Length;++i)
                {
                    pswrd.Append(bytes1[i].ToString("x2"));
                }
                StringBuilder sb = new StringBuilder();
                sb.Append(txtParola.Text);
                Console.WriteLine("Before: " + sb);
                byte[] bytes2;
                bytes2 = hash.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()));
                sb.Clear();
                for(int i=0;i<bytes2.Length;++i)
                {
                    sb.Append(bytes2[i].ToString("x2"));
                }
                if (sb.Equals(pswrd))
                {
                    try
                    {
                        var res = Task.Run(() => VerificareParola());
                        Console.WriteLine("Checking to see if the process of verification is finishing...");
                        res.Wait();
                        Console.WriteLine("Done.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return;
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
