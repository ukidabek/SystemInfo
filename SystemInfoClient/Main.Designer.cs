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
            this.processorSpecyfikationLabel = new System.Windows.Forms.Label();
            this.processorCoresTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processorLogicalProcessorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ramCapacityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ramTypeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.processorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorSpecyfikationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.processorSpecyfikationTextBox);
            this.groupBox1.Controls.Add(this.processorLogicalProcessorTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.processorCoresTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.processorSpecyfikationLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processor";
            // 
            // processorSpecyfikationLabel
            // 
            this.processorSpecyfikationLabel.AutoSize = true;
            this.processorSpecyfikationLabel.Location = new System.Drawing.Point(3, 16);
            this.processorSpecyfikationLabel.Name = "processorSpecyfikationLabel";
            this.processorSpecyfikationLabel.Size = new System.Drawing.Size(71, 13);
            this.processorSpecyfikationLabel.TabIndex = 0;
            this.processorSpecyfikationLabel.Text = "Specyfikation";
            // 
            // processorCoresTextBox
            // 
            this.processorCoresTextBox.Location = new System.Drawing.Point(45, 40);
            this.processorCoresTextBox.Name = "processorCoresTextBox";
            this.processorCoresTextBox.Size = new System.Drawing.Size(96, 20);
            this.processorCoresTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cores";
            // 
            // processorLogicalProcessorTextBox
            // 
            this.processorLogicalProcessorTextBox.Location = new System.Drawing.Point(208, 40);
            this.processorLogicalProcessorTextBox.Name = "processorLogicalProcessorTextBox";
            this.processorLogicalProcessorTextBox.Size = new System.Drawing.Size(96, 20);
            this.processorLogicalProcessorTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Threds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ramCapacityTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ramTypeTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM";
            // 
            // ramCapacityTextBox
            // 
            this.ramCapacityTextBox.Location = new System.Drawing.Point(45, 40);
            this.ramCapacityTextBox.Name = "ramCapacityTextBox";
            this.ramCapacityTextBox.Size = new System.Drawing.Size(259, 20);
            this.ramCapacityTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Size";
            // 
            // ramTypeTextBox
            // 
            this.ramTypeTextBox.Location = new System.Drawing.Point(45, 13);
            this.ramTypeTextBox.Name = "ramTypeTextBox";
            this.ramTypeTextBox.Size = new System.Drawing.Size(259, 20);
            this.ramTypeTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphic card";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(45, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "RAM";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(45, 13);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(259, 20);
            this.textBox7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // processorBindingSource
            // 
            this.processorBindingSource.DataSource = typeof(SystemInfo.Processor);
            // 
            // processorSpecyfikationTextBox
            // 
            this.processorSpecyfikationTextBox.Location = new System.Drawing.Point(80, 13);
            this.processorSpecyfikationTextBox.Name = "processorSpecyfikationTextBox";
            this.processorSpecyfikationTextBox.Size = new System.Drawing.Size(224, 20);
            this.processorSpecyfikationTextBox.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "SystemInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox processorLogicalProcessorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox processorCoresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label processorSpecyfikationLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ramCapacityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ramTypeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox processorSpecyfikationTextBox;
        private System.Windows.Forms.BindingSource processorBindingSource;
    }
}

