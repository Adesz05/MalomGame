
namespace MalomGame
{
    partial class Jatekter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jatekter));
            this.FeherAmong = new System.Windows.Forms.PictureBox();
            this.FeherFeladas = new System.Windows.Forms.Button();
            this.FeketeAmong = new System.Windows.Forms.PictureBox();
            this.FeketeFeladas = new System.Windows.Forms.Button();
            this.FeherPontSzam = new System.Windows.Forms.Label();
            this.FeketePontszam = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.PictureBox();
            this.FeherLBL = new System.Windows.Forms.Label();
            this.FeketeLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FeherAmong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeketeAmong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // FeherAmong
            // 
            this.FeherAmong.Image = ((System.Drawing.Image)(resources.GetObject("FeherAmong.Image")));
            this.FeherAmong.Location = new System.Drawing.Point(39, 51);
            this.FeherAmong.Name = "FeherAmong";
            this.FeherAmong.Size = new System.Drawing.Size(180, 254);
            this.FeherAmong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeherAmong.TabIndex = 9;
            this.FeherAmong.TabStop = false;
            // 
            // FeherFeladas
            // 
            this.FeherFeladas.BackColor = System.Drawing.Color.SaddleBrown;
            this.FeherFeladas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FeherFeladas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeherFeladas.ForeColor = System.Drawing.Color.LightSalmon;
            this.FeherFeladas.Location = new System.Drawing.Point(49, 314);
            this.FeherFeladas.Name = "FeherFeladas";
            this.FeherFeladas.Size = new System.Drawing.Size(148, 45);
            this.FeherFeladas.TabIndex = 10;
            this.FeherFeladas.Text = "Feladás";
            this.FeherFeladas.UseVisualStyleBackColor = false;
            this.FeherFeladas.Click += new System.EventHandler(this.FeherFeladas_Click);
            // 
            // FeketeAmong
            // 
            this.FeketeAmong.Image = ((System.Drawing.Image)(resources.GetObject("FeketeAmong.Image")));
            this.FeketeAmong.Location = new System.Drawing.Point(803, 51);
            this.FeketeAmong.Name = "FeketeAmong";
            this.FeketeAmong.Size = new System.Drawing.Size(180, 254);
            this.FeketeAmong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeketeAmong.TabIndex = 11;
            this.FeketeAmong.TabStop = false;
            // 
            // FeketeFeladas
            // 
            this.FeketeFeladas.BackColor = System.Drawing.Color.SaddleBrown;
            this.FeketeFeladas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FeketeFeladas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeketeFeladas.ForeColor = System.Drawing.Color.LightSalmon;
            this.FeketeFeladas.Location = new System.Drawing.Point(822, 314);
            this.FeketeFeladas.Name = "FeketeFeladas";
            this.FeketeFeladas.Size = new System.Drawing.Size(148, 45);
            this.FeketeFeladas.TabIndex = 12;
            this.FeketeFeladas.Text = "Feladás";
            this.FeketeFeladas.UseVisualStyleBackColor = false;
            this.FeketeFeladas.Click += new System.EventHandler(this.FeketeFeladas_Click);
            // 
            // FeherPontSzam
            // 
            this.FeherPontSzam.AutoSize = true;
            this.FeherPontSzam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeherPontSzam.Location = new System.Drawing.Point(39, 511);
            this.FeherPontSzam.MinimumSize = new System.Drawing.Size(180, 30);
            this.FeherPontSzam.Name = "FeherPontSzam";
            this.FeherPontSzam.Size = new System.Drawing.Size(180, 30);
            this.FeherPontSzam.TabIndex = 14;
            // 
            // FeketePontszam
            // 
            this.FeketePontszam.AutoSize = true;
            this.FeketePontszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeketePontszam.Location = new System.Drawing.Point(803, 511);
            this.FeketePontszam.MinimumSize = new System.Drawing.Size(180, 30);
            this.FeketePontszam.Name = "FeketePontszam";
            this.FeketePontszam.Size = new System.Drawing.Size(180, 30);
            this.FeketePontszam.TabIndex = 16;
            // 
            // Tabla
            // 
            this.Tabla.Image = ((System.Drawing.Image)(resources.GetObject("Tabla.Image")));
            this.Tabla.Location = new System.Drawing.Point(241, 51);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(521, 520);
            this.Tabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tabla.TabIndex = 17;
            this.Tabla.TabStop = false;
            // 
            // FeherLBL
            // 
            this.FeherLBL.AutoSize = true;
            this.FeherLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeherLBL.Location = new System.Drawing.Point(34, 390);
            this.FeherLBL.MinimumSize = new System.Drawing.Size(180, 30);
            this.FeherLBL.Name = "FeherLBL";
            this.FeherLBL.Size = new System.Drawing.Size(180, 30);
            this.FeherLBL.TabIndex = 18;
            // 
            // FeketeLBL
            // 
            this.FeketeLBL.AutoSize = true;
            this.FeketeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FeketeLBL.Location = new System.Drawing.Point(803, 390);
            this.FeketeLBL.MinimumSize = new System.Drawing.Size(180, 30);
            this.FeketeLBL.Name = "FeketeLBL";
            this.FeketeLBL.Size = new System.Drawing.Size(180, 30);
            this.FeketeLBL.TabIndex = 19;
            // 
            // Jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1009, 616);
            this.Controls.Add(this.FeketeLBL);
            this.Controls.Add(this.FeherLBL);
            this.Controls.Add(this.FeketePontszam);
            this.Controls.Add(this.FeherPontSzam);
            this.Controls.Add(this.FeketeFeladas);
            this.Controls.Add(this.FeketeAmong);
            this.Controls.Add(this.FeherFeladas);
            this.Controls.Add(this.FeherAmong);
            this.Controls.Add(this.Tabla);
            this.MaximumSize = new System.Drawing.Size(1025, 655);
            this.MinimumSize = new System.Drawing.Size(1025, 655);
            this.Name = "Jatekter";
            this.Text = "Jatekter";
            ((System.ComponentModel.ISupportInitialize)(this.FeherAmong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeketeAmong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FeherAmong;
        private System.Windows.Forms.Button FeherFeladas;
        private System.Windows.Forms.PictureBox FeketeAmong;
        private System.Windows.Forms.Button FeketeFeladas;
        private System.Windows.Forms.Label FeherPontSzam;
        private System.Windows.Forms.Label FeketePontszam;
        private System.Windows.Forms.PictureBox Tabla;
        private System.Windows.Forms.Label FeherLBL;
        private System.Windows.Forms.Label FeketeLBL;
    }
}