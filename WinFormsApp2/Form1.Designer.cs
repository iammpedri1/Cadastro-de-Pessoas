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

            ConfigureLabel(lblNome, "Nome:", 20, 30, 90);
            ConfigureTextBox(txtNome, "txtNome", 120, 30, 180);
            ConfigureLabel(lblRG, "RG:", 20, 70, 90);
            ConfigureTextBox(txtRG, "txtRG", 120, 70, 180);
            ConfigureLabel(lblCPF, "CPF:", 20, 110, 90);
            ConfigureTextBox(txtCPF, "txtCPF", 120, 110, 180);
            ConfigureLabel(lblCNH, "CNH:", 320, 30, 90);
            ConfigureTextBox(txtCNH, "txtCNH", 420, 30, 120);
            ConfigureLabel(lblNascimento, "Nascimento:", 320, 70, 90);

            ConfigureLabel(lblCEP, "CEP:", 20, 30, 90);
            ConfigureTextBox(txtCEP, "txtCEP", 120, 30, 120);
            ConfigureButton(btnBuscarCEP, "Buscar", "btnBuscarCEP", 250, 27, 90);
            ConfigureLabel(lblLogradouro, "Logradouro:", 20, 70, 90);
            ConfigureTextBox(txtLogradouro, "txtLogradouro", 120, 70, 300);
            ConfigureLabel(lblNumero, "Número:", 20, 110, 90);
            ConfigureTextBox(txtNumero, "txtNumero", 120, 110, 100);
            ConfigureLabel(lblComplemento, "Complemento:", 250, 110, 100);
            ConfigureTextBox(txtComplemento, "txtComplemento", 355, 110, 185);
            ConfigureLabel(lblBairro, "Bairro:", 20, 150, 90);
            ConfigureTextBox(txtBairro, "txtBairro", 120, 150, 300);
            ConfigureLabel(lblCidade, "Cidade:", 20, 190, 90);
            ConfigureTextBox(txtCidade, "txtCidade", 120, 190, 220);
            ConfigureLabel(lblEstado, "Estado:", 355, 190, 60);
            ConfigureTextBox(txtEstado, "txtEstado", 420, 190, 120);
            ConfigureLabel(lblEmail, "E-mail:", 20, 230, 90);
            ConfigureTextBox(txtEmail, "txtEmail", 120, 230, 300);
            ConfigureLabel(lblTelefone, "Telefone:", 20, 270, 90);
            ConfigureTextBox(txtTelefone, "txtTelefone", 120, 270, 180);

            ConfigureButton(btnSelecionarFoto, "Selecionar foto", "btnSelecionarFoto", 55, 250, 140);
            ConfigureLabel(lblDataConsulta, "Data da consulta:", 20, 30, 180);
            ConfigureLabel(lblHorarioConsulta, "Horário:", 20, 295, 90);
            ConfigureButton(btnAgendar, "Agendar", "btnAgendar", 20, 340, 120);
            ConfigureButton(btnSalvar, "Salvar", "btnSalvar", 790, 17, 100);
            ConfigureButton(btnLimpar, "Limpar", "btnLimpar", 900, 17, 100);
            ConfigureButton(btnCancelar, "Cancelar", "btnCancelar", 1010, 17, 100);

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
            grpIdentificacao.BackColor = Color.White;
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
            grpIdentificacao.Location = new Point(28, 70);
            grpIdentificacao.Name = "grpIdentificacao";
            grpIdentificacao.Size = new Size(570, 190);
            grpIdentificacao.TabIndex = 1;
            grpIdentificacao.TabStop = false;
            grpIdentificacao.Text = "Identificação";
            // 
            // lblNome
            // 
            lblNome.Location = new Point(0, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(0, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // lblRG
            // 
            lblRG.Location = new Point(0, 0);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(100, 23);
            lblRG.TabIndex = 2;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(0, 0);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(100, 23);
            txtRG.TabIndex = 3;
            // 
            // lblCPF
            // 
            lblCPF.Location = new Point(0, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(100, 23);
            lblCPF.TabIndex = 4;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(0, 0);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 5;
            // 
            // lblCNH
            // 
            lblCNH.Location = new Point(0, 0);
            lblCNH.Name = "lblCNH";
            lblCNH.Size = new Size(100, 23);
            lblCNH.TabIndex = 6;
            // 
            // txtCNH
            // 
            txtCNH.Location = new Point(0, 0);
            txtCNH.Name = "txtCNH";
            txtCNH.Size = new Size(100, 23);
            txtCNH.TabIndex = 7;
            // 
            // lblNascimento
            // 
            lblNascimento.Location = new Point(0, 0);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(100, 23);
            lblNascimento.TabIndex = 8;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(438, 114);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(100, 23);
            dtpNascimento.TabIndex = 9;
            // 
            // grpContato
            // 
            grpContato.BackColor = Color.White;
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
            grpContato.Location = new Point(28, 275);
            grpContato.Name = "grpContato";
            grpContato.Size = new Size(570, 365);
            grpContato.TabIndex = 2;
            grpContato.TabStop = false;
            grpContato.Text = "Contato e endereço";
            // 
            // lblCEP
            // 
            lblCEP.Location = new Point(0, 0);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(100, 23);
            lblCEP.TabIndex = 0;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(0, 0);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(100, 23);
            txtCEP.TabIndex = 1;
            // 
            // btnBuscarCEP
            // 
            btnBuscarCEP.Location = new Point(0, 0);
            btnBuscarCEP.Name = "btnBuscarCEP";
            btnBuscarCEP.Size = new Size(75, 23);
            btnBuscarCEP.TabIndex = 2;
            // 
            // lblLogradouro
            // 
            lblLogradouro.Location = new Point(0, 0);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(100, 23);
            lblLogradouro.TabIndex = 3;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(0, 0);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(0, 0);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(100, 23);
            lblNumero.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(0, 0);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // lblComplemento
            // 
            lblComplemento.Location = new Point(0, 0);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(100, 23);
            lblComplemento.TabIndex = 7;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(0, 0);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 8;
            // 
            // lblBairro
            // 
            lblBairro.Location = new Point(0, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(100, 23);
            lblBairro.TabIndex = 9;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(0, 0);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(100, 23);
            txtBairro.TabIndex = 10;
            // 
            // lblCidade
            // 
            lblCidade.Location = new Point(0, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(100, 23);
            lblCidade.TabIndex = 11;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(0, 0);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(0, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(100, 23);
            lblEstado.TabIndex = 13;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(0, 0);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(100, 23);
            txtEstado.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(0, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 16;
            // 
            // lblTelefone
            // 
            lblTelefone.Location = new Point(0, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(100, 23);
            lblTelefone.TabIndex = 17;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(0, 0);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 18;
            // 
            // grpFoto
            // 
            grpFoto.BackColor = Color.White;
            grpFoto.Controls.Add(picFoto);
            grpFoto.Controls.Add(btnSelecionarFoto);
            grpFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpFoto.Location = new Point(620, 70);
            grpFoto.Name = "grpFoto";
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
            btnSelecionarFoto.Location = new Point(0, 0);
            btnSelecionarFoto.Name = "btnSelecionarFoto";
            btnSelecionarFoto.Size = new Size(75, 23);
            btnSelecionarFoto.TabIndex = 1;
            // 
            // grpAgendamento
            // 
            grpAgendamento.BackColor = Color.White;
            grpAgendamento.Controls.Add(lblDataConsulta);
            grpAgendamento.Controls.Add(mcalConsulta);
            grpAgendamento.Controls.Add(lblHorarioConsulta);
            grpAgendamento.Controls.Add(dtpHorarioConsulta);
            grpAgendamento.Controls.Add(btnAgendar);
            grpAgendamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpAgendamento.Location = new Point(895, 70);
            grpAgendamento.Name = "grpAgendamento";
            grpAgendamento.Size = new Size(275, 570);
            grpAgendamento.TabIndex = 4;
            grpAgendamento.TabStop = false;
            grpAgendamento.Text = "Agendamento de consulta";
            // 
            // lblDataConsulta
            // 
            lblDataConsulta.Location = new Point(6, 0);
            lblDataConsulta.Name = "lblDataConsulta";
            lblDataConsulta.Size = new Size(100, 23);
            lblDataConsulta.TabIndex = 0;
            // 
            // mcalConsulta
            // 
            mcalConsulta.Location = new Point(20, 62);
            mcalConsulta.Name = "mcalConsulta";
            mcalConsulta.TabIndex = 0;
            // 
            // lblHorarioConsulta
            // 
            lblHorarioConsulta.Location = new Point(0, 0);
            lblHorarioConsulta.Name = "lblHorarioConsulta";
            lblHorarioConsulta.Size = new Size(100, 23);
            lblHorarioConsulta.TabIndex = 1;
            // 
            // dtpHorarioConsulta
            // 
            dtpHorarioConsulta.Format = DateTimePickerFormat.Time;
            dtpHorarioConsulta.Location = new Point(20, 298);
            dtpHorarioConsulta.Name = "dtpHorarioConsulta";
            dtpHorarioConsulta.ShowUpDown = true;
            dtpHorarioConsulta.Size = new Size(120, 23);
            dtpHorarioConsulta.TabIndex = 2;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(0, 0);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 23);
            btnAgendar.TabIndex = 3;
            // 
            // pnlAcoes
            // 
            pnlAcoes.BackColor = Color.FromArgb(238, 242, 247);
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
            btnSalvar.Location = new Point(0, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(0, 0);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(0, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;

            ConfigureLabel(lblNome, "Nome:", 20, 30, 90);
            ConfigureTextBox(txtNome, "txtNome", 120, 30, 180);
            ConfigureLabel(lblRG, "RG:", 20, 70, 90);
            ConfigureTextBox(txtRG, "txtRG", 120, 70, 180);
            ConfigureLabel(lblCPF, "CPF:", 20, 110, 90);
            ConfigureTextBox(txtCPF, "txtCPF", 120, 110, 180);
            ConfigureLabel(lblCNH, "CNH:", 320, 30, 90);
            ConfigureTextBox(txtCNH, "txtCNH", 420, 30, 120);
            ConfigureLabel(lblNascimento, "Nascimento:", 320, 70, 90);
            ConfigureLabel(lblCEP, "CEP:", 20, 30, 90);
            ConfigureTextBox(txtCEP, "txtCEP", 120, 30, 120);
            ConfigureButton(btnBuscarCEP, "Buscar", "btnBuscarCEP", 250, 27, 90);
            ConfigureLabel(lblLogradouro, "Logradouro:", 20, 70, 90);
            ConfigureTextBox(txtLogradouro, "txtLogradouro", 120, 70, 300);
            ConfigureLabel(lblNumero, "Número:", 20, 110, 90);
            ConfigureTextBox(txtNumero, "txtNumero", 120, 110, 100);
            ConfigureLabel(lblComplemento, "Complemento:", 250, 110, 100);
            ConfigureTextBox(txtComplemento, "txtComplemento", 355, 110, 185);
            ConfigureLabel(lblBairro, "Bairro:", 20, 150, 90);
            ConfigureTextBox(txtBairro, "txtBairro", 120, 150, 300);
            ConfigureLabel(lblCidade, "Cidade:", 20, 190, 90);
            ConfigureTextBox(txtCidade, "txtCidade", 120, 190, 220);
            ConfigureLabel(lblEstado, "Estado:", 355, 190, 60);
            ConfigureTextBox(txtEstado, "txtEstado", 420, 190, 120);
            ConfigureLabel(lblEmail, "E-mail:", 20, 230, 90);
            ConfigureTextBox(txtEmail, "txtEmail", 120, 230, 300);
            ConfigureLabel(lblTelefone, "Telefone:", 20, 270, 90);
            ConfigureTextBox(txtTelefone, "txtTelefone", 120, 270, 180);
            ConfigureButton(btnSelecionarFoto, "Selecionar foto", "btnSelecionarFoto", 55, 250, 140);
            ConfigureLabel(lblDataConsulta, "Data da consulta:", 20, 30, 180);
            ConfigureLabel(lblHorarioConsulta, "Horário:", 20, 295, 90);
            ConfigureButton(btnAgendar, "Agendar", "btnAgendar", 20, 340, 120);
            ConfigureButton(btnSalvar, "Salvar", "btnSalvar", 790, 17, 100);
            ConfigureButton(btnLimpar, "Limpar", "btnLimpar", 900, 17, 100);
            ConfigureButton(btnCancelar, "Cancelar", "btnCancelar", 1010, 17, 100);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 251);
            ClientSize = new Size(1200, 750);
            Controls.Add(lblTitulo);
            Controls.Add(grpIdentificacao);
            Controls.Add(grpContato);
            Controls.Add(grpFoto);
            Controls.Add(grpAgendamento);
            Controls.Add(pnlAcoes);
            Font = new Font("Segoe UI", 9F);
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

        private static void ConfigureLabel(Label label, string text, int x, int y, int width)
        {
            label.AutoSize = false;
            label.Location = new Point(x, y);
            label.Size = new Size(width, 23);
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleLeft;
        }

        private static void ConfigureTextBox(TextBox textBox, string name, int x, int y, int width)
        {
            textBox.Location = new Point(x, y);
            textBox.Name = name;
            textBox.Size = new Size(width, 23);
        }

        private static void ConfigureButton(Button button, string text, string name, int x, int y, int width)
        {
            button.Location = new Point(x, y);
            button.Name = name;
            button.Size = new Size(width, 30);
            button.Text = text;
            button.UseVisualStyleBackColor = true;
        }
    }
}
