using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Création d'une liste de tableaux (nom, âge) 
            List<string[]> personnes = new List<string[]>
            {
                new string[] { "Alice", "25" },
                new string[] { "Bob", "30" },
                new string[] { "Charlie", "35" }
            };
            // Convertir en DataTable pour le lier à la DataGridView 
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nom");
            dataTable.Columns.Add("Age");
            foreach (string[] personne in personnes)
            {
                dataTable.Rows.Add(personne[0], personne[1]);
            }
            // Liaison de la DataGridView au DataTable 
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //récuper les valeur de txtNom et txtEmail
            //Afficher ces valeurs dans une MessageBox
            string nom = txtNom.Text;
            string email = txtEmail.Text;

            if (nom == "" || email == "")
            {
                MessageBox.Show("Veuillez compléter tout les champs");
            }
            else
            {
                MessageBox.Show($"Nom : {nom}\nEmail : {email}", "Informations Utilisateur");
            }


        }

        private void label3_TextChanged(object sender, EventArgs e)
        {
            if(!txtEmail.Text.Contains("@"))
            {
                this.label3.Visible = false;
            }
            else
            {
                this.label3.Visible = true;
            }
        }
    }
}
