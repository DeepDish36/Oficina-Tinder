using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Infos.nomeApp + " " + Infos.versApp;
            
            // Aplica a seleção para toda a linha
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Desativar a seleção múltipla de linhas
            dgvDados.MultiSelect = false;
            // Esconder o cabeçalho de linha
            dgvDados.RowHeadersVisible = false;
            // Aplicar a DataGridView apenas de leitura.
            // Não permite a edição das células.
            // Comos as propriedacdes ValorID, NomeAbreviado, LOcalidade e Cargo
            // são propriedades somente de leitura (get) não faria sentido permitir a escrita na DataGridView
            dgvDados.ReadOnly = true;
            // Não tem permissão para adicionar uma nova linha
            dgvDados.AllowUserToAddRows = false;
            // Não tem permissão para remover uma linha
            dgvDados.AllowUserToDeleteRows = false;
            // Não permite redimencional a altura das linhas
            dgvDados.AllowUserToResizeRows = false;
            // Não permite redimencional a lkargura das colunas
            dgvDados.AllowUserToResizeColumns = false;

            KeyPreview = true;

            for (int i = 4; i < dgvDados.ColumnCount; i++)
                dgvDados.Columns[i].Visible = false;

            dgvDados.DataSource = Infos.ListaMotas;
        }

        private void tsm_sobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre(); 
            sobre.Show();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            FrmAddMota frmMota = new FrmAddMota(null);
            DialogResult result = frmMota.ShowDialog();
            if (result == DialogResult.OK)
            {
                Infos.ListaMotas.Add(frmMota.mota);
                MessageBox.Show("Mota adicionada com sucesso", Infos.nomeApp + " " + Infos.versApp, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Tem a certeza que quer sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btn_editar.PerformClick();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
               btn_remover.PerformClick();

            else if (e.KeyCode == Keys.Insert)
                btn_novo.PerformClick();

            else if (e.KeyCode == Keys.Enter)
               btn_editar.PerformClick();
        }

        private Mota GetAtualDataRown()
        {
            if (dgvDados.SelectedRows.Count > 0)
                // Aceder aos dados associados à linha selecionada
                // e converter esses dados para Empregado
                return (Mota)dgvDados.CurrentRow.DataBoundItem;
            else
                return null;
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count > 0)
            {
                Mota dados = GetAtualDataRown();
                int i = Infos.ListaMotas.IndexOf(dados);

                if (i < 0)
                {
                    MessageBox.Show("Não foi possível encontrar a mota " + dados.Marca + " " + dados.Modelo,Infos.nomeApp+" "+Infos.versApp,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                string msg = "Deseja remover a mota " + dados.Marca + " " + dados.Modelo + "?";
                DialogResult dlg = MessageBox.Show(msg, Infos.nomeApp + " " + Infos.versApp, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    Infos.ListaMotas.RemoveAt(i);
                    MessageBox.Show("Mota "+dados.Marca + " " + dados.Modelo+" removida com sucesso.", Infos.nomeApp + " " + Infos.versApp, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não existem motas na base de dados.", Infos.nomeApp + " " + Infos.versApp, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgvDados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma moto na lista de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Mota mota = GetAtualDataRown();

        }
    }
}
