namespace PCConfigurator
{
    partial class ConfiguratorForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguratorForm));
            this.btnCpu = new MaterialSkin.Controls.MaterialButton();
            this.btnMobo = new MaterialSkin.Controls.MaterialButton();
            this.btnRam = new MaterialSkin.Controls.MaterialButton();
            this.btnGpu = new MaterialSkin.Controls.MaterialButton();
            this.btnPsu = new MaterialSkin.Controls.MaterialButton();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblWattage = new MaterialSkin.Controls.MaterialLabel();
            this.lblError = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveDb = new MaterialSkin.Controls.MaterialButton();
            this.lblCpu = new MaterialSkin.Controls.MaterialLabel();
            this.lblMobo = new MaterialSkin.Controls.MaterialLabel();
            this.lblRam = new MaterialSkin.Controls.MaterialLabel();
            this.lblGpu = new MaterialSkin.Controls.MaterialLabel();
            this.lblPsu = new MaterialSkin.Controls.MaterialLabel();
            this.pbCpu = new System.Windows.Forms.PictureBox();
            this.pbMobo = new System.Windows.Forms.PictureBox();
            this.pbRam = new System.Windows.Forms.PictureBox();
            this.pbGpu = new System.Windows.Forms.PictureBox();
            this.pbPsu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMobo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPsu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCpu
            // 
            this.btnCpu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCpu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCpu.Depth = 0;
            this.btnCpu.HighEmphasis = true;
            this.btnCpu.Icon = null;
            this.btnCpu.Location = new System.Drawing.Point(93, 144);
            this.btnCpu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCpu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCpu.Size = new System.Drawing.Size(162, 36);
            this.btnCpu.TabIndex = 0;
            this.btnCpu.Text = "Wybierz Procesor";
            this.btnCpu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCpu.UseAccentColor = false;
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnMobo
            // 
            this.btnMobo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMobo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMobo.Depth = 0;
            this.btnMobo.HighEmphasis = true;
            this.btnMobo.Icon = null;
            this.btnMobo.Location = new System.Drawing.Point(59, 273);
            this.btnMobo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMobo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMobo.Name = "btnMobo";
            this.btnMobo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMobo.Size = new System.Drawing.Size(196, 36);
            this.btnMobo.TabIndex = 1;
            this.btnMobo.Text = "Wybierz Płytę główną";
            this.btnMobo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMobo.UseAccentColor = false;
            this.btnMobo.UseVisualStyleBackColor = true;
            this.btnMobo.Click += new System.EventHandler(this.btnMobo_Click);
            // 
            // btnRam
            // 
            this.btnRam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRam.Depth = 0;
            this.btnRam.HighEmphasis = true;
            this.btnRam.Icon = null;
            this.btnRam.Location = new System.Drawing.Point(136, 401);
            this.btnRam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRam.Name = "btnRam";
            this.btnRam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRam.Size = new System.Drawing.Size(119, 36);
            this.btnRam.TabIndex = 2;
            this.btnRam.Text = "Wybierz Ram";
            this.btnRam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRam.UseAccentColor = false;
            this.btnRam.UseVisualStyleBackColor = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // btnGpu
            // 
            this.btnGpu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGpu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGpu.Depth = 0;
            this.btnGpu.HighEmphasis = true;
            this.btnGpu.Icon = null;
            this.btnGpu.Location = new System.Drawing.Point(139, 530);
            this.btnGpu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGpu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGpu.Name = "btnGpu";
            this.btnGpu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGpu.Size = new System.Drawing.Size(116, 36);
            this.btnGpu.TabIndex = 3;
            this.btnGpu.Text = "Wybierz GPU";
            this.btnGpu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGpu.UseAccentColor = false;
            this.btnGpu.UseVisualStyleBackColor = true;
            this.btnGpu.Click += new System.EventHandler(this.btnGpu_Click);
            // 
            // btnPsu
            // 
            this.btnPsu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPsu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPsu.Depth = 0;
            this.btnPsu.HighEmphasis = true;
            this.btnPsu.Icon = null;
            this.btnPsu.Location = new System.Drawing.Point(100, 660);
            this.btnPsu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPsu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPsu.Name = "btnPsu";
            this.btnPsu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPsu.Size = new System.Drawing.Size(155, 36);
            this.btnPsu.TabIndex = 4;
            this.btnPsu.Text = "Wybierz Zasilacz";
            this.btnPsu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPsu.UseAccentColor = false;
            this.btnPsu.UseVisualStyleBackColor = true;
            this.btnPsu.Click += new System.EventHandler(this.btnPsu_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.Location = new System.Drawing.Point(901, 126);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 19);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "(cena)";
            // 
            // lblWattage
            // 
            this.lblWattage.AutoSize = true;
            this.lblWattage.Depth = 0;
            this.lblWattage.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWattage.Location = new System.Drawing.Point(901, 191);
            this.lblWattage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWattage.Name = "lblWattage";
            this.lblWattage.Size = new System.Drawing.Size(46, 19);
            this.lblWattage.TabIndex = 6;
            this.lblWattage.Text = "(waty)";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Depth = 0;
            this.lblError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(901, 300);
            this.lblError.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(107, 19);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "materialLabel1";
            // 
            // btnSaveDb
            // 
            this.btnSaveDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveDb.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveDb.Depth = 0;
            this.btnSaveDb.HighEmphasis = true;
            this.btnSaveDb.Icon = null;
            this.btnSaveDb.Location = new System.Drawing.Point(960, 719);
            this.btnSaveDb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveDb.Name = "btnSaveDb";
            this.btnSaveDb.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveDb.Size = new System.Drawing.Size(71, 36);
            this.btnSaveDb.TabIndex = 8;
            this.btnSaveDb.Text = "Zapisz";
            this.btnSaveDb.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveDb.UseAccentColor = false;
            this.btnSaveDb.UseVisualStyleBackColor = true;
            this.btnSaveDb.Click += new System.EventHandler(this.btnSaveDb_Click);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Depth = 0;
            this.lblCpu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCpu.Location = new System.Drawing.Point(320, 161);
            this.lblCpu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(107, 19);
            this.lblCpu.TabIndex = 9;
            this.lblCpu.Text = "materialLabel1";
            // 
            // lblMobo
            // 
            this.lblMobo.AutoSize = true;
            this.lblMobo.Depth = 0;
            this.lblMobo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMobo.Location = new System.Drawing.Point(320, 290);
            this.lblMobo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMobo.Name = "lblMobo";
            this.lblMobo.Size = new System.Drawing.Size(107, 19);
            this.lblMobo.TabIndex = 10;
            this.lblMobo.Text = "materialLabel1";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Depth = 0;
            this.lblRam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRam.Location = new System.Drawing.Point(320, 418);
            this.lblRam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(107, 19);
            this.lblRam.TabIndex = 11;
            this.lblRam.Text = "materialLabel1";
            // 
            // lblGpu
            // 
            this.lblGpu.AutoSize = true;
            this.lblGpu.Depth = 0;
            this.lblGpu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGpu.Location = new System.Drawing.Point(320, 547);
            this.lblGpu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGpu.Name = "lblGpu";
            this.lblGpu.Size = new System.Drawing.Size(107, 19);
            this.lblGpu.TabIndex = 12;
            this.lblGpu.Text = "materialLabel1";
            // 
            // lblPsu
            // 
            this.lblPsu.AutoSize = true;
            this.lblPsu.Depth = 0;
            this.lblPsu.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPsu.Location = new System.Drawing.Point(320, 677);
            this.lblPsu.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPsu.Name = "lblPsu";
            this.lblPsu.Size = new System.Drawing.Size(107, 19);
            this.lblPsu.TabIndex = 13;
            this.lblPsu.Text = "materialLabel1";
            // 
            // pbCpu
            // 
            this.pbCpu.Location = new System.Drawing.Point(614, 80);
            this.pbCpu.Name = "pbCpu";
            this.pbCpu.Size = new System.Drawing.Size(100, 100);
            this.pbCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCpu.TabIndex = 14;
            this.pbCpu.TabStop = false;
            // 
            // pbMobo
            // 
            this.pbMobo.Location = new System.Drawing.Point(614, 209);
            this.pbMobo.Name = "pbMobo";
            this.pbMobo.Size = new System.Drawing.Size(100, 100);
            this.pbMobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMobo.TabIndex = 15;
            this.pbMobo.TabStop = false;
            // 
            // pbRam
            // 
            this.pbRam.Location = new System.Drawing.Point(614, 337);
            this.pbRam.Name = "pbRam";
            this.pbRam.Size = new System.Drawing.Size(100, 100);
            this.pbRam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRam.TabIndex = 16;
            this.pbRam.TabStop = false;
            // 
            // pbGpu
            // 
            this.pbGpu.Location = new System.Drawing.Point(614, 466);
            this.pbGpu.Name = "pbGpu";
            this.pbGpu.Size = new System.Drawing.Size(100, 100);
            this.pbGpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGpu.TabIndex = 17;
            this.pbGpu.TabStop = false;
            // 
            // pbPsu
            // 
            this.pbPsu.Location = new System.Drawing.Point(614, 596);
            this.pbPsu.Name = "pbPsu";
            this.pbPsu.Size = new System.Drawing.Size(100, 100);
            this.pbPsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPsu.TabIndex = 18;
            this.pbPsu.TabStop = false;
            // 
            // ConfiguratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 792);
            this.Controls.Add(this.pbPsu);
            this.Controls.Add(this.pbGpu);
            this.Controls.Add(this.pbRam);
            this.Controls.Add(this.pbMobo);
            this.Controls.Add(this.pbCpu);
            this.Controls.Add(this.lblPsu);
            this.Controls.Add(this.lblGpu);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblMobo);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.btnSaveDb);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblWattage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnPsu);
            this.Controls.Add(this.btnGpu);
            this.Controls.Add(this.btnRam);
            this.Controls.Add(this.btnMobo);
            this.Controls.Add(this.btnCpu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfiguratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zkonfiguruj komputer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMobo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCpu;
        private MaterialSkin.Controls.MaterialButton btnMobo;
        private MaterialSkin.Controls.MaterialButton btnRam;
        private MaterialSkin.Controls.MaterialButton btnGpu;
        private MaterialSkin.Controls.MaterialButton btnPsu;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialLabel lblWattage;
        private MaterialSkin.Controls.MaterialLabel lblError;
        private MaterialSkin.Controls.MaterialButton btnSaveDb;
        private MaterialSkin.Controls.MaterialLabel lblCpu;
        private MaterialSkin.Controls.MaterialLabel lblMobo;
        private MaterialSkin.Controls.MaterialLabel lblRam;
        private MaterialSkin.Controls.MaterialLabel lblGpu;
        private MaterialSkin.Controls.MaterialLabel lblPsu;
        private System.Windows.Forms.PictureBox pbCpu;
        private System.Windows.Forms.PictureBox pbMobo;
        private System.Windows.Forms.PictureBox pbRam;
        private System.Windows.Forms.PictureBox pbGpu;
        private System.Windows.Forms.PictureBox pbPsu;
    }
}

