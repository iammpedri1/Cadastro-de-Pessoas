namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSalvar.Click += BtnSalvar_Click;
            btnLimpar.Click += BtnLimpar_Click;
            btnCancelar.Click += BtnCancelar_Click;
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "Cadastro realizado com sucesso!",
                "Salvar cadastro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnLimpar_Click(object? sender, EventArgs e)
        {
            txtNome.Clear();
            txtRG.Clear();
            txtCPF.Clear();
            txtCNH.Clear();
            txtCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();

            dtpNascimento.Value = DateTime.Today;
            mcalConsulta.SetDate(DateTime.Today);
            dtpHorarioConsulta.Value = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
            picFoto.Image = null;
        }

        private void BtnCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void pnlAcoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
