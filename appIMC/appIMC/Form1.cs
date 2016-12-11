using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            double res;            
            res = (Convert.ToDouble(txtpeso.Text)) / (Convert.ToDouble(txtaltu.Text) * Convert.ToDouble(txtaltu.Text));
            res = Math.Round(res,1);
            lblres.Text = res + "";
            if (res >= 18.5 && res <= 24.9)
            {
                lblmens.Text = "Promedio";
            }
            if (res >= 25 && res <= 29.9)
            {
                lblmens.Text = "Aumentado";
            }
            if (res >= 30 && res <= 34.9)
            {
                lblmens.Text = "Moderado";
            }
            if (res >= 35 && res <= 39.9)
            {
                lblmens.Text = "Severo";
            }
            if (res > 40)
            {
                lblmens.Text = "Muy severo";
            }
        }
    }
}
