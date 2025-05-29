using System;
using System.Windows.Forms;

namespace MediaTek86.View
{
    public partial class FormAbsences : Form
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAbsences;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnQuitter;

        public FormAbsences()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Initialisation des contrôles
            this.dgvAbsences = new DataGridView();
            this.btnAjouter = new Button();
            this.btnModifier = new Button();
            this.btnSupprimer = new Button();
            this.btnQuitter = new Button();

            // 
            // dgvAbsences
            // 
            this.dgvAbsences.Location = new System.Drawing.Point(20, 20);
            this.dgvAbsences.Size = new System.Drawing.Size(600, 300);
            this.dgvAbsences.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // btnAjouter
            // 
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Location = new System.Drawing.Point(650, 50);
            this.btnAjouter.Size = new System.Drawing.Size(100, 30);
            this.btnAjouter.Click += BtnAjouter_Click;

            // 
            // btnModifier
            // 
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Location = new System.Drawing.Point(650, 100);
            this.btnModifier.Size = new System.Drawing.Size(100, 30);
            this.btnModifier.Click += BtnModifier_Click;

            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Location = new System.Drawing.Point(650, 150);
            this.btnSupprimer.Size = new System.Drawing.Size(100, 30);
            this.btnSupprimer.Click += BtnSupprimer_Click;

            // 
            // btnQuitter
            // 
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.Location = new System.Drawing.Point(650, 200);
            this.btnQuitter.Size = new System.Drawing.Size(100, 30);
            this.btnQuitter.Click += BtnQuitter_Click;

            // 
            // FormAbsences
            // 
            this.Text = "Gestion des Absences";
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnQuitter);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajouter absence");
            // TODO: Ajouter la logique d'ajout
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                MessageBox.Show("Modifier absence sélectionnée");
                // TODO: Ajouter la logique de modification
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.");
            }
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Confirmez la suppression ?", "Suppression", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Absence supprimée");
                    // TODO: Ajouter la logique de suppression
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.");
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

