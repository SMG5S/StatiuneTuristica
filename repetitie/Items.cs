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
    public partial class frm_items : Form
    {
        
        const double pret_burger = 25;
        const double pret_cartofi = 10;
        const double pret_supa = 15;
        const double pret_salata = 26;
        const double pret_pui = 16;
        const double pret_apa = 5;
        const double pret_vin = 40;
        const double pret_bere = 7;
        const double pret_cola = 7;
        const double pret_fanta = 6;
        
     
        /*
        
        double pret_burger = 25;
         double pret_cartofi = 10;
         double pret_supa = 15;
        double pret_salata = 26;
        double pret_pui = 16;
        double pret_apa = 5;
         double pret_vin = 40;
         double pret_bere = 7;
        double pret_cola = 7;
        double pret_fanta = 6;
        */
        
        public frm_items()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        
        private void cmb_plata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_plata.Text == "Cash")
            {
                txt_plata.Enabled = true;
                txt_plata.Text = "";
                txt_plata.Focus();
            }
            else
            {
                txt_plata.Enabled = false;
                txt_plata.Text = "0";
            }
            
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            cmb_plata.Items.Add("Cash");
            cmb_plata.Items.Add("Card");

            EnableTextBoxes();
        }


        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
             func(Controls);
        }

        private void chk_burger_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_burger.Checked == true)
            {
                
                txtBurger.Enabled = true;
                txtBurger.Text = "";
                txtBurger.Focus();
            }
            else
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "";
            }

        }

        private void chk_cartofi_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cartofi.Checked == true)
            {
                txtCartofi.Enabled = true;
                txtCartofi.Text = "";
                txtCartofi.Focus();
            }
            else
            {
                txtCartofi.Enabled = false;
                txtCartofi.Text = "0";
            }
        }

        private void chk_pui_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_pui.Checked == true)
            {
                txtPui.Enabled = true;
                txtPui.Text = "";
                txtPui.Focus();
            }
            else
            {
                txtPui.Enabled = false;
                txtPui.Text = "0";
            }
        }

        private void chk_salata_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_salata.Checked == true)
            {
                txtSalata.Enabled = true;
                txtSalata.Text = "";
                txtSalata.Focus();
            }
            else
            {
                txtSalata.Enabled = false;
                txtSalata.Text = "0";
            }
        }

        private void chk_supa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_supa.Checked == true)
            {
                txtSupa.Enabled = true;
                txtSupa.Text = "";
                txtSupa.Focus();
            }
            else
            {
                txtSupa.Enabled = false;
                txtSupa.Text = "0";
            }
        }

        private void chk_apa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_apa.Checked == true)
            {
                txtApa.Enabled = true;
                txtApa.Text = "";
                txtApa.Focus();
            }
            else
            {
                txtApa.Enabled = false;
                txtApa.Text = "0";
            }
        }

        private void chk_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cola.Checked == true)
            {
                txtCola.Enabled = true;
                txtCola.Text = "";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void chk_bere_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_bere.Checked == true)
            {
                txtBere.Enabled = true;
                txtBere.Text = "";
                txtBere.Focus();
            }
            else
            {
                txtBere.Enabled = false;
                txtBere.Text = "0";
            }
        }

        private void chk_vin_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_vin.Checked == true)
            {
                txtVin.Enabled = true;
                txtVin.Text = "";
                txtVin.Focus();
            }
            else
            {
                txtVin.Enabled = false;
                txtVin.Text = "0";
            }
        }

        private void chk_fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_fanta.Checked == true)
            {
                txtFanta.Enabled = true;
                txtFanta.Text = "";
                txtFanta.Focus();
            }
            else
            {
                txtFanta.Enabled = false;
                txtFanta.Text = "0";
            }
        }

        private void txt_plata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[100];
            try
            {
                itemcost[0] = Convert.ToDouble(txtBurger.Text) * pret_burger;
                itemcost[2] = Convert.ToDouble(txtCartofi.Text) * pret_cartofi;
                itemcost[3] = Convert.ToDouble(txtPui.Text) * pret_pui;
                itemcost[4] = Convert.ToDouble(txtSupa.Text) * pret_supa;
                itemcost[5] = Convert.ToDouble(txtSalata.Text) * pret_salata;

                itemcost[6] = Convert.ToDouble(txtApa.Text) * pret_apa;
                itemcost[7] = Convert.ToDouble(txtVin.Text) * pret_vin;
                itemcost[8] = Convert.ToDouble(txtBere.Text) * pret_bere;
                itemcost[9] = Convert.ToDouble(txtFanta.Text) * pret_fanta;
                itemcost[10] = Convert.ToDouble(txtCola.Text) * pret_cola;
                /*
                itemcost[0] = Double.Parse(txtBurger.Text) * pret_burger;

                itemcost[2] = Double.Parse(txtCartofi.Text) * pret_cartofi;
                itemcost[3] = Double.Parse(txtPui.Text) * pret_pui;
                itemcost[4] = Double.Parse(txtSupa.Text) * pret_supa;
                itemcost[5] = Double.Parse(txtSalata.Text) * pret_salata;

                itemcost[6] = Double.Parse(txtApa.Text) * pret_apa;
                itemcost[7] = Double.Parse(txtVin.Text) * pret_vin;
                itemcost[8] = Double.Parse(txtBere.Text) * pret_bere;
                itemcost[9] = Double.Parse(txtFanta.Text) * pret_fanta;
                itemcost[10] = Double.Parse(txtCola.Text) * pret_cola;
                */


                double total, plata, pret;
                if (cmb_plata.Text == "Cash")
                {
                    total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                    label2.Text = Convert.ToString(total);

                    plata = Convert.ToInt32(txt_plata.Text);

                    pret = plata - total;

                    label3.Text = Convert.ToString(pret);
                }
                if (cmb_plata.Text == "Card")
                {
                    total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10];

                    label2.Text = Convert.ToString(total);

                    label3.Text ="Plata acceptata";
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Va rog comandati ceva inainte sa platiti!");
                Console.WriteLine(fe.Message);
            }

        }

        

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Thank you!");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
          
            MessageBox.Show(
            "Mancare                         Pret \n" +
            " \n " +
            "burgher            ->         25 lei \n" +
            " cartofi prajiti    ->         10 lei \n" +
            " supa a la grec   ->         15 lei \n" +
            " salata                ->          26 lei \n" +
            " piept de pui     ->          16 lei \n" +
            " \n " +
            "Racoritoare                    Pret \n " +
            " \n " +
            "apa               ->                5 lei \n" +
            " vin                ->               40 lei \n" +
            " cola               ->               7 lei \n" +
            " bere               ->              7 lei \n" +
            " fanta              ->             6 lei \n");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
