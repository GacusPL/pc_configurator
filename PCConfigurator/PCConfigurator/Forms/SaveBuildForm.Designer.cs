namespace PCConfigurator
{
    partial class SaveBuildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveBuildForm));
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(293, 276);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(71, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(290, 157);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Nazwa zestawu:";
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.HideSelection = true;
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(293, 199);
            this.txtName.MaxLength = 32767;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PrefixSuffixText = null;
            this.txtName.ReadOnly = false;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(204, 48);
            this.txtName.TabIndex = 5;
            this.txtName.TabStop = false;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TrailingIcon = null;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // SaveBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveBuildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zapisz komputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtName;
    }
}