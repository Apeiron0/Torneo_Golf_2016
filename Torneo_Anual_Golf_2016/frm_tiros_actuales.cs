using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneo_Anual_Golf_2016
{
    public partial class frm_tiros_actuales : Form
    {
        public frm_tiros_actuales()
        {
            InitializeComponent();
        }

        private void frm_tiros_actuales_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToShortDateString();
            label4.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
