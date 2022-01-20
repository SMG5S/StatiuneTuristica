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
    public partial class RoomReservationApp : Form
    {
        public RoomReservationApp()
        {
            InitializeComponent();
        }

        private void RoomReservationApp_Load(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomFrm roomFrm = new RoomFrm();
            roomFrm.ShowDialog();
        }
    }
}
