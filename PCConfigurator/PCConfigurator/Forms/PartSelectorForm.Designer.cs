namespace PCConfigurator
{
    partial class PartSelectorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartSelectorForm));
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.btnSelect = new MaterialSkin.Controls.MaterialButton();
            this.pbPartPreview = new System.Windows.Forms.PictureBox();
            this.lblSelectedName = new MaterialSkin.Controls.MaterialLabel();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCConfiguratorDBDataSet = new PCConfigurator.PCConfiguratorDBDataSet();
            this.componentsTableAdapter = new PCConfigurator.PCConfiguratorDBDataSetTableAdapters.ComponentsTableAdapter();
            this.pcConfiguratorDBDataSet1 = new PCConfigurator.PCConfiguratorDBDataSet();
            this.pcConfiguratorDBDataSet2 = new PCConfigurator.PCConfiguratorDBDataSet();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCConfiguratorDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConfiguratorDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConfiguratorDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(6, 67);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.Size = new System.Drawing.Size(693, 360);
            this.dgvParts.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelect.Depth = 0;
            this.btnSelect.HighEmphasis = true;
            this.btnSelect.Icon = null;
            this.btnSelect.Location = new System.Drawing.Point(924, 467);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSelect.Size = new System.Drawing.Size(83, 36);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Wybierz";
            this.btnSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelect.UseAccentColor = false;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pbPartPreview
            // 
            this.pbPartPreview.Location = new System.Drawing.Point(756, 90);
            this.pbPartPreview.Name = "pbPartPreview";
            this.pbPartPreview.Size = new System.Drawing.Size(413, 337);
            this.pbPartPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPartPreview.TabIndex = 4;
            this.pbPartPreview.TabStop = false;
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.AutoSize = true;
            this.lblSelectedName.Depth = 0;
            this.lblSelectedName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectedName.Location = new System.Drawing.Point(251, 484);
            this.lblSelectedName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(102, 19);
            this.lblSelectedName.TabIndex = 5;
            this.lblSelectedName.Text = "Wybierz z listy";
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.pCConfiguratorDBDataSet;
            // 
            // pCConfiguratorDBDataSet
            // 
            this.pCConfiguratorDBDataSet.DataSetName = "PCConfiguratorDBDataSet";
            this.pCConfiguratorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentsTableAdapter
            // 
            this.componentsTableAdapter.ClearBeforeFill = true;
            // 
            // pcConfiguratorDBDataSet1
            // 
            this.pcConfiguratorDBDataSet1.DataSetName = "PCConfiguratorDBDataSet";
            this.pcConfiguratorDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pcConfiguratorDBDataSet2
            // 
            this.pcConfiguratorDBDataSet2.DataSetName = "PCConfiguratorDBDataSet";
            this.pcConfiguratorDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(251, 450);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Wybrano:";
            // 
            // PartSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 573);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblSelectedName);
            this.Controls.Add(this.pbPartPreview);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvParts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybierz część";
            this.Load += new System.EventHandler(this.PartSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPartPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCConfiguratorDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConfiguratorDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcConfiguratorDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PCConfiguratorDBDataSet pCConfiguratorDBDataSet;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private PCConfiguratorDBDataSetTableAdapters.ComponentsTableAdapter componentsTableAdapter;
        private PCConfiguratorDBDataSet pcConfiguratorDBDataSet1;
        private PCConfiguratorDBDataSet pcConfiguratorDBDataSet2;
        private System.Windows.Forms.DataGridView dgvParts;
        private MaterialSkin.Controls.MaterialButton btnSelect;
        private System.Windows.Forms.PictureBox pbPartPreview;
        private MaterialSkin.Controls.MaterialLabel lblSelectedName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}