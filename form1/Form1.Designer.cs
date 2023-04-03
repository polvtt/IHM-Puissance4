namespace Puissance4
{
    partial class frmAccueil
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
            lblPuissance4 = new Label();
            btnJouer = new Button();
            btnQuitter = new Button();
            SuspendLayout();
            // 
            // lblPuissance4
            // 
            lblPuissance4.AutoSize = true;
            lblPuissance4.BackColor = Color.Transparent;
            lblPuissance4.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuissance4.ForeColor = Color.Black;
            lblPuissance4.Location = new Point(176, 62);
            lblPuissance4.Name = "lblPuissance4";
            lblPuissance4.Size = new Size(227, 51);
            lblPuissance4.TabIndex = 0;
            lblPuissance4.Text = "Puissance 4";
            // 
            // btnJouer
            // 
            btnJouer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnJouer.Location = new Point(160, 168);
            btnJouer.Margin = new Padding(3, 2, 3, 2);
            btnJouer.Name = "btnJouer";
            btnJouer.Size = new Size(256, 56);
            btnJouer.TabIndex = 1;
            btnJouer.Text = "Jouer";
            btnJouer.UseVisualStyleBackColor = true;
            btnJouer.Click += btnJouer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuitter.Location = new Point(228, 245);
            btnQuitter.Margin = new Padding(3, 2, 3, 2);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(115, 56);
            btnQuitter.TabIndex = 2;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // frmAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 383);
            Controls.Add(btnQuitter);
            Controls.Add(btnJouer);
            Controls.Add(lblPuissance4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAccueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuissance4;
        private Button btnJouer;
        private Button btnQuitter;
    }
}