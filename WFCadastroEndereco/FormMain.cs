using TN01_WFCadastroEndereco;

namespace WFCadastroEndereco
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroEndereco form = new FormCadastroEndereco();
            form.ShowDialog();
        }
    }
}
