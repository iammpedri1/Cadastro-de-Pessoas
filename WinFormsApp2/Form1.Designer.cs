namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Label lblTitulo;
        private GroupBox grpIdentificacao;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblRG;
        private TextBox txtRG;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblCNH;
        private TextBox txtCNH;
        private Label lblNascimento;
        private DateTimePicker dtpNascimento;
        private GroupBox grpContato;
        private Label lblCEP;
        private TextBox txtCEP;
        private Button btnBuscarCEP;
        private Label lblLogradouro;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox txtCidade;
        private Label lblEstado;
        private TextBox txtEstado;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private GroupBox grpFoto;
        private PictureBox picFoto;
        private Button btnSelecionarFoto;
        private GroupBox grpAgendamento;
        private Label lblDataConsulta;
        private MonthCalendar mcalConsulta;
        private Label lblHorarioConsulta;
        private DateTimePicker dtpHorarioConsulta;
        private Button btnAgendar;
        private Panel pnlAcoes;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpIdentificacao = new GroupBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblRG = new Label();
            txtRG = new TextBox();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblCNH = new Label();
            txtCNH = new TextBox();
            lblNascimento = new Label();
            dtpNascimento = new DateTimePicker();
            grpContato = new GroupBox();
            lblCEP = new Label();
            txtCEP = new TextBox();
            btnBuscarCEP = new Button();
            lblLogradouro = new Label();
            txtLogradouro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblEstado = new Label();
            txtEstado = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            grpFoto = new GroupBox();
            picFoto = new PictureBox();
            btnSelecionarFoto = new Button();
            grpAgendamento = new GroupBox();
            lblDataConsulta = new Label();
            mcalConsulta = new MonthCalendar();
            lblHorarioConsulta = new Label();
            dtpHorarioConsulta = new DateTimePicker();
            btnAgendar = new Button();
            pnlAcoes = new Panel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            grpIdentificacao.SuspendLayout();
            grpContato.SuspendLayout();
            grpFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            grpAgendamento.SuspendLayout();
            pnlAcoes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(31, 78, 121);
            lblTitulo.Location = new Point(28, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Pessoas";
            // 
            // grpIdentificacao
            // 
            grpIdentificacao.BackColor = Color.FromArgb(245, 247, 250);
            grpIdentificacao.Controls.Add(lblNome);
            grpIdentificacao.Controls.Add(txtNome);
            grpIdentificacao.Controls.Add(lblRG);
            grpIdentificacao.Controls.Add(txtRG);
            grpIdentificacao.Controls.Add(lblCPF);
            grpIdentificacao.Controls.Add(txtCPF);
            grpIdentificacao.Controls.Add(lblCNH);
            grpIdentificacao.Controls.Add(txtCNH);
            grpIdentificacao.Controls.Add(lblNascimento);
            grpIdentificacao.Controls.Add(dtpNascimento);
            grpIdentificacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpIdentificacao.ForeColor = Color.FromArgb(45, 55, 72);
            grpIdentificacao.Location = new Point(28, 70);
            grpIdentificacao.Name = "grpIdentificacao";
            grpIdentificacao.Padding = new Padding(12, 20, 12, 12);
            grpIdentificacao.Size = new Size(570, 190);
            grpIdentificacao.TabIndex = 1;
            grpIdentificacao.TabStop = false;
            grpIdentificacao.Text = "Identificação";
            grpIdentificacao.Enter += grpIdentificacao_Enter;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(75, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 1;
            // 
            // lblRG
            // 
            lblRG.Location = new Point(20, 70);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(32, 23);
            lblRG.TabIndex = 2;
            lblRG.Text = "RG:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(75, 67);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(180, 23);
            txtRG.TabIndex = 3;
            // 
            // lblCPF
            // 
            lblCPF.Location = new Point(20, 110);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(32, 23);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(75, 110);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(180, 23);
            txtCPF.TabIndex = 5;
            // 
            // lblCNH
            // 
            lblCNH.Location = new Point(324, 24);
            lblCNH.Name = "lblCNH";
            lblCNH.Size = new Size(46, 23);
            lblCNH.TabIndex = 6;
            lblCNH.Text = "CNH:";
            // 
            // txtCNH
            // 
            txtCNH.Location = new Point(376, 24);
            txtCNH.Name = "txtCNH";
            txtCNH.Size = new Size(120, 23);
            txtCNH.TabIndex = 7;
            txtCNH.TextChanged += txtCNH_TextChanged;
            // 
            // lblNascimento
            // 
            lblNascimento.Location = new Point(324, 56);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(81, 23);
            lblNascimento.TabIndex = 8;
            lblNascimento.Text = "Nascimento:";
            // 
            // dtpNascimento
            // 
            dtpNascimento.CalendarForeColor = Color.FromArgb(31, 41, 55);
            dtpNascimento.CalendarMonthBackground = Color.White;
            dtpNascimento.Font = new Font("Segoe UI", 9F);
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(411, 56);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(100, 23);
            dtpNascimento.TabIndex = 9;
            dtpNascimento.ValueChanged += dtpNascimento_ValueChanged;
            // 
            // grpContato
            // 
            grpContato.BackColor = Color.FromArgb(245, 247, 250);
            grpContato.Controls.Add(lblCEP);
            grpContato.Controls.Add(txtCEP);
            grpContato.Controls.Add(btnBuscarCEP);
            grpContato.Controls.Add(lblLogradouro);
            grpContato.Controls.Add(txtLogradouro);
            grpContato.Controls.Add(lblNumero);
            grpContato.Controls.Add(txtNumero);
            grpContato.Controls.Add(lblComplemento);
            grpContato.Controls.Add(txtComplemento);
            grpContato.Controls.Add(lblBairro);
            grpContato.Controls.Add(txtBairro);
            grpContato.Controls.Add(lblCidade);
            grpContato.Controls.Add(txtCidade);
            grpContato.Controls.Add(lblEstado);
            grpContato.Controls.Add(txtEstado);
            grpContato.Controls.Add(lblEmail);
            grpContato.Controls.Add(txtEmail);
            grpContato.Controls.Add(lblTelefone);
            grpContato.Controls.Add(txtTelefone);
            grpContato.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpContato.ForeColor = Color.FromArgb(45, 55, 72);
            grpContato.Location = new Point(28, 275);
            grpContato.Name = "grpContato";
            grpContato.Padding = new Padding(12, 20, 12, 12);
            grpContato.Size = new Size(570, 365);
            grpContato.TabIndex = 2;
            grpContato.TabStop = false;
            grpContato.Text = "Contato e endereço";
            grpContato.Enter += grpContato_Enter;
            // 
            // lblCEP
            // 
            lblCEP.Location = new Point(20, 30);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(90, 23);
            lblCEP.TabIndex = 0;
            lblCEP.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(120, 30);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(120, 23);
            txtCEP.TabIndex = 1;
            // 
            // btnBuscarCEP
            // 
            btnBuscarCEP.Location = new Point(250, 27);
            btnBuscarCEP.Name = "btnBuscarCEP";
            btnBuscarCEP.Size = new Size(90, 30);
            btnBuscarCEP.TabIndex = 2;
            btnBuscarCEP.Text = "Buscar";
            // 
            // lblLogradouro
            // 
            lblLogradouro.Location = new Point(20, 70);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(90, 23);
            lblLogradouro.TabIndex = 3;
            lblLogradouro.Text = "Logradouro:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(120, 70);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(300, 23);
            txtLogradouro.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(20, 110);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(90, 23);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(120, 110);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // lblComplemento
            // 
            lblComplemento.Location = new Point(250, 110);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(100, 23);
            lblComplemento.TabIndex = 7;
            lblComplemento.Text = "Complemento:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(355, 110);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(185, 23);
            txtComplemento.TabIndex = 8;
            // 
            // lblBairro
            // 
            lblBairro.Location = new Point(20, 150);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(90, 23);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(120, 150);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(300, 23);
            txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            lblCidade.Location = new Point(20, 190);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(90, 23);
            lblCidade.TabIndex = 11;
            lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(120, 190);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(220, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(355, 190);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(60, 23);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(420, 190);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(120, 23);
            txtEstado.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 23);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 16;
            // 
            // lblTelefone
            // 
            lblTelefone.Location = new Point(20, 270);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(90, 23);
            lblTelefone.TabIndex = 17;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(120, 270);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(180, 23);
            txtTelefone.TabIndex = 18;
            // 
            // grpFoto
            // 
            grpFoto.BackColor = Color.FromArgb(245, 247, 250);
            grpFoto.Controls.Add(picFoto);
            grpFoto.Controls.Add(btnSelecionarFoto);
            grpFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFoto.ForeColor = Color.FromArgb(45, 55, 72);
            grpFoto.Location = new Point(620, 70);
            grpFoto.Name = "grpFoto";
            grpFoto.Padding = new Padding(12, 20, 12, 12);
            grpFoto.Size = new Size(250, 300);
            grpFoto.TabIndex = 3;
            grpFoto.TabStop = false;
            grpFoto.Text = "Foto do usuário";
            // 
            // picFoto
            // 
            picFoto.BackColor = Color.FromArgb(240, 243, 247);
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(25, 35);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(200, 200);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            // 
            // btnSelecionarFoto
            // 
            btnSelecionarFoto.BackColor = Color.FromArgb(51, 86, 125);
            btnSelecionarFoto.FlatStyle = FlatStyle.Flat;
            btnSelecionarFoto.ForeColor = Color.White;
            btnSelecionarFoto.Location = new Point(55, 250);
            btnSelecionarFoto.Name = "btnSelecionarFoto";
            btnSelecionarFoto.Size = new Size(140, 30);
            btnSelecionarFoto.TabIndex = 1;
            btnSelecionarFoto.Text = "Selecionar foto";
            btnSelecionarFoto.UseVisualStyleBackColor = false;
            // 
            // grpAgendamento
            // 
            grpAgendamento.BackColor = Color.FromArgb(245, 247, 250);
            grpAgendamento.Controls.Add(lblDataConsulta);
            grpAgendamento.Controls.Add(mcalConsulta);
            grpAgendamento.Controls.Add(lblHorarioConsulta);
            grpAgendamento.Controls.Add(dtpHorarioConsulta);
            grpAgendamento.Controls.Add(btnAgendar);
            grpAgendamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAgendamento.ForeColor = Color.FromArgb(45, 55, 72);
            grpAgendamento.Location = new Point(895, 20);
            grpAgendamento.Name = "grpAgendamento";
            grpAgendamento.Padding = new Padding(12, 20, 12, 12);
            grpAgendamento.Size = new Size(275, 570);
            grpAgendamento.TabIndex = 4;
            grpAgendamento.TabStop = false;
            grpAgendamento.Text = "Agendamento de consulta";
            // 
            // lblDataConsulta
            // 
            lblDataConsulta.Location = new Point(20, 30);
            lblDataConsulta.Name = "lblDataConsulta";
            lblDataConsulta.Size = new Size(180, 23);
            lblDataConsulta.TabIndex = 0;
            lblDataConsulta.Text = "Data da consulta:";
            // 
            // mcalConsulta
            // 
            mcalConsulta.BackColor = Color.White;
            mcalConsulta.Font = new Font("Segoe UI", 9F);
            mcalConsulta.Location = new Point(20, 62);
            mcalConsulta.Name = "mcalConsulta";
            mcalConsulta.TabIndex = 0;
            // 
            // lblHorarioConsulta
            // 
            lblHorarioConsulta.Location = new Point(109, 235);
            lblHorarioConsulta.Name = "lblHorarioConsulta";
            lblHorarioConsulta.Size = new Size(55, 20);
            lblHorarioConsulta.TabIndex = 1;
            lblHorarioConsulta.Text = "Horário:";
            // 
            // dtpHorarioConsulta
            // 
            dtpHorarioConsulta.CalendarForeColor = Color.FromArgb(31, 41, 55);
            dtpHorarioConsulta.CalendarMonthBackground = Color.White;
            dtpHorarioConsulta.Font = new Font("Segoe UI", 9F);
            dtpHorarioConsulta.Format = DateTimePickerFormat.Time;
            dtpHorarioConsulta.Location = new Point(61, 269);
            dtpHorarioConsulta.Name = "dtpHorarioConsulta";
            dtpHorarioConsulta.ShowUpDown = true;
            dtpHorarioConsulta.Size = new Size(139, 23);
            dtpHorarioConsulta.TabIndex = 2;
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = Color.FromArgb(51, 86, 125);
            btnAgendar.FlatStyle = FlatStyle.Flat;
            btnAgendar.ForeColor = Color.White;
            btnAgendar.Location = new Point(80, 347);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(120, 30);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            // 
            // pnlAcoes
            // 
            pnlAcoes.BackColor = Color.FromArgb(190, 198, 210);
            pnlAcoes.Controls.Add(btnSalvar);
            pnlAcoes.Controls.Add(btnLimpar);
            pnlAcoes.Controls.Add(btnCancelar);
            pnlAcoes.Location = new Point(28, 660);
            pnlAcoes.Name = "pnlAcoes";
            pnlAcoes.Size = new Size(1142, 65);
            pnlAcoes.TabIndex = 5;
            pnlAcoes.Paint += pnlAcoes_Paint;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(51, 86, 125);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(411, 17);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(51, 86, 125);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.Location = new Point(521, 17);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(100, 30);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(51, 86, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(631, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 229, 235);
            ClientSize = new Size(1200, 750);
            Controls.Add(lblTitulo);
            Controls.Add(grpIdentificacao);
            Controls.Add(grpContato);
            Controls.Add(grpFoto);
            Controls.Add(grpAgendamento);
            Controls.Add(pnlAcoes);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.FromArgb(45, 55, 72);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pessoas";
            grpIdentificacao.ResumeLayout(false);
            grpIdentificacao.PerformLayout();
            grpContato.ResumeLayout(false);
            grpContato.PerformLayout();
            grpFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            grpAgendamento.ResumeLayout(false);
            pnlAcoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
