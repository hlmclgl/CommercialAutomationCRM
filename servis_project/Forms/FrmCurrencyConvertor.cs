using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servis_project.Forms
{
    public partial class FrmCurrencyConvertor : Form
    {
        public FrmCurrencyConvertor()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            float f = float.Parse(txtAmount.Text);

            if (comboBoxEdit1.SelectedItem == "Türk Lirası" && comboBoxEdit2.SelectedItem == "Dolar")
            {
                float flo = f / 26.88F;
                txtDisplay.Text = "$ " + flo;
            }
            else if (comboBoxEdit1.SelectedItem == "Türk Lirası" && comboBoxEdit2.SelectedItem == "Euro")
            {
                float flo = f / 28.89F;
                txtDisplay.Text = "€ " + flo;
            }
            else if (comboBoxEdit1.SelectedItem == "Türk Lirası" && comboBoxEdit2.SelectedItem == "Sterlin")
            {
                float flo = f / 33.63F;
                txtDisplay.Text = "£ " + flo;
            }
            else if (comboBoxEdit1.SelectedItem == "Türk Lirası" && comboBoxEdit2.SelectedItem == "Altın")
            {
                float flo = f / 1661.08F;
                txtDisplay.Text = flo + " gr.";
            }
            else if (comboBoxEdit1.SelectedItem == "Türk Lirası" && comboBoxEdit2.SelectedItem == "Gümüş")
            {
                float flo = f / 19.93F;
                txtDisplay.Text = flo + " gr.";
            }
            else
            {
                float flo = f / 7.16F;
                txtDisplay.Text = flo + " Riyal.";
            }

            if (comboBoxEdit1.SelectedItem == "Dolar" && comboBoxEdit2.SelectedItem == "Türk Lirası")
            {
                float flo = f * 26.88F;
                txtDisplay.Text = "₺ " + flo;
            }

            if (comboBoxEdit1.SelectedItem == "Euro" && comboBoxEdit2.SelectedItem == "Türk Lirası")
            {
                float flo = f * 28.89F;
                txtDisplay.Text = "₺ " + flo;
            }

            if (comboBoxEdit1.SelectedItem == "Altın" && comboBoxEdit2.SelectedItem == "Türk Lirası")
            {
                float flo = f * 1661.08F;
                txtDisplay.Text = "₺ " + flo;
            }
        }

        
    }
}
