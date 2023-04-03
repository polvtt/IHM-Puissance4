namespace Puissance4
{
    partial class AI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI));
            grpAI = new GroupBox();
            btnIAIntermediaire = new Button();
            btnIADebutante = new Button();
            lblInformation = new Label();
            btnRetour = new Button();
            grpAI.SuspendLayout();
            SuspendLayout();
            // 
            // grpAI
            // 
            grpAI.Controls.Add(btnIAIntermediaire);
            grpAI.Controls.Add(btnIADebutante);
            grpAI.Location = new Point(41, 36);
            grpAI.Name = "grpAI";
            grpAI.Size = new Size(368, 111);
            grpAI.TabIndex = 1;
            grpAI.TabStop = false;
            grpAI.Text = "Intelligence Artificiel";
            // 
            // btnIAIntermediaire
            // 
            btnIAIntermediaire.Location = new Point(188, 41);
            btnIAIntermediaire.Name = "btnIAIntermediaire";
            btnIAIntermediaire.Size = new Size(135, 35);
            btnIAIntermediaire.TabIndex = 3;
            btnIAIntermediaire.Text = "IA intermediaire";
            btnIAIntermediaire.UseVisualStyleBackColor = true;
            btnIAIntermediaire.Click += btnIAIntermediaire_Click;
            // 
            // btnIADebutante
            // 
            btnIADebutante.Location = new Point(47, 41);
            btnIADebutante.Name = "btnIADebutante";
            btnIADebutante.Size = new Size(135, 35);
            btnIADebutante.TabIndex = 2;
            btnIADebutante.Text = "IA debutante";
            btnIADebutante.UseVisualStyleBackColor = true;
            btnIADebutante.Click += button1_Click;
            // 
            // lblInformation
            // 
            lblInformation.ForeColor = Color.Green;
            lblInformation.Location = new Point(41, 186);
            lblInformation.Name = "lblInformation";
            lblInformation.Size = new Size(368, 121);
            lblInformation.TabIndex = 2;
            lblInformation.Text = resources.GetString("lblInformation.Text");
            // 
            // btnRetour
            // 
            btnRetour.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetour.Location = new Point(12, 302);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(104, 44);
            btnRetour.TabIndex = 18;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // AI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 358);
            Controls.Add(btnRetour);
            Controls.Add(lblInformation);
            Controls.Add(grpAI);
            Name = "AI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI";
            grpAI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAI;
        private Button btnIADebutante;
        private Label lblInformation;
        private Button btnIAIntermediaire;
        private Button btnRetour;
    }
}