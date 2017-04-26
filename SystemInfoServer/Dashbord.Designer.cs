namespace SystemInfoServer
{
    partial class Dashbord
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
            this.log = new System.Windows.Forms.TextBox();
            this.generateCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 201);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(660, 148);
            this.log.TabIndex = 0;
            // 
            // generateCSV
            // 
            this.generateCSV.Location = new System.Drawing.Point(584, 12);
            this.generateCSV.Name = "generateCSV";
            this.generateCSV.Size = new System.Drawing.Size(88, 23);
            this.generateCSV.TabIndex = 1;
            this.generateCSV.Text = "Generate CSV";
            this.generateCSV.UseVisualStyleBackColor = true;
            this.generateCSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.generateCSV);
            this.Controls.Add(this.log);
            this.Name = "Dashbord";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashbord_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashbord_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button generateCSV;
    }
}

