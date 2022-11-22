using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PetShop2022
{
    public partial class frnCadservicos : Form
    {
        public frnCadservicos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frnCadservicos_Load(object sender, EventArgs e)
        {

        }

        private void btnsaveser_Click(object sender, EventArgs e)
        {
            if (cmbservices.Text == "")
            {
                MessageBox.Show("Please choose the service.", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cmbservices.Focus();

            }
            else if (cmbpet.Text == "")
            {
                MessageBox.Show("Dog or Cat?!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cmbpet.Focus();

            }
            else if (msktxtdate.Text == "")
            {
                MessageBox.Show("Please choose the date!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                msktxtdate.Focus();

            }
            else if (mskTime.Text == "")
            {
                MessageBox.Show("Please choose the time!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                mskTime.Focus();

            }
            else if (txtticket.Text == "")
            {
                MessageBox.Show("Please generate the booking reference", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtticket.Focus();

            }

            else if (MessageBox.Show("Are you sure you want to save this booking?", "Petshop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Service booked successfully!", "Petshop", MessageBoxButtons.OK);
                cmbservices.Text = "";
                cmbpet.Text = "";
                msktxtdate.Text = "";
                mskTime.Text = "";
                txtticket.Text = "";

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want erase everything?", "Petshop", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                cmbservices.Text = "";
                cmbpet.Text = "";
                msktxtdate.Text = "";
                mskTime.Text = "";
                mskTime.Text = "";
                txtticket.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = 5;

            string PossibleCharacters = "ABCDEFGHIJKLMNOPRSTUVWXYZ" +
                  "ABCDEFGHIJKLMNOPRSTUVWXYZ".ToLower() + "0123456789";

            Random random = new Random();
            int picked = 0;
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < q; i++)
            {
                picked = random.Next(0, PossibleCharacters.Length - 1);
                password.Append(PossibleCharacters[picked]);
            }
            txtticket.Text = password.ToString();

        }
    }
}
