using System.Windows.Forms;

namespace RSBot.Views.Dialog
{
    public partial class NewProfileFormDialog : Form
    {
        public string Value { get; private set; }

        public NewProfileFormDialog()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_newProfileName.Text.ToString()))
            {
                MessageBox.Show(this, "The value can't be empty!");
                DialogResult = DialogResult.None;
                return;
            }

            Value = txt_newProfileName.Text;

            DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
