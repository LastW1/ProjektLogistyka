namespace Logistyka2_staging_0._0
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dodaj_button = new System.Windows.Forms.Button();
            this.licz_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.CzasLabel = new System.Windows.Forms.Label();
            this.KosztLabel = new System.Windows.Forms.Label();
            this.CzasResult = new System.Windows.Forms.Label();
            this.KosztResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 415);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Poprzednie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Następne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "CzasN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(309, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "CzasG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(388, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "KosztN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(470, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "KosztG";
            // 
            // dodaj_button
            // 
            this.dodaj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_button.Image = global::Logistyka2_staging_0._0.Properties.Resources.serca;
            this.dodaj_button.Location = new System.Drawing.Point(640, 35);
            this.dodaj_button.Name = "dodaj_button";
            this.dodaj_button.Size = new System.Drawing.Size(116, 81);
            this.dodaj_button.TabIndex = 13;
            this.dodaj_button.Text = "Dodaj";
            this.dodaj_button.UseVisualStyleBackColor = true;
            this.dodaj_button.Click += new System.EventHandler(this.dodaj_button_Click);
            // 
            // licz_button
            // 
            this.licz_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licz_button.Image = global::Logistyka2_staging_0._0.Properties.Resources.serca;
            this.licz_button.Location = new System.Drawing.Point(640, 190);
            this.licz_button.Name = "licz_button";
            this.licz_button.Size = new System.Drawing.Size(116, 81);
            this.licz_button.TabIndex = 14;
            this.licz_button.Text = "Oblicz";
            this.licz_button.UseVisualStyleBackColor = true;
            this.licz_button.Click += new System.EventHandler(this.licz_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(625, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Skróć czas do:";
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TimeBox.Location = new System.Drawing.Point(640, 147);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(116, 30);
            this.TimeBox.TabIndex = 16;
            // 
            // CzasLabel
            // 
            this.CzasLabel.AutoSize = true;
            this.CzasLabel.BackColor = System.Drawing.Color.Transparent;
            this.CzasLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.CzasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CzasLabel.Location = new System.Drawing.Point(592, 288);
            this.CzasLabel.Name = "CzasLabel";
            this.CzasLabel.Size = new System.Drawing.Size(0, 25);
            this.CzasLabel.TabIndex = 17;
            // 
            // KosztLabel
            // 
            this.KosztLabel.AutoSize = true;
            this.KosztLabel.BackColor = System.Drawing.Color.Transparent;
            this.KosztLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.KosztLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.KosztLabel.Location = new System.Drawing.Point(599, 354);
            this.KosztLabel.Name = "KosztLabel";
            this.KosztLabel.Size = new System.Drawing.Size(0, 25);
            this.KosztLabel.TabIndex = 18;
            // 
            // CzasResult
            // 
            this.CzasResult.AutoSize = true;
            this.CzasResult.BackColor = System.Drawing.Color.Transparent;
            this.CzasResult.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.CzasResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CzasResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.CzasResult.Location = new System.Drawing.Point(592, 313);
            this.CzasResult.Name = "CzasResult";
            this.CzasResult.Size = new System.Drawing.Size(0, 25);
            this.CzasResult.TabIndex = 19;
            // 
            // KosztResult
            // 
            this.KosztResult.AutoSize = true;
            this.KosztResult.BackColor = System.Drawing.Color.Transparent;
            this.KosztResult.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.KosztResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.KosztResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.KosztResult.Location = new System.Drawing.Point(592, 379);
            this.KosztResult.Name = "KosztResult";
            this.KosztResult.Size = new System.Drawing.Size(0, 25);
            this.KosztResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Logistyka2_staging_0._0.Properties.Resources.pies;
            this.ClientSize = new System.Drawing.Size(768, 455);
            this.Controls.Add(this.KosztResult);
            this.Controls.Add(this.CzasResult);
            this.Controls.Add(this.KosztLabel);
            this.Controls.Add(this.CzasLabel);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.licz_button);
            this.Controls.Add(this.dodaj_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dodaj_button;
        private System.Windows.Forms.Button licz_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label CzasLabel;
        private System.Windows.Forms.Label KosztLabel;
        private System.Windows.Forms.Label CzasResult;
        private System.Windows.Forms.Label KosztResult;
    }
}

