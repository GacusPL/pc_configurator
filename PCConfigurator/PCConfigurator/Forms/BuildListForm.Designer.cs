namespace PCConfigurator
{
    partial class BuildListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildListForm));
            this.btnOpen = new MaterialSkin.Controls.MaterialButton();
            this.dgvBuilds = new System.Windows.Forms.DataGridView();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOpen.Depth = 0;
            this.btnOpen.HighEmphasis = true;
            this.btnOpen.Icon = null;
            this.btnOpen.Location = new System.Drawing.Point(408, 384);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOpen.Size = new System.Drawing.Size(82, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Otwórz";
            this.btnOpen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOpen.UseAccentColor = false;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dgvBuilds
            // 
            this.dgvBuilds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilds.Location = new System.Drawing.Point(6, 67);
            this.dgvBuilds.Name = "dgvBuilds";
            this.dgvBuilds.Size = new System.Drawing.Size(484, 247);
            this.dgvBuilds.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(306, 384);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(64, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BuildListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvBuilds);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista zapisanych komputerów";
            this.Load += new System.EventHandler(this.BuildListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnOpen;
        private System.Windows.Forms.DataGridView dgvBuilds;
        private MaterialSkin.Controls.MaterialButton btnDelete;
    }
}