namespace SystemInfoClient
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.processorInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graphicCardInfo = new System.Windows.Forms.TextBox();
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ramInfo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.motherboardInfo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hardDisksInfo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.operatingSystemInfo = new System.Windows.Forms.TextBox();
            this.sendInfo = new System.Windows.Forms.Button();
            this.config = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processorInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processor";
            // 
            // processorInfo
            // 
            this.processorInfo.AllowDrop = true;
            this.processorInfo.Location = new System.Drawing.Point(6, 19);
            this.processorInfo.Multiline = true;
            this.processorInfo.Name = "processorInfo";
            this.processorInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.processorInfo.Size = new System.Drawing.Size(296, 45);
            this.processorInfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.graphicCardInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphic card";
            // 
            // graphicCardInfo
            // 
            this.graphicCardInfo.AllowDrop = true;
            this.graphicCardInfo.Location = new System.Drawing.Point(6, 19);
            this.graphicCardInfo.Multiline = true;
            this.graphicCardInfo.Name = "graphicCardInfo";
            this.graphicCardInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.graphicCardInfo.Size = new System.Drawing.Size(296, 45);
            this.graphicCardInfo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ramInfo);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM";
            // 
            // ramInfo
            // 
            this.ramInfo.AllowDrop = true;
            this.ramInfo.Location = new System.Drawing.Point(6, 19);
            this.ramInfo.Multiline = true;
            this.ramInfo.Name = "ramInfo";
            this.ramInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ramInfo.Size = new System.Drawing.Size(296, 45);
            this.ramInfo.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.motherboardInfo);
            this.groupBox4.Location = new System.Drawing.Point(12, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 70);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motherboard";
            // 
            // motherboardInfo
            // 
            this.motherboardInfo.AllowDrop = true;
            this.motherboardInfo.Location = new System.Drawing.Point(6, 19);
            this.motherboardInfo.Multiline = true;
            this.motherboardInfo.Name = "motherboardInfo";
            this.motherboardInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motherboardInfo.Size = new System.Drawing.Size(296, 45);
            this.motherboardInfo.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hardDisksInfo);
            this.groupBox5.Location = new System.Drawing.Point(12, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(310, 70);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hard disk";
            // 
            // hardDisksInfo
            // 
            this.hardDisksInfo.AllowDrop = true;
            this.hardDisksInfo.Location = new System.Drawing.Point(6, 19);
            this.hardDisksInfo.Multiline = true;
            this.hardDisksInfo.Name = "hardDisksInfo";
            this.hardDisksInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hardDisksInfo.Size = new System.Drawing.Size(296, 45);
            this.hardDisksInfo.TabIndex = 4;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.operatingSystemInfo);
            this.groupBox7.Location = new System.Drawing.Point(12, 392);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(310, 70);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Operating system";
            // 
            // operatingSystemInfo
            // 
            this.operatingSystemInfo.AllowDrop = true;
            this.operatingSystemInfo.Location = new System.Drawing.Point(6, 19);
            this.operatingSystemInfo.Multiline = true;
            this.operatingSystemInfo.Name = "operatingSystemInfo";
            this.operatingSystemInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.operatingSystemInfo.Size = new System.Drawing.Size(296, 45);
            this.operatingSystemInfo.TabIndex = 6;
            // 
            // sendInfo
            // 
            this.sendInfo.Location = new System.Drawing.Point(18, 469);
            this.sendInfo.Name = "sendInfo";
            this.sendInfo.Size = new System.Drawing.Size(150, 23);
            this.sendInfo.TabIndex = 12;
            this.sendInfo.Text = "Send";
            this.sendInfo.UseVisualStyleBackColor = true;
            this.sendInfo.Click += new System.EventHandler(this.sendInfo_Click);
            // 
            // config
            // 
            this.config.Location = new System.Drawing.Point(174, 469);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(150, 23);
            this.config.TabIndex = 13;
            this.config.Text = "Configuration";
            this.config.UseVisualStyleBackColor = true;
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(343, 503);
            this.Controls.Add(this.config);
            this.Controls.Add(this.sendInfo);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "hard d";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource processorBindingSource;
        private System.Windows.Forms.TextBox processorInfo;
        private System.Windows.Forms.TextBox graphicCardInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ramInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox motherboardInfo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox hardDisksInfo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox operatingSystemInfo;
        private System.Windows.Forms.Button sendInfo;
        private System.Windows.Forms.Button config;
    }
}

