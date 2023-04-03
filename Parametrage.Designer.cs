namespace Puissance4
{
    partial class Parametrage
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
            grpJoueurs = new GroupBox();
            panel1 = new Panel();
            rdoJ2Rouge = new RadioButton();
            rdoJ2Jaune = new RadioButton();
            pnlJ1 = new Panel();
            rdoJ1Rouge = new RadioButton();
            rdoJ1Jaune = new RadioButton();
            txtInputJ2 = new TextBox();
            lblJ2 = new Label();
            txtInputJ1 = new TextBox();
            lblJ1 = new Label();
            grpPartie = new GroupBox();
            cmbTailleGrille = new ComboBox();
            rdoJ2 = new RadioButton();
            rdoJ1 = new RadioButton();
            lbl1erJoueur = new Label();
            lblTaillePartie = new Label();
            lblParametrage = new Label();
            btnCommencer = new Button();
            btnRetour = new Button();
            grpJoueurs.SuspendLayout();
            panel1.SuspendLayout();
            pnlJ1.SuspendLayout();
            grpPartie.SuspendLayout();
            SuspendLayout();
            // 
            // grpJoueurs
            // 
            grpJoueurs.Controls.Add(panel1);
            grpJoueurs.Controls.Add(pnlJ1);
            grpJoueurs.Controls.Add(txtInputJ2);
            grpJoueurs.Controls.Add(lblJ2);
            grpJoueurs.Controls.Add(txtInputJ1);
            grpJoueurs.Controls.Add(lblJ1);
            grpJoueurs.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            grpJoueurs.Location = new Point(78, 98);
            grpJoueurs.Margin = new Padding(3, 2, 3, 2);
            grpJoueurs.Name = "grpJoueurs";
            grpJoueurs.Padding = new Padding(3, 2, 3, 2);
            grpJoueurs.Size = new Size(475, 168);
            grpJoueurs.TabIndex = 3;
            grpJoueurs.TabStop = false;
            grpJoueurs.Text = "Les Joueurs";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoJ2Rouge);
            panel1.Controls.Add(rdoJ2Jaune);
            panel1.Location = new Point(284, 111);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 28);
            panel1.TabIndex = 12;
            // 
            // rdoJ2Rouge
            // 
            rdoJ2Rouge.AutoSize = true;
            rdoJ2Rouge.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            rdoJ2Rouge.Location = new Point(0, 1);
            rdoJ2Rouge.Margin = new Padding(3, 2, 3, 2);
            rdoJ2Rouge.Name = "rdoJ2Rouge";
            rdoJ2Rouge.Size = new Size(81, 29);
            rdoJ2Rouge.TabIndex = 6;
            rdoJ2Rouge.Text = "Rouge";
            rdoJ2Rouge.UseVisualStyleBackColor = true;
            rdoJ2Rouge.CheckedChanged += rdoJ2Rouge_CheckedChanged;
            // 
            // rdoJ2Jaune
            // 
            rdoJ2Jaune.AutoSize = true;
            rdoJ2Jaune.Checked = true;
            rdoJ2Jaune.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            rdoJ2Jaune.Location = new Point(88, 1);
            rdoJ2Jaune.Margin = new Padding(3, 2, 3, 2);
            rdoJ2Jaune.Name = "rdoJ2Jaune";
            rdoJ2Jaune.Size = new Size(74, 29);
            rdoJ2Jaune.TabIndex = 7;
            rdoJ2Jaune.TabStop = true;
            rdoJ2Jaune.Text = "Jaune";
            rdoJ2Jaune.UseVisualStyleBackColor = true;
            rdoJ2Jaune.CheckedChanged += rdoJ2Jaune_CheckedChanged;
            // 
            // pnlJ1
            // 
            pnlJ1.Controls.Add(rdoJ1Rouge);
            pnlJ1.Controls.Add(rdoJ1Jaune);
            pnlJ1.Location = new Point(284, 49);
            pnlJ1.Margin = new Padding(3, 2, 3, 2);
            pnlJ1.Name = "pnlJ1";
            pnlJ1.Size = new Size(169, 28);
            pnlJ1.TabIndex = 11;
            // 
            // rdoJ1Rouge
            // 
            rdoJ1Rouge.AutoSize = true;
            rdoJ1Rouge.Checked = true;
            rdoJ1Rouge.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            rdoJ1Rouge.Location = new Point(0, 1);
            rdoJ1Rouge.Margin = new Padding(3, 2, 3, 2);
            rdoJ1Rouge.Name = "rdoJ1Rouge";
            rdoJ1Rouge.Size = new Size(81, 29);
            rdoJ1Rouge.TabIndex = 6;
            rdoJ1Rouge.TabStop = true;
            rdoJ1Rouge.Text = "Rouge";
            rdoJ1Rouge.UseVisualStyleBackColor = true;
            rdoJ1Rouge.CheckedChanged += rdoJ1Rouge_CheckedChanged;
            // 
            // rdoJ1Jaune
            // 
            rdoJ1Jaune.AutoSize = true;
            rdoJ1Jaune.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            rdoJ1Jaune.Location = new Point(88, 1);
            rdoJ1Jaune.Margin = new Padding(3, 2, 3, 2);
            rdoJ1Jaune.Name = "rdoJ1Jaune";
            rdoJ1Jaune.Size = new Size(74, 29);
            rdoJ1Jaune.TabIndex = 7;
            rdoJ1Jaune.Text = "Jaune";
            rdoJ1Jaune.UseVisualStyleBackColor = true;
            rdoJ1Jaune.CheckedChanged += rdoJ1Jaune_CheckedChanged;
            // 
            // txtInputJ2
            // 
            txtInputJ2.Location = new Point(114, 111);
            txtInputJ2.Margin = new Padding(3, 2, 3, 2);
            txtInputJ2.Name = "txtInputJ2";
            txtInputJ2.Size = new Size(154, 31);
            txtInputJ2.TabIndex = 5;
            txtInputJ2.Text = "Joueur 2";
            txtInputJ2.TextAlign = HorizontalAlignment.Center;
            // 
            // lblJ2
            // 
            lblJ2.AutoSize = true;
            lblJ2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJ2.Location = new Point(20, 111);
            lblJ2.Name = "lblJ2";
            lblJ2.Size = new Size(83, 25);
            lblJ2.TabIndex = 4;
            lblJ2.Text = "Joueur 2:";
            // 
            // txtInputJ1
            // 
            txtInputJ1.Location = new Point(114, 49);
            txtInputJ1.Margin = new Padding(3, 2, 3, 2);
            txtInputJ1.Name = "txtInputJ1";
            txtInputJ1.Size = new Size(154, 31);
            txtInputJ1.TabIndex = 4;
            txtInputJ1.Text = "Joueur 1";
            txtInputJ1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblJ1
            // 
            lblJ1.AutoSize = true;
            lblJ1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJ1.Location = new Point(20, 49);
            lblJ1.Name = "lblJ1";
            lblJ1.Size = new Size(83, 25);
            lblJ1.TabIndex = 3;
            lblJ1.Text = "Joueur 1:";
            // 
            // grpPartie
            // 
            grpPartie.Controls.Add(cmbTailleGrille);
            grpPartie.Controls.Add(rdoJ2);
            grpPartie.Controls.Add(rdoJ1);
            grpPartie.Controls.Add(lbl1erJoueur);
            grpPartie.Controls.Add(lblTaillePartie);
            grpPartie.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            grpPartie.Location = new Point(78, 293);
            grpPartie.Margin = new Padding(3, 2, 3, 2);
            grpPartie.Name = "grpPartie";
            grpPartie.Padding = new Padding(3, 2, 3, 2);
            grpPartie.Size = new Size(475, 168);
            grpPartie.TabIndex = 10;
            grpPartie.TabStop = false;
            grpPartie.Text = "La Partie";
            // 
            // cmbTailleGrille
            // 
            cmbTailleGrille.FormattingEnabled = true;
            cmbTailleGrille.Items.AddRange(new object[] { "6*7", "7*8", "8*9" });
            cmbTailleGrille.Location = new Point(266, 43);
            cmbTailleGrille.Margin = new Padding(3, 2, 3, 2);
            cmbTailleGrille.Name = "cmbTailleGrille";
            cmbTailleGrille.Size = new Size(70, 31);
            cmbTailleGrille.TabIndex = 10;
            cmbTailleGrille.Tag = "";
            cmbTailleGrille.Text = "Taille";
            // 
            // rdoJ2
            // 
            rdoJ2.AutoSize = true;
            rdoJ2.Location = new Point(368, 112);
            rdoJ2.Margin = new Padding(3, 2, 3, 2);
            rdoJ2.Name = "rdoJ2";
            rdoJ2.Size = new Size(97, 29);
            rdoJ2.TabIndex = 9;
            rdoJ2.TabStop = true;
            rdoJ2.Text = "Joueur 2";
            rdoJ2.UseVisualStyleBackColor = true;
            // 
            // rdoJ1
            // 
            rdoJ1.AutoSize = true;
            rdoJ1.Checked = true;
            rdoJ1.Location = new Point(266, 112);
            rdoJ1.Margin = new Padding(3, 2, 3, 2);
            rdoJ1.Name = "rdoJ1";
            rdoJ1.Size = new Size(97, 29);
            rdoJ1.TabIndex = 8;
            rdoJ1.TabStop = true;
            rdoJ1.Text = "Joueur 1";
            rdoJ1.UseVisualStyleBackColor = true;
            // 
            // lbl1erJoueur
            // 
            lbl1erJoueur.AutoSize = true;
            lbl1erJoueur.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1erJoueur.Location = new Point(20, 111);
            lbl1erJoueur.Name = "lbl1erJoueur";
            lbl1erJoueur.Size = new Size(222, 25);
            lbl1erJoueur.TabIndex = 4;
            lbl1erJoueur.Text = "Joueur a jouer en premier :";
            // 
            // lblTaillePartie
            // 
            lblTaillePartie.AutoSize = true;
            lblTaillePartie.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaillePartie.Location = new Point(20, 49);
            lblTaillePartie.Name = "lblTaillePartie";
            lblTaillePartie.Size = new Size(144, 25);
            lblTaillePartie.TabIndex = 3;
            lblTaillePartie.Text = "Taille de la grille :";
            // 
            // lblParametrage
            // 
            lblParametrage.AutoSize = true;
            lblParametrage.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblParametrage.Location = new Point(160, 41);
            lblParametrage.Name = "lblParametrage";
            lblParametrage.Size = new Size(308, 37);
            lblParametrage.TabIndex = 11;
            lblParametrage.Text = "Parametrage de la partie";
            // 
            // btnCommencer
            // 
            btnCommencer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCommencer.Location = new Point(450, 476);
            btnCommencer.Name = "btnCommencer";
            btnCommencer.Size = new Size(162, 44);
            btnCommencer.TabIndex = 12;
            btnCommencer.Text = "Commencer";
            btnCommencer.UseVisualStyleBackColor = true;
            btnCommencer.Click += btnCommencer_Click;
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetour.Location = new Point(31, 476);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(104, 44);
            btnRetour.TabIndex = 17;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // Parametrage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 540);
            Controls.Add(btnRetour);
            Controls.Add(btnCommencer);
            Controls.Add(lblParametrage);
            Controls.Add(grpPartie);
            Controls.Add(grpJoueurs);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Parametrage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4 -Parametrage";
            grpJoueurs.ResumeLayout(false);
            grpJoueurs.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlJ1.ResumeLayout(false);
            pnlJ1.PerformLayout();
            grpPartie.ResumeLayout(false);
            grpPartie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpJoueurs;
        private RadioButton rdoJ1Jaune;
        private RadioButton rdoJ1Rouge;
        private TextBox txtInputJ2;
        private Label lblJ2;
        private TextBox txtInputJ1;
        private Label lblJ1;
        private GroupBox grpPartie;
        private RadioButton rdoJ2;
        private RadioButton rdoJ1;
        private Label lbl1erJoueur;
        private Label lblTaillePartie;
        private Panel panel1;
        private RadioButton rdoJ2Rouge;
        private RadioButton rdoJ2Jaune;
        private Panel pnlJ1;
        private ComboBox cmbTailleGrille;
        private Label lblParametrage;
        private Button btnCommencer;
        private Button btnRetour;
    }
}