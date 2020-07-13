namespace MiniParduotuve2
{
    partial class KrepselisForm
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
            this.KrepselisDGV = new System.Windows.Forms.DataGridView();
            this.PrekiuKainaLB = new System.Windows.Forms.Label();
            this.PristatymoTipasLB = new System.Windows.Forms.Label();
            this.PristatymasPastuRB = new System.Windows.Forms.RadioButton();
            this.KurjerisRB = new System.Windows.Forms.RadioButton();
            this.PastomatasRB = new System.Windows.Forms.RadioButton();
            this.TarptautinisRB = new System.Windows.Forms.RadioButton();
            this.SiuntosDydisLB = new System.Windows.Forms.Label();
            this.SiuntimoKainaLB = new System.Windows.Forms.Label();
            this.SumaLB = new System.Windows.Forms.Label();
            this.PirktiB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KrepselisDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // KrepselisDGV
            // 
            this.KrepselisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KrepselisDGV.Location = new System.Drawing.Point(12, 31);
            this.KrepselisDGV.Name = "KrepselisDGV";
            this.KrepselisDGV.RowHeadersWidth = 51;
            this.KrepselisDGV.RowTemplate.Height = 24;
            this.KrepselisDGV.Size = new System.Drawing.Size(477, 326);
            this.KrepselisDGV.TabIndex = 0;
            // 
            // PrekiuKainaLB
            // 
            this.PrekiuKainaLB.AutoSize = true;
            this.PrekiuKainaLB.Location = new System.Drawing.Point(345, 364);
            this.PrekiuKainaLB.Name = "PrekiuKainaLB";
            this.PrekiuKainaLB.Size = new System.Drawing.Size(90, 17);
            this.PrekiuKainaLB.TabIndex = 1;
            this.PrekiuKainaLB.Text = "Prekių kaina:";
            // 
            // PristatymoTipasLB
            // 
            this.PristatymoTipasLB.AutoSize = true;
            this.PristatymoTipasLB.Location = new System.Drawing.Point(533, 80);
            this.PristatymoTipasLB.Name = "PristatymoTipasLB";
            this.PristatymoTipasLB.Size = new System.Drawing.Size(182, 17);
            this.PristatymoTipasLB.TabIndex = 2;
            this.PristatymoTipasLB.Text = "Pasirinkite pristatymo būdą:";
            // 
            // PristatymasPastuRB
            // 
            this.PristatymasPastuRB.AutoSize = true;
            this.PristatymasPastuRB.Location = new System.Drawing.Point(536, 115);
            this.PristatymasPastuRB.Name = "PristatymasPastuRB";
            this.PristatymasPastuRB.Size = new System.Drawing.Size(141, 21);
            this.PristatymasPastuRB.TabIndex = 4;
            this.PristatymasPastuRB.TabStop = true;
            this.PristatymasPastuRB.Text = "Pristatymas paštu";
            this.PristatymasPastuRB.UseVisualStyleBackColor = true;
            this.PristatymasPastuRB.CheckedChanged += new System.EventHandler(this.PristatymasPastuRB_CheckedChanged);
            // 
            // KurjerisRB
            // 
            this.KurjerisRB.AutoSize = true;
            this.KurjerisRB.Location = new System.Drawing.Point(536, 152);
            this.KurjerisRB.Name = "KurjerisRB";
            this.KurjerisRB.Size = new System.Drawing.Size(77, 21);
            this.KurjerisRB.TabIndex = 5;
            this.KurjerisRB.TabStop = true;
            this.KurjerisRB.Text = "Kurjeris";
            this.KurjerisRB.UseVisualStyleBackColor = true;
            this.KurjerisRB.CheckedChanged += new System.EventHandler(this.KurjerisRB_CheckedChanged);
            // 
            // PastomatasRB
            // 
            this.PastomatasRB.AutoSize = true;
            this.PastomatasRB.Location = new System.Drawing.Point(536, 189);
            this.PastomatasRB.Name = "PastomatasRB";
            this.PastomatasRB.Size = new System.Drawing.Size(103, 21);
            this.PastomatasRB.TabIndex = 6;
            this.PastomatasRB.TabStop = true;
            this.PastomatasRB.Text = "Paštomatas";
            this.PastomatasRB.UseVisualStyleBackColor = true;
            this.PastomatasRB.CheckedChanged += new System.EventHandler(this.PastomatasRB_CheckedChanged);
            // 
            // TarptautinisRB
            // 
            this.TarptautinisRB.AutoSize = true;
            this.TarptautinisRB.Location = new System.Drawing.Point(536, 229);
            this.TarptautinisRB.Name = "TarptautinisRB";
            this.TarptautinisRB.Size = new System.Drawing.Size(180, 21);
            this.TarptautinisRB.TabIndex = 7;
            this.TarptautinisRB.TabStop = true;
            this.TarptautinisRB.Text = "Tarptautinis pristatymas";
            this.TarptautinisRB.UseVisualStyleBackColor = true;
            this.TarptautinisRB.CheckedChanged += new System.EventHandler(this.TarptautinisRB_CheckedChanged);
            // 
            // SiuntosDydisLB
            // 
            this.SiuntosDydisLB.AutoSize = true;
            this.SiuntosDydisLB.Location = new System.Drawing.Point(533, 45);
            this.SiuntosDydisLB.Name = "SiuntosDydisLB";
            this.SiuntosDydisLB.Size = new System.Drawing.Size(96, 17);
            this.SiuntosDydisLB.TabIndex = 8;
            this.SiuntosDydisLB.Text = "Siuntos dydis:";
            // 
            // SiuntimoKainaLB
            // 
            this.SiuntimoKainaLB.AutoSize = true;
            this.SiuntimoKainaLB.Location = new System.Drawing.Point(331, 392);
            this.SiuntimoKainaLB.Name = "SiuntimoKainaLB";
            this.SiuntimoKainaLB.Size = new System.Drawing.Size(104, 17);
            this.SiuntimoKainaLB.TabIndex = 9;
            this.SiuntimoKainaLB.Text = "Siuntimo kaina:";
            // 
            // SumaLB
            // 
            this.SumaLB.AutoSize = true;
            this.SumaLB.Location = new System.Drawing.Point(348, 421);
            this.SumaLB.Name = "SumaLB";
            this.SumaLB.Size = new System.Drawing.Size(48, 17);
            this.SumaLB.TabIndex = 10;
            this.SumaLB.Text = "Suma:";
            // 
            // PirktiB
            // 
            this.PirktiB.Location = new System.Drawing.Point(658, 334);
            this.PirktiB.Name = "PirktiB";
            this.PirktiB.Size = new System.Drawing.Size(75, 23);
            this.PirktiB.TabIndex = 11;
            this.PirktiB.Text = "Pirkti";
            this.PirktiB.UseVisualStyleBackColor = true;
            this.PirktiB.Click += new System.EventHandler(this.PirktiB_Click);
            // 
            // KrepselisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PirktiB);
            this.Controls.Add(this.SumaLB);
            this.Controls.Add(this.SiuntimoKainaLB);
            this.Controls.Add(this.SiuntosDydisLB);
            this.Controls.Add(this.TarptautinisRB);
            this.Controls.Add(this.PastomatasRB);
            this.Controls.Add(this.KurjerisRB);
            this.Controls.Add(this.PristatymasPastuRB);
            this.Controls.Add(this.PristatymoTipasLB);
            this.Controls.Add(this.PrekiuKainaLB);
            this.Controls.Add(this.KrepselisDGV);
            this.Name = "KrepselisForm";
            this.Text = "Krepšelis";
            ((System.ComponentModel.ISupportInitialize)(this.KrepselisDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KrepselisDGV;
        private System.Windows.Forms.Label PrekiuKainaLB;
        private System.Windows.Forms.Label PristatymoTipasLB;
        private System.Windows.Forms.RadioButton PristatymasPastuRB;
        private System.Windows.Forms.RadioButton KurjerisRB;
        private System.Windows.Forms.RadioButton PastomatasRB;
        private System.Windows.Forms.RadioButton TarptautinisRB;
        private System.Windows.Forms.Label SiuntosDydisLB;
        private System.Windows.Forms.Label SiuntimoKainaLB;
        private System.Windows.Forms.Label SumaLB;
        private System.Windows.Forms.Button PirktiB;
    }
}