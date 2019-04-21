using AgendaADONET.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaADONET
{
    public partial class frm_Agenda : Form
    {
        public frm_Agenda()
        {
            InitializeComponent();
        }

        private void Frm_Agenda_Load(object sender, EventArgs e)
        {
            CarregarDGV();
        }
        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_Agenda.CurrentRow.Cells[0].Value;
            ContatoCRUD contatoExcluir = new ContatoCRUD();
            contatoExcluir.Excluir(id);

            CarregarDGV();
        }
        private void CarregarDGV()
        {
            ContatoCRUD contatoReader = new ContatoCRUD();
            dgv_Agenda.DataSource = contatoReader.GetContatos();

            dgv_Agenda.Refresh();
        }
    }
}
