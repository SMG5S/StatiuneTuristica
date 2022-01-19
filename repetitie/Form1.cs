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
    public partial class frm_meniu : Form
    {
        
        public frm_meniu()
        {
            InitializeComponent();
           
        }

        

        //nu folosim
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //nu folosim
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Form item = new frm_items();
            item.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Conmirma ca vrei sa iesi din meniu : ", "Comanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            Form2 lala = new Form2();
            lala.Show();
            this.Hide();
        }

    }
}
