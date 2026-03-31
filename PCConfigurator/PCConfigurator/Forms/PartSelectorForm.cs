using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using PCConfigurator.Controllers;

namespace PCConfigurator
{
    public partial class PartSelectorForm : MaterialForm
    {
        private BuildController _controller;
        private string _type;
        private string _socketFilter;
        private string _memoryFilter;

        public int SelectedId { get; private set; } = -1;
        public string SelectedSocket { get; private set; }
        public string SelectedImageUrl { get; private set; }

        public PartSelectorForm(BuildController controller, string type, string socketFilter = null, string memoryFilter = null)
        {
            InitializeComponent();
            _controller = controller;
            _type = type;
            _socketFilter = socketFilter;
            _memoryFilter = memoryFilter;

            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);

            dgvParts.EnableHeadersVisualStyles = false;
            dgvParts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgvParts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvParts.DefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
            dgvParts.DefaultCellStyle.ForeColor = Color.White;
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 100);

            dgvParts.SelectionChanged += DgvParts_SelectionChanged;
        }

        private void PartSelectorForm_Load(object sender, EventArgs e)
        {
            dgvParts.DataSource = null;
            dgvParts.Columns.Clear();
            dgvParts.AutoGenerateColumns = true;

            var parts = _controller.GetParts(_type, _socketFilter, _memoryFilter);
            dgvParts.DataSource = parts;

            ConfigureColumns();
        }

        private void ConfigureColumns()
        {
            //ukrycie id i linku obrazka
            if (dgvParts.Columns["Id"] != null) dgvParts.Columns["Id"].Visible = false;
            if (dgvParts.Columns["ImageUrl"] != null) dgvParts.Columns["ImageUrl"].Visible = false;

            //walidacja
            bool showSocket = (_type == "CPU" || _type == "MOBO");
            bool showWattage = (_type != "MOBO" && _type != "RAM");

            if (dgvParts.Columns["Socket"] != null) dgvParts.Columns["Socket"].Visible = showSocket;
            if (dgvParts.Columns["Wattage"] != null)
            {
                dgvParts.Columns["Wattage"].Visible = showWattage;
                if (_type == "PSU") dgvParts.Columns["Wattage"].HeaderText = "Moc (W)";
                else dgvParts.Columns["Wattage"].HeaderText = "Pobór (W)";
            }
        }

        private void DgvParts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                var item = dgvParts.CurrentRow.DataBoundItem as PartViewModel;
                if (item != null)
                {
                    lblSelectedName.Text = item.Name;

                    if (!string.IsNullOrEmpty(item.ImageUrl))
                    {
                        try
                        {
                            pbPartPreview.Load(item.ImageUrl);
                        }
                        catch
                        {
                            pbPartPreview.Image = null;
                        }
                    }
                    else
                    {
                        pbPartPreview.Image = null;
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                var item = dgvParts.CurrentRow.DataBoundItem as PartViewModel;
                if (item != null)
                {
                    SelectedId = item.Id;
                    SelectedSocket = item.Socket;
                    SelectedImageUrl = item.ImageUrl;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Wybierz element!");
            }
        }
    }
}