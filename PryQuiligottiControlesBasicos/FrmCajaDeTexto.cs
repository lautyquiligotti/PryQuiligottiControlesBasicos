using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryQuiligottiControlesBasicos
{
    public partial class FrmCajaDeTexto : Form
    {
        public FrmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void txtReflejar_TextChanged(object sender, EventArgs e)
        {
            lblDuplicar.Text = txtReflejar.Text;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optRojo.Checked == true)
            {
                lblDuplicar.ForeColor = Color.Red;
                txtReflejar.ForeColor = Color.Red;
            }

            if (optAzul.Checked == true)
            {
                lblDuplicar.ForeColor = Color.Blue;
                txtReflejar.ForeColor = Color.Blue;
            }

        }
    }
}



