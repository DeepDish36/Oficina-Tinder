namespace WindowsFormsApp1
{
    partial class FrmAddMota
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chk_Editar = new System.Windows.Forms.CheckBox();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.cmbCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_chassi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.grp_Principais = new System.Windows.Forms.GroupBox();
            this.grp_Adicionais = new System.Windows.Forms.GroupBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cmbEstilo = new System.Windows.Forms.ComboBox();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Principais.SuspendLayout();
            this.grp_Adicionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Editar
            // 
            this.chk_Editar.AutoSize = true;
            this.chk_Editar.Location = new System.Drawing.Point(365, 15);
            this.chk_Editar.Name = "chk_Editar";
            this.chk_Editar.Size = new System.Drawing.Size(53, 17);
            this.chk_Editar.TabIndex = 0;
            this.chk_Editar.Text = "Editar";
            this.chk_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(334, 335);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 2;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(253, 335);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(45, 19);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(89, 21);
            this.cmbMarca.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ano (fabrico)";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(75, 60);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(59, 20);
            this.txt_ano.TabIndex = 11;
            // 
            // cmbCor
            // 
            this.cmbCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCor.FormattingEnabled = true;
            this.cmbCor.Location = new System.Drawing.Point(183, 60);
            this.cmbCor.Name = "cmbCor";
            this.cmbCor.Size = new System.Drawing.Size(89, 21);
            this.cmbCor.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(45, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 15;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(183, 20);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(89, 20);
            this.txt_modelo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nº de chassi";
            // 
            // txt_chassi
            // 
            this.txt_chassi.Location = new System.Drawing.Point(75, 104);
            this.txt_chassi.Name = "txt_chassi";
            this.txt_chassi.Size = new System.Drawing.Size(59, 20);
            this.txt_chassi.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Matrícula";
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(200, 104);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(72, 20);
            this.txt_matricula.TabIndex = 20;
            // 
            // grp_Principais
            // 
            this.grp_Principais.Controls.Add(this.cmbMarca);
            this.grp_Principais.Controls.Add(this.txt_matricula);
            this.grp_Principais.Controls.Add(this.label2);
            this.grp_Principais.Controls.Add(this.label7);
            this.grp_Principais.Controls.Add(this.label3);
            this.grp_Principais.Controls.Add(this.txt_chassi);
            this.grp_Principais.Controls.Add(this.label1);
            this.grp_Principais.Controls.Add(this.label6);
            this.grp_Principais.Controls.Add(this.txt_ano);
            this.grp_Principais.Controls.Add(this.txt_modelo);
            this.grp_Principais.Controls.Add(this.label4);
            this.grp_Principais.Controls.Add(this.cmbCor);
            this.grp_Principais.Location = new System.Drawing.Point(12, 10);
            this.grp_Principais.Name = "grp_Principais";
            this.grp_Principais.Size = new System.Drawing.Size(342, 145);
            this.grp_Principais.TabIndex = 21;
            this.grp_Principais.TabStop = false;
            this.grp_Principais.Text = "Campos Principais";
            // 
            // grp_Adicionais
            // 
            this.grp_Adicionais.Controls.Add(this.lblEstilo);
            this.grp_Adicionais.Controls.Add(this.cmbEstilo);
            this.grp_Adicionais.Controls.Add(this.cmbCombustivel);
            this.grp_Adicionais.Controls.Add(this.label12);
            this.grp_Adicionais.Controls.Add(this.txtCC);
            this.grp_Adicionais.Controls.Add(this.label11);
            this.grp_Adicionais.Controls.Add(this.txtPreco);
            this.grp_Adicionais.Controls.Add(this.txtKms);
            this.grp_Adicionais.Controls.Add(this.label10);
            this.grp_Adicionais.Controls.Add(this.cmbEstado);
            this.grp_Adicionais.Controls.Add(this.label9);
            this.grp_Adicionais.Controls.Add(this.label8);
            this.grp_Adicionais.Controls.Add(this.label5);
            this.grp_Adicionais.Controls.Add(this.txtID);
            this.grp_Adicionais.Location = new System.Drawing.Point(12, 174);
            this.grp_Adicionais.Name = "grp_Adicionais";
            this.grp_Adicionais.Size = new System.Drawing.Size(397, 145);
            this.grp_Adicionais.TabIndex = 22;
            this.grp_Adicionais.TabStop = false;
            this.grp_Adicionais.Text = "Campos Adicionais";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(284, 22);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(32, 13);
            this.lblEstilo.TabIndex = 27;
            this.lblEstilo.Text = "Estilo";
            // 
            // cmbEstilo
            // 
            this.cmbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstilo.FormattingEnabled = true;
            this.cmbEstilo.Location = new System.Drawing.Point(322, 17);
            this.cmbEstilo.Name = "cmbEstilo";
            this.cmbEstilo.Size = new System.Drawing.Size(60, 21);
            this.cmbEstilo.TabIndex = 26;
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Location = new System.Drawing.Point(212, 100);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(60, 21);
            this.cmbCombustivel.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Combustível";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(200, 58);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(72, 20);
            this.txtCC.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cilindrada (CC)";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(45, 58);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(51, 20);
            this.txtPreco.TabIndex = 21;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(200, 17);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(72, 20);
            this.txtKms.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Quilometragem";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(48, 100);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(85, 21);
            this.cmbEstado.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Preço";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddMota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 370);
            this.ControlBox = false;
            this.Controls.Add(this.grp_Adicionais);
            this.Controls.Add(this.grp_Principais);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.chk_Editar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddMota";
            this.Text = "FrmAddMota";
            this.Load += new System.EventHandler(this.FrmAddMota_Load);
            this.grp_Principais.ResumeLayout(false);
            this.grp_Principais.PerformLayout();
            this.grp_Adicionais.ResumeLayout(false);
            this.grp_Adicionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Editar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.ComboBox cmbCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_chassi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.GroupBox grp_Principais;
        private System.Windows.Forms.GroupBox grp_Adicionais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cmbEstilo;
    }
}