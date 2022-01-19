using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repetitie
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadData();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (RestaurantDbContext context = new RestaurantDbContext())
            {
               Client s = new Client();
                s.Nume = this.textBox1.Text;
                s.Prenume = this.textBox2.Text;
                s.DataIntrare = this.dateTimePicker1.Value;
                s.Telefon = int.Parse(textBox3.Text);

                s.DataIntrare = DateTime.Now;

                context.Clienti.Add(s);
                context.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            
            LoadData();
        }
    }
}
