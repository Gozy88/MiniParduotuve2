namespace MiniParduotuve2
{
    partial class Form1
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
            this.PrekiuDGV = new System.Windows.Forms.DataGridView();
            this.SukurtiPrekeB = new System.Windows.Forms.Button();
            this.DetiIKrepseliB = new System.Windows.Forms.Button();
            this.KrepselisB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PrekiuDGV
            // 
            this.PrekiuDGV.AllowUserToAddRows = false;
            this.PrekiuDGV.AllowUserToDeleteRows = false;
            this.PrekiuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrekiuDGV.Location = new System.Drawing.Point(31, 32);
            this.PrekiuDGV.Name = "PrekiuDGV";
            this.PrekiuDGV.ReadOnly = true;
            this.PrekiuDGV.RowHeadersWidth = 51;
            this.PrekiuDGV.RowTemplate.Height = 24;
            this.PrekiuDGV.Size = new System.Drawing.Size(492, 335);
            this.PrekiuDGV.TabIndex = 0;
            // 
            // SukurtiPrekeB
            // 
            this.SukurtiPrekeB.Location = new System.Drawing.Point(595, 344);
            this.SukurtiPrekeB.Name = "SukurtiPrekeB";
            this.SukurtiPrekeB.Size = new System.Drawing.Size(146, 32);
            this.SukurtiPrekeB.TabIndex = 1;
            this.SukurtiPrekeB.Text = "Sukurti prekę";
            this.SukurtiPrekeB.UseVisualStyleBackColor = true;
            this.SukurtiPrekeB.Click += new System.EventHandler(this.SukurtiPrekeB_Click);
            // 
            // DetiIKrepseliB
            // 
            this.DetiIKrepseliB.Location = new System.Drawing.Point(595, 32);
            this.DetiIKrepseliB.Name = "DetiIKrepseliB";
            this.DetiIKrepseliB.Size = new System.Drawing.Size(146, 28);
            this.DetiIKrepseliB.TabIndex = 2;
            this.DetiIKrepseliB.Text = "Deti į krepšelį";
            this.DetiIKrepseliB.UseVisualStyleBackColor = true;
            this.DetiIKrepseliB.Click += new System.EventHandler(this.DetiIKrepseliB_Click);
            // 
            // KrepselisB
            // 
            this.KrepselisB.Location = new System.Drawing.Point(595, 86);
            this.KrepselisB.Name = "KrepselisB";
            this.KrepselisB.Size = new System.Drawing.Size(146, 31);
            this.KrepselisB.TabIndex = 3;
            this.KrepselisB.Text = "Krepšelis";
            this.KrepselisB.UseVisualStyleBackColor = true;
            this.KrepselisB.Click += new System.EventHandler(this.KrepselisB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KrepselisB);
            this.Controls.Add(this.DetiIKrepseliB);
            this.Controls.Add(this.SukurtiPrekeB);
            this.Controls.Add(this.PrekiuDGV);
            this.Name = "Form1";
            this.Text = "Mini Parduotuve";
            ((System.ComponentModel.ISupportInitialize)(this.PrekiuDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrekiuDGV;
        private System.Windows.Forms.Button SukurtiPrekeB;
        private System.Windows.Forms.Button DetiIKrepseliB;
        private System.Windows.Forms.Button KrepselisB;
    }
}

