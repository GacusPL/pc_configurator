using MaterialSkin;
using MaterialSkin.Controls;
using PCConfigurator;
using PCConfigurator.Controllers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PCConfigurator
{
    public partial class ConfiguratorForm : MaterialForm
    {
        private BuildController _controller = new BuildController();

        public ConfiguratorForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.BLACK);
            UpdateView();
        }

        private void OpenSelector(string type, string socketFilter = null)
        {
            using (var form = new PartSelectorForm(_controller, type, socketFilter))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.AddPart(form.SelectedId);
                    UpdateView();
                }
            }
        }


        public void LoadBuildFromHistory(string componentIds, string buildName)
        {
            _controller.LoadFromIdsString(componentIds);
            this.Text = $"Edycja zestawu: {buildName}";

            UpdateView();

        }

        //obsługa buttonow
        private void btnCpu_Click(object sender, EventArgs e)
        {
            OpenSelector("CPU");
        }

        private void btnMobo_Click(object sender, EventArgs e)
        {
            string currentSocket = _controller.GetCurrentSocket();

            if (currentSocket == null)
            {
                MessageBox.Show("Najpierw wybierz procesor, żeby dopasować płytę!");
                return;
            }

            OpenSelector("MOBO", currentSocket);
        }

        private void btnRam_Click(object sender, EventArgs e) => OpenSelector("RAM");
        private void btnGpu_Click(object sender, EventArgs e) => OpenSelector("GPU");
        private void btnPsu_Click(object sender, EventArgs e) => OpenSelector("PSU");

        private void btnSaveDb_Click(object sender, EventArgs e)
        {
            using (var form = new SaveBuildForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _controller.SaveBuildToDb(form.BuildName);
                    MessageBox.Show("Zestaw zapisany w bazie!");
                }
            }
        }

        private void UpdateView()
        {
            lblCpu.Text = _controller.GetSelectedPartName("CPU");
            lblMobo.Text = _controller.GetSelectedPartName("MOBO");
            lblRam.Text = _controller.GetSelectedPartName("RAM");
            lblGpu.Text = _controller.GetSelectedPartName("GPU");
            lblPsu.Text = _controller.GetSelectedPartName("PSU");

            LoadImageToPb(pbCpu, "CPU");
            LoadImageToPb(pbMobo, "MOBO");
            LoadImageToPb(pbRam, "RAM");
            LoadImageToPb(pbGpu, "GPU");
            LoadImageToPb(pbPsu, "PSU");

            var status = _controller.Validate();
            lblPrice.Text = $"Cena: {status.TotalPrice:C}";
            lblWattage.Text = $"Moc: {status.TotalWattage} W";

            if (!status.IsValid)
            {
                lblError.Text = status.ErrorMessage;
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblError.Text = "Status: Zestaw Kompatybilny";
                lblError.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void LoadImageToPb(PictureBox pb, string type)
        {
            string url = _controller.GetSelectedPartImage(type);

            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    pb.Load(url);
                }
                catch
                {
                    pb.Image = null;
                }
            }
            else
            {
                pb.Image = null;
            }
        }
    }
}