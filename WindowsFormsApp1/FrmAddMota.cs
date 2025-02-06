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
    public partial class FrmAddMota : Form
    {
        public Mota mota { get; private set; }
        public FrmAddMota(Mota _mota)
        {
            InitializeComponent();
            
            mota = _mota;

            if(mota!=null)
            {
                Text = "Ver/Editar Mota";
                chk_Editar.Enabled = true;
                chk_Editar.Checked = false;
                updateChkEditar(false);
            }
            else
            {
                Text = "Nova Mota";
                chk_Editar.Enabled = false;
                chk_Editar.Checked = true;
                updateChkEditar(true);
            }

            AcceptButton = btn_Confirmar;
            CancelButton = btn_Cancelar;

            btn_Cancelar.CausesValidation = false;

            btn_Cancelar.DialogResult = DialogResult.Cancel;
            btn_Confirmar.DialogResult = DialogResult.OK;

            cmbMarca.DataSource = Mota.marcaMota;
            cmbCor.DataSource = Mota.corMota;
            cmbEstado.DataSource = Mota.estadoMota;
            cmbCombustivel.DataSource = Mota.combustivelMota;
            cmbEstilo.DataSource = Mota.estiloMota;
        }

        private void updateChkEditar(bool chk)
        {
            cmbCor.Enabled = chk;

            // Enabled de todos as TextBox do formulário
            foreach (Control c in Controls)
                if (c is TextBox)
                    c.Enabled = chk;
            foreach (Control c in Controls)
                if (c is ComboBox)
                    c.Enabled = chk;

            // O ID é de numeração automática. Não pode ter permissão para o editar
            txtID.Enabled = false;
        }


        private void FrmAddMota_Load(object sender, EventArgs e)
        {
            if (mota != null)
            {
                txtID.Text = mota.ValorID.ToString();
            }
        }

        private void updateDataMota()
        {
            if (mota == null) return;

            mota.Marca = cmbMarca.Text;
            mota.Cor = cmbCor.Text;
            mota.Kms = txtKms.Text;
            mota.Estilo = cmbEstilo.Text;
            mota.Estado = cmbEstado.Text;
            mota.Matricula = txt_matricula.Text;
            mota.CC = txtCC.Text;
            mota.Chassis = txt_chassi.Text;
            mota.Preco = txtPreco.Text;
            mota.Modelo = txt_modelo.Text;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Deseja cancelar?", Infos.nomeApp + " " + Infos.versApp, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancel == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }
            if (mota == null)
            {
                mota = new Mota(cmbMarca.Text, txt_modelo.Text, cmbEstilo.Text, txtKms.Text, txt_matricula.Text,
                    txtCC.Text, txtPreco.Text, cmbEstado.Text, cmbCor.Text, txt_chassi.Text);
            }
            updateDataMota();
        }
    }
}
