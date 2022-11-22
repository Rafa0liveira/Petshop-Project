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
    public partial class frmCadcliente : Form
    {
        public frmCadcliente()
        {
            InitializeComponent();
        }

        private void frmCadcliente_Load(object sender, EventArgs e)
        {

        }

        private void btnsavecad_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the customer's name!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtName.Focus();

            }else if (txtaddr.Text == "")
            {
                MessageBox.Show("Please enter the customer's address!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtaddr.Focus();

            }else if (txtbreed.Text == "")
            {
                MessageBox.Show("Please enter the pet's breed!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtbreed.Focus();

            }else if (txtemail.Text == "")
            {
                MessageBox.Show("Please enter the customer's email address!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtemail.Focus();

            }else if (txtpetname.Text == "")
            {
                MessageBox.Show("Please enter the pet's name!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtpetname.Focus();

            }else if (txtphone.Text == "")
            {
                MessageBox.Show("Please enter the customer's phone number!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtphone.Focus();

            }else if (cmboxanimal.Text == "")
            {
                MessageBox.Show("Please select wether your pet is a dog or a cat!", "Petshop", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                cmboxanimal.Focus();

            }

            else if (MessageBox.Show("Save new customer?", "Petshop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("New customer saved successfully!", "Petshop", MessageBoxButtons.OK);
                txtName.Text = "";
                txtaddr.Text = "";
                txtbreed.Text = "";
                txtemail.Text = "";
                txtpetname.Text = "";
                txtphone.Text = "";
                cmboxanimal.Text = "";

            }
        }

        private void btnclearCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to erase everything?", "Petshop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtName.Text = "";
                txtaddr.Text = "";
                txtbreed.Text = "";
                txtemail.Text = "";
                txtpetname.Text = "";
                txtphone.Text = "";
                cmboxanimal.Text = "";
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboxanimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
