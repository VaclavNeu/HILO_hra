namespace HiLo_hra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_generace = new Button();
            VkladCisel = new NumericUpDown();
            btn_Hadej = new Button();
            Cislo = new Label();
            PocitacMozek = new Label();
            btn_Streak = new Button();
            btn_Napoveda = new Button();
            Obrazek_Boss = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)VkladCisel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obrazek_Boss).BeginInit();
            SuspendLayout();
            // 
            // btn_generace
            // 
            btn_generace.Location = new Point(64, 164);
            btn_generace.Name = "btn_generace";
            btn_generace.Size = new Size(110, 30);
            btn_generace.TabIndex = 0;
            btn_generace.Text = "Generuj Cislo";
            btn_generace.UseVisualStyleBackColor = true;
            btn_generace.Click += btn_generace_Click;
            // 
            // VkladCisel
            // 
            VkladCisel.Location = new Point(64, 200);
            VkladCisel.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            VkladCisel.Name = "VkladCisel";
            VkladCisel.Size = new Size(150, 27);
            VkladCisel.TabIndex = 1;
            // 
            // btn_Hadej
            // 
            btn_Hadej.Location = new Point(64, 233);
            btn_Hadej.Name = "btn_Hadej";
            btn_Hadej.Size = new Size(110, 30);
            btn_Hadej.TabIndex = 2;
            btn_Hadej.Text = "Hadej";
            btn_Hadej.UseVisualStyleBackColor = true;
            btn_Hadej.Click += btn_Hadej_Click;
            btn_Hadej.MouseHover += btn_Hadej_MouseHover;
            // 
            // Cislo
            // 
            Cislo.AutoSize = true;
            Cislo.Location = new Point(743, 411);
            Cislo.Name = "Cislo";
            Cislo.Size = new Size(16, 20);
            Cislo.TabIndex = 3;
            Cislo.Text = "x";
            Cislo.Visible = false;
            // 
            // PocitacMozek
            // 
            PocitacMozek.AutoSize = true;
            PocitacMozek.Location = new Point(220, 202);
            PocitacMozek.Name = "PocitacMozek";
            PocitacMozek.Size = new Size(159, 20);
            PocitacMozek.TabIndex = 4;
            PocitacMozek.Text = "Jsem zde abych ti radil";
            // 
            // btn_Streak
            // 
            btn_Streak.Location = new Point(697, 233);
            btn_Streak.Name = "btn_Streak";
            btn_Streak.Size = new Size(110, 30);
            btn_Streak.TabIndex = 5;
            btn_Streak.Text = "Tajne tlacitko";
            btn_Streak.UseVisualStyleBackColor = true;
            btn_Streak.Visible = false;
            btn_Streak.Click += btn_Streak_Click;
            // 
            // btn_Napoveda
            // 
            btn_Napoveda.Location = new Point(697, 366);
            btn_Napoveda.Name = "btn_Napoveda";
            btn_Napoveda.Size = new Size(110, 30);
            btn_Napoveda.TabIndex = 6;
            btn_Napoveda.Text = "Napoveda";
            btn_Napoveda.UseVisualStyleBackColor = true;
            btn_Napoveda.Click += btn_Napoveda_Click;
            // 
            // Obrazek_Boss
            // 
            Obrazek_Boss.Image = Properties.Resources.Demon_Pocitac;
            Obrazek_Boss.Location = new Point(253, 12);
            Obrazek_Boss.Name = "Obrazek_Boss";
            Obrazek_Boss.Size = new Size(493, 348);
            Obrazek_Boss.SizeMode = PictureBoxSizeMode.StretchImage;
            Obrazek_Boss.TabIndex = 7;
            Obrazek_Boss.TabStop = false;
            Obrazek_Boss.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(Obrazek_Boss);
            Controls.Add(btn_Napoveda);
            Controls.Add(btn_Streak);
            Controls.Add(PocitacMozek);
            Controls.Add(Cislo);
            Controls.Add(btn_Hadej);
            Controls.Add(VkladCisel);
            Controls.Add(btn_generace);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)VkladCisel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obrazek_Boss).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_generace;
        private NumericUpDown VkladCisel;
        private Button btn_Hadej;
        private Label Cislo;
        private Label PocitacMozek;
        private Button btn_Streak;
        private Button btn_Napoveda;
        private PictureBox Obrazek_Boss;
    }
}
