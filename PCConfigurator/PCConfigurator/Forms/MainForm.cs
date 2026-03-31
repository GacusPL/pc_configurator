using MaterialSkin.Controls;
using System;

namespace PCConfigurator
{
    public partial class MenuForm : MaterialForm
    {
        public MenuForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
            MaterialSkin.MaterialSkinManager.Instance.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }

        private void btnNewBuild_Click(object sender, EventArgs e)
        {
            ConfiguratorForm configForm = new ConfiguratorForm();
            configForm.Show();
            this.Hide();

            configForm.FormClosed += (s, args) => this.Show();
        }

        private void btnLoadBuild_Click(object sender, EventArgs e)
        {
            BuildListForm listForm = new BuildListForm();
            listForm.ShowDialog();
        }
    }
}