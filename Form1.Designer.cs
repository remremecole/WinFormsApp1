namespace WinFormsApp1
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
            btnAjouterContact = new Button();
            label1 = new Label();
            txtNom = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAjouterContact
            // 
            btnAjouterContact.BackColor = SystemColors.ButtonHighlight;
            btnAjouterContact.ForeColor = SystemColors.Desktop;
            btnAjouterContact.Location = new Point(36, 194);
            btnAjouterContact.Name = "btnAjouterContact";
            btnAjouterContact.Size = new Size(356, 42);
            btnAjouterContact.TabIndex = 0;
            btnAjouterContact.Text = "Ajouter un contact";
            btnAjouterContact.UseVisualStyleBackColor = false;
            btnAjouterContact.Click += button1_Click;
            // 
            // label1
            // 
            label1.AccessibleName = "Label1";
            label1.AutoSize = true;
            label1.Location = new Point(36, 135);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "adresse mail :";
            // 
            // txtNom
            // 
            txtNom.AccessibleName = "txtNom";
            txtNom.Location = new Point(159, 62);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(233, 31);
            txtNom.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.AccessibleDescription = "";
            txtEmail.AccessibleName = "txtEmail";
            txtEmail.Location = new Point(159, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 31);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 4;
            label2.Text = "Nom :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNom);
            groupBox1.Controls.Add(btnAjouterContact);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(65, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 295);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(398, 135);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 5;
            label3.Text = "Format invalide";
            label3.Visible = false;
            label3.TextChanged += label3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(785, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(374, 295);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Nouvelle App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAjouterContact;
        private Label label1;
        private TextBox txtNom;
        private TextBox txtEmail;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
