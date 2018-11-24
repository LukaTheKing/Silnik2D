namespace Silnik
{
    partial class Plansza
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Pedzel = new System.Windows.Forms.Button();
            this.Tlo = new System.Windows.Forms.PictureBox();
            this.Coords = new System.Windows.Forms.Label();
            this.Linia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tlo)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pedzel
            // 
            this.Pedzel.Location = new System.Drawing.Point(1042, 41);
            this.Pedzel.Name = "Pedzel";
            this.Pedzel.Size = new System.Drawing.Size(56, 33);
            this.Pedzel.TabIndex = 2;
            this.Pedzel.Text = "Pedzel";
            this.Pedzel.UseVisualStyleBackColor = true;
            this.Pedzel.Click += new System.EventHandler(this.Pedzel_Click);
            // 
            // Tlo
            // 
            this.Tlo.Location = new System.Drawing.Point(23, 12);
            this.Tlo.Name = "Tlo";
            this.Tlo.Size = new System.Drawing.Size(1000, 500);
            this.Tlo.TabIndex = 2;
            this.Tlo.TabStop = false;
            this.Tlo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tlo_MouseDown);
            this.Tlo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tlo_MouseMove);
            this.Tlo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Tlo_MouseUp);
            // 
            // Coords
            // 
            this.Coords.AutoSize = true;
            this.Coords.Location = new System.Drawing.Point(1110, 9);
            this.Coords.Name = "Coords";
            this.Coords.Size = new System.Drawing.Size(33, 13);
            this.Coords.TabIndex = 4;
            this.Coords.Text = "X:  Y:";
            // 
            // Linia
            // 
            this.Linia.Location = new System.Drawing.Point(1116, 41);
            this.Linia.Name = "Linia";
            this.Linia.Size = new System.Drawing.Size(56, 33);
            this.Linia.TabIndex = 5;
            this.Linia.Text = "Linia";
            this.Linia.UseVisualStyleBackColor = true;
            this.Linia.Click += new System.EventHandler(this.Linia_Click);
            // 
            // Plansza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.Linia);
            this.Controls.Add(this.Coords);
            this.Controls.Add(this.Tlo);
            this.Controls.Add(this.Pedzel);
            this.Name = "Plansza";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Pedzel;
        private System.Windows.Forms.PictureBox Tlo;
        private System.Windows.Forms.Label Coords;
        private System.Windows.Forms.Button Linia;
    }
}

