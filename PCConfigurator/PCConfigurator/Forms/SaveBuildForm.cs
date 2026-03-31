using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PCConfigurator
{
    public partial class SaveBuildForm : MaterialForm
    {
        public string BuildName { get; private set; }

        public SaveBuildForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Podaj nazwę!");
                return;
            }

            BuildName = txtName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}