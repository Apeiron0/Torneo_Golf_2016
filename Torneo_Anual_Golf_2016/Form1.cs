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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jugadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_shootoutDataSet);

        }

        private void jugadorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.jugadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database_shootoutDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_shootoutDataSet.Jugador' table. You can move, or remove it, as needed.
            this.jugadorTableAdapter.Fill(this.database_shootoutDataSet.Jugador);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_tiros_actuales tiro = new frm_tiros_actuales();
            tiro.Show();
        }
    }
}
