using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DonPdv.pdv.dao;
using DonPdv.pdv.model;

namespace DonPdv.pdv.view
{
    public partial class Frm_cliente : Form
    {
        public Frm_cliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente
            {
                Nome = tbNome.Text,
                Telefone = tbTelefone.Text

            };
            ClienteDAO dao = new ClienteDAO();

            dao.CriarCliente(obj);
        }
    }
}
