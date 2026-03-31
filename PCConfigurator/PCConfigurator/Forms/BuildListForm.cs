using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using PCConfigurator.Controllers;

namespace PCConfigurator
{
    public partial class BuildListForm : MaterialForm
    {
        private BuildListController _controller = new BuildListController();

        public BuildListForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);

            dgvBuilds.EnableHeadersVisualStyles = false;
            dgvBuilds.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dgvBuilds.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvBuilds.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(66, 66, 66);
            dgvBuilds.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
        }

        private void BuildListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            dgvBuilds.DataSource = null;
            dgvBuilds.AutoGenerateColumns = true;

            dgvBuilds.DataSource = _controller.GetAllBuilds();

            if (dgvBuilds.Columns["ComponentIds"] != null)
                dgvBuilds.Columns["ComponentIds"].Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgvBuilds.CurrentRow != null)
            {
                var row = (dgvBuilds.CurrentRow.DataBoundItem as DataRowView).Row as PCConfiguratorDBDataSet.SavedBuildsRow;

                if (row != null)
                {
                    ConfiguratorForm configForm = new ConfiguratorForm();
                    configForm.LoadBuildFromHistory(row.ComponentIds, row.BuildName);
                    configForm.Show();

                    this.Close();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBuilds.CurrentRow != null)
            {
                var row = (dgvBuilds.CurrentRow.DataBoundItem as DataRowView).Row as PCConfiguratorDBDataSet.SavedBuildsRow;

                if (row != null)
                {
                    var result = MessageBox.Show(
                        $"Czy usunąć '{row.BuildName}'?",
                        "Usuwanie",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _controller.DeleteBuild(row.Id);

                            RefreshData();

                            MessageBox.Show("Usunięto.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Błąd: " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}