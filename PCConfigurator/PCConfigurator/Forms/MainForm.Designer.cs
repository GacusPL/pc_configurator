namespace PCConfigurator
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnNewBuild = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadBuild = new MaterialSkin.Controls.MaterialButton();
            this.materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.SuspendLayout();
            // 
            // btnNewBuild
            // 
            this.btnNewBuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewBuild.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNewBuild.Depth = 0;
            this.btnNewBuild.HighEmphasis = true;
            this.btnNewBuild.Icon = null;
            this.btnNewBuild.Location = new System.Drawing.Point(172, 197);
            this.btnNewBuild.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewBuild.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNewBuild.Name = "btnNewBuild";
            this.btnNewBuild.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNewBuild.Size = new System.Drawing.Size(146, 36);
            this.btnNewBuild.TabIndex = 0;
            this.btnNewBuild.Text = "Nowy komputer";
            this.btnNewBuild.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNewBuild.UseAccentColor = false;
            this.btnNewBuild.UseVisualStyleBackColor = true;
            this.btnNewBuild.Click += new System.EventHandler(this.btnNewBuild_Click);
            // 
            // btnLoadBuild
            // 
            this.btnLoadBuild.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadBuild.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadBuild.Depth = 0;
            this.btnLoadBuild.HighEmphasis = true;
            this.btnLoadBuild.Icon = null;
            this.btnLoadBuild.Location = new System.Drawing.Point(407, 197);
            this.btnLoadBuild.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadBuild.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadBuild.Name = "btnLoadBuild";
            this.btnLoadBuild.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoadBuild.Size = new System.Drawing.Size(183, 36);
            this.btnLoadBuild.TabIndex = 1;
            this.btnLoadBuild.Text = "Przeglądaj zestawy";
            this.btnLoadBuild.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadBuild.UseAccentColor = false;
            this.btnLoadBuild.UseVisualStyleBackColor = true;
            this.btnLoadBuild.Click += new System.EventHandler(this.btnLoadBuild_Click);
            // 
            // materialMaskedTextBox1
            // 
            this.materialMaskedTextBox1.AllowPromptAsInput = true;
            this.materialMaskedTextBox1.AnimateReadOnly = false;
            this.materialMaskedTextBox1.AsciiOnly = false;
            this.materialMaskedTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox1.BeepOnError = false;
            this.materialMaskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.Depth = 0;
            this.materialMaskedTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox1.HidePromptOnLeave = false;
            this.materialMaskedTextBox1.HideSelection = true;
            this.materialMaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox1.LeadingIcon = null;
            this.materialMaskedTextBox1.Location = new System.Drawing.Point(310, 85);
            this.materialMaskedTextBox1.Mask = "";
            this.materialMaskedTextBox1.MaxLength = 32767;
            this.materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            this.materialMaskedTextBox1.PasswordChar = '\0';
            this.materialMaskedTextBox1.PrefixSuffixText = null;
            this.materialMaskedTextBox1.PromptChar = '_';
            this.materialMaskedTextBox1.ReadOnly = false;
            this.materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox1.ResetOnPrompt = true;
            this.materialMaskedTextBox1.ResetOnSpace = true;
            this.materialMaskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox1.SelectedText = "";
            this.materialMaskedTextBox1.SelectionLength = 0;
            this.materialMaskedTextBox1.SelectionStart = 0;
            this.materialMaskedTextBox1.ShortcutsEnabled = true;
            this.materialMaskedTextBox1.Size = new System.Drawing.Size(126, 48);
            this.materialMaskedTextBox1.SkipLiterals = true;
            this.materialMaskedTextBox1.TabIndex = 3;
            this.materialMaskedTextBox1.TabStop = false;
            this.materialMaskedTextBox1.Text = "Menu główne:";
            this.materialMaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox1.TrailingIcon = null;
            this.materialMaskedTextBox1.UseSystemPasswordChar = false;
            this.materialMaskedTextBox1.ValidatingType = null;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialMaskedTextBox1);
            this.Controls.Add(this.btnLoadBuild);
            this.Controls.Add(this.btnNewBuild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfigurator PC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnNewBuild;
        private MaterialSkin.Controls.MaterialButton btnLoadBuild;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
    }
}