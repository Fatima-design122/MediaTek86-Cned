using System;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class FormAccueil : Form
    {
        private Button btnGestionPersonnel;
        private Button btnGestionAbsences;
        private Button btnQuitter;
        private Label labelTitre;

        public FormAccueil()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnGestionPersonnel = new Button();
            this.btnGestionAbsences = new Button();
            this.btnQuitter = new Button();
            this.labelTitre = new Label();

            this.SuspendLayout();

            // 
            // btnGestionPersonnel
            // 
            this.btnGestionPersonnel.Location = new System.Drawing.Point(50, 80);
            this.btnGestionPersonnel.Name = "btnGestionPersonnel";
            this.btnGestionPersonnel.Size = new System.Drawing.Size(180, 40);
            this.btnGestionPersonnel.Text = "Gérer le personnel";
            this.btnGestionPersonnel.UseVisualStyleBackColor = true;
            this.btnGestionPersonnel.Click += new System.EventHandler(this.btnGestionPersonnel_Click);

            // 
            // btnGestionAbsences
            // 
            this.btnGestionAbsences.Location = new System.Drawing.Point(50, 130);
            this.btnGestionAbsences.Name = "btnGestionAbsences";
            this.btnGestionAbsences.Size = new System.Drawing.Size(180, 40);
            this.btnGestionAbsences.Text = "Gérer les absences";
            this.btnGestionAbsences.UseVisualStyleBackColor = true;
            this.btnGestionAbsences.Click += new System.EventHandler(this.btnGestionAbsences_Click);

            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(50, 180);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(180, 40);
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);

            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitre.Location = new System.Drawing.Point(45, 20);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(200, 30);
            this.labelTitre.Text = "Accueil MediaTek86";

            // 
            // FormAccueil
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnGestionAbsences);
            this.Controls.Add(this.btnGestionPersonnel);
            this.Name = "FormAccueil";
            this.Text = "Accueil";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnGestionPersonnel_Click(object sender, EventArgs e)
        {
            FormPersonnels formPersonnels = new FormPersonnels();
            formPersonnels.ShowDialog();
        }

        private void btnGestionAbsences_Click(object sender, EventArgs e)
        {
            FormAbsences formAbsences = new FormAbsences();
            formAbsences.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
