namespace FiltroRGB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOriginalImage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFilterBGR = new System.Windows.Forms.GroupBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.gbOriginalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            this.gbFilterBGR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOriginalImage
            // 
            this.gbOriginalImage.Controls.Add(this.label1);
            this.gbOriginalImage.Controls.Add(this.btnLoad);
            this.gbOriginalImage.Controls.Add(this.pbOriginalImage);
            this.gbOriginalImage.Location = new System.Drawing.Point(12, 12);
            this.gbOriginalImage.Name = "gbOriginalImage";
            this.gbOriginalImage.Size = new System.Drawing.Size(357, 348);
            this.gbOriginalImage.TabIndex = 0;
            this.gbOriginalImage.TabStop = false;
            this.gbOriginalImage.Text = "Imagen Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imagen";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(312, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(35, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.Location = new System.Drawing.Point(6, 19);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(300, 300);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalImage.TabIndex = 0;
            this.pbOriginalImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbFilterBGR
            // 
            this.gbFilterBGR.Controls.Add(this.rbGray);
            this.gbFilterBGR.Controls.Add(this.rbRed);
            this.gbFilterBGR.Controls.Add(this.rbGreen);
            this.gbFilterBGR.Controls.Add(this.rbBlue);
            this.gbFilterBGR.Controls.Add(this.btnSave);
            this.gbFilterBGR.Controls.Add(this.pbFilter);
            this.gbFilterBGR.Location = new System.Drawing.Point(375, 12);
            this.gbFilterBGR.Name = "gbFilterBGR";
            this.gbFilterBGR.Size = new System.Drawing.Size(384, 348);
            this.gbFilterBGR.TabIndex = 1;
            this.gbFilterBGR.TabStop = false;
            this.gbFilterBGR.Text = "groupBox2";
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(312, 65);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(47, 17);
            this.rbRed.TabIndex = 6;
            this.rbRed.Text = "Rojo";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.Click += new System.EventHandler(this.rbRed_Click);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(312, 42);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(53, 17);
            this.rbGreen.TabIndex = 5;
            this.rbGreen.Text = "Verde";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.Click += new System.EventHandler(this.rbGreen_Click);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Checked = true;
            this.rbBlue.Location = new System.Drawing.Point(312, 19);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(45, 17);
            this.rbBlue.TabIndex = 4;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Azul";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.Click += new System.EventHandler(this.rbBlue_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::FiltroRGB.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(312, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pbFilter
            // 
            this.pbFilter.Location = new System.Drawing.Point(6, 19);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(300, 300);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilter.TabIndex = 3;
            this.pbFilter.TabStop = false;
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Location = new System.Drawing.Point(312, 88);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(43, 17);
            this.rbGray.TabIndex = 7;
            this.rbGray.Text = "Gris";
            this.rbGray.UseVisualStyleBackColor = true;
            this.rbGray.Click += new System.EventHandler(this.rbGray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 367);
            this.Controls.Add(this.gbFilterBGR);
            this.Controls.Add(this.gbOriginalImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOriginalImage.ResumeLayout(false);
            this.gbOriginalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            this.gbFilterBGR.ResumeLayout(false);
            this.gbFilterBGR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOriginalImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbFilterBGR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbFilter;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGray;
    }
}

