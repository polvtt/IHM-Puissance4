namespace Puissance4
{
    partial class ModeDeJeu
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
            btn1v1 = new Button();
            btnIa = new Button();
            lblChoixMode = new Label();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // btn1v1
            // 
            btn1v1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1v1.Location = new Point(125, 203);
            btn1v1.Name = "btn1v1";
            btn1v1.Size = new Size(111, 69);
            btn1v1.TabIndex = 13;
            btn1v1.Text = "1 vs 1";
            btn1v1.UseVisualStyleBackColor = true;
            btn1v1.Click += btn1v1_Click;
            // 
            // btnIa
            // 
            btnIa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnIa.Location = new Point(366, 203);
            btnIa.Name = "btnIa";
            btnIa.Size = new Size(111, 69);
            btnIa.TabIndex = 14;
            btnIa.Text = "1 vs AI";
            btnIa.UseVisualStyleBackColor = true;
            btnIa.Click += btnIa_Click;
            // 
            // lblChoixMode
            // 
            lblChoixMode.AutoSize = true;
            lblChoixMode.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblChoixMode.Location = new Point(138, 86);
            lblChoixMode.Name = "lblChoixMode";
            lblChoixMode.Size = new Size(322, 37);
            lblChoixMode.TabIndex = 15;
            lblChoixMode.Text = "Choisissez le mode de jeu";
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetour.Location = new Point(28, 387);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(99, 40);
            btnRetour.TabIndex = 16;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // ModeDeJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 452);
            Controls.Add(btnRetour);
            Controls.Add(lblChoixMode);
            Controls.Add(btnIa);
            Controls.Add(btn1v1);
            Name = "ModeDeJeu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Puissance 4 -Parametrage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1v1;
        private Button btnIa;
        private Label lblChoixMode;
        private Button btnRetour;
    }
}