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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Petshop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCadcliente cliente = new frmCadcliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear(); 
            PanelCenter.Controls.Add(cliente); 
            cliente.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PanelCenter.Controls.Clear();
        }


        
        private void btnServiços_Click(object sender, EventArgs e)
        {

            frnCadservicos servicos = new frnCadservicos();
            servicos.TopLevel = false;
            servicos.Dock = DockStyle.Fill;
            PanelCenter.Controls.Clear(); 
            PanelCenter.Controls.Add(servicos); 
            servicos.Show();
        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
