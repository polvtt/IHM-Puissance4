namespace Puissance4
{
    partial class Accueil
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
            lblPuissance4 = new Label();
            btnJouer = new Button();
            btnQuitter = new Button();
            SuspendLayout();
            // 
            // lblPuissance4
            // 
            lblPuissance4.AutoSize = true;
            lblPuissance4.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuissance4.Location = new Point(96, 47);
            lblPuissance4.Name = "lblPuissance4";
            lblPuissance4.Size = new Size(209, 47);
            lblPuissance4.TabIndex = 0;
            lblPuissance4.Text = "Puissance 4";
            // 
            // btnJouer
            // 
            btnJouer.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnJouer.Location = new Point(116, 131);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(172, 50);
            btnJouer.TabIndex = 1;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = true;
            btnJouer.Click += btnJouer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(152, 202);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(99, 36);
            btnQuitter.TabIndex = 2;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 322);
            Controls.Add(btnQuitter);
            Controls.Add(btnJouer);
            Controls.Add(lblPuissance4);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuissance4;
        private Button btnJouer;
        private Button btnQuitter;
    }
}