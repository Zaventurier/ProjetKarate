﻿
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionMembre_M
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Grid_Membre = new System.Windows.Forms.DataGridView();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_NAISSANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Ville = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_CodePostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Adresse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_DateNaissance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Prenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_NumClub = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NumLiscence = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VILLE_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(262, 2);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Size = new System.Drawing.Size(703, 58);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(642, 29);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "GESTION DES MEMBRES [MODIFIER / SUPPRIMER]";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Grid_Membre);
            this.groupBox3.Location = new System.Drawing.Point(12, 145);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1208, 316);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // Grid_Membre
            // 
            this.Grid_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Membre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_LICENCE,
            this.NUM_CLUB,
            this.NOM_MEMBRE,
            this.PRENOM_MEMBRE,
            this.DATE_NAISSANCE,
            this.ADR_RUE_MEMBRE,
            this.CODE_POST_MEMBRE,
            this.ADR_VILLE_MEMBRE});
            this.Grid_Membre.Location = new System.Drawing.Point(54, 34);
            this.Grid_Membre.Name = "Grid_Membre";
            this.Grid_Membre.RowHeadersWidth = 51;
            this.Grid_Membre.RowTemplate.Height = 24;
            this.Grid_Membre.Size = new System.Drawing.Size(1078, 259);
            this.Grid_Membre.TabIndex = 22;
            this.Grid_Membre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 6;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 125;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 6;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 125;
            // 
            // NOM_MEMBRE
            // 
            this.NOM_MEMBRE.HeaderText = "NOM_MEMBRE";
            this.NOM_MEMBRE.MinimumWidth = 6;
            this.NOM_MEMBRE.Name = "NOM_MEMBRE";
            this.NOM_MEMBRE.Width = 125;
            // 
            // PRENOM_MEMBRE
            // 
            this.PRENOM_MEMBRE.HeaderText = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.MinimumWidth = 6;
            this.PRENOM_MEMBRE.Name = "PRENOM_MEMBRE";
            this.PRENOM_MEMBRE.Width = 125;
            // 
            // DATE_NAISSANCE
            // 
            this.DATE_NAISSANCE.HeaderText = "DATE_NAISSANCE";
            this.DATE_NAISSANCE.MinimumWidth = 6;
            this.DATE_NAISSANCE.Name = "DATE_NAISSANCE";
            this.DATE_NAISSANCE.Width = 125;
            // 
            // ADR_RUE_MEMBRE
            // 
            this.ADR_RUE_MEMBRE.HeaderText = "ADR_RUE_MEMBRE";
            this.ADR_RUE_MEMBRE.MinimumWidth = 6;
            this.ADR_RUE_MEMBRE.Name = "ADR_RUE_MEMBRE";
            this.ADR_RUE_MEMBRE.Width = 125;
            // 
            // CODE_POST_MEMBRE
            // 
            this.CODE_POST_MEMBRE.HeaderText = "CODE_POST_MEMBRE";
            this.CODE_POST_MEMBRE.MinimumWidth = 6;
            this.CODE_POST_MEMBRE.Name = "CODE_POST_MEMBRE";
            this.CODE_POST_MEMBRE.Width = 125;
            // 
            // ADR_VILLE_MEMBRE
            // 
            this.ADR_VILLE_MEMBRE.HeaderText = "ADR_VILLE_MEMBRE";
            this.ADR_VILLE_MEMBRE.MinimumWidth = 6;
            this.ADR_VILLE_MEMBRE.Name = "ADR_VILLE_MEMBRE";
            this.ADR_VILLE_MEMBRE.Width = 125;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.Txt_Ville);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.Txt_CodePostal);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.Txt_Adresse);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.Txt_DateNaissance);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.Txt_Prenom);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.Txt_Nom);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.Txt_NumClub);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.Txt_NumLiscence);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(1268, 90);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(434, 542);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Ville :";
            // 
            // Txt_Ville
            // 
            this.Txt_Ville.Location = new System.Drawing.Point(194, 406);
            this.Txt_Ville.Name = "Txt_Ville";
            this.Txt_Ville.Size = new System.Drawing.Size(225, 22);
            this.Txt_Ville.TabIndex = 16;
            this.Txt_Ville.TextChanged += new System.EventHandler(this.Txt_Ville_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Code postal :";
            // 
            // Txt_CodePostal
            // 
            this.Txt_CodePostal.Location = new System.Drawing.Point(194, 356);
            this.Txt_CodePostal.Name = "Txt_CodePostal";
            this.Txt_CodePostal.Size = new System.Drawing.Size(225, 22);
            this.Txt_CodePostal.TabIndex = 14;
            this.Txt_CodePostal.TextChanged += new System.EventHandler(this.Txt_CodePostal_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Adresse :";
            // 
            // Txt_Adresse
            // 
            this.Txt_Adresse.Location = new System.Drawing.Point(194, 303);
            this.Txt_Adresse.Name = "Txt_Adresse";
            this.Txt_Adresse.Size = new System.Drawing.Size(225, 22);
            this.Txt_Adresse.TabIndex = 12;
            this.Txt_Adresse.TextChanged += new System.EventHandler(this.Txt_Adresse_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Date de naissance :";
            // 
            // Txt_DateNaissance
            // 
            this.Txt_DateNaissance.Location = new System.Drawing.Point(194, 250);
            this.Txt_DateNaissance.Name = "Txt_DateNaissance";
            this.Txt_DateNaissance.Size = new System.Drawing.Size(225, 22);
            this.Txt_DateNaissance.TabIndex = 10;
            this.Txt_DateNaissance.TextChanged += new System.EventHandler(this.Txt_DateNaissance_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Prénom :";
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.Location = new System.Drawing.Point(194, 198);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(225, 22);
            this.Txt_Prenom.TabIndex = 8;
            this.Txt_Prenom.TextChanged += new System.EventHandler(this.Txt_Prenom_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nom :";
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(194, 141);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(225, 22);
            this.Txt_Nom.TabIndex = 6;
            this.Txt_Nom.TextChanged += new System.EventHandler(this.Txt_Nom_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numéro Club :";
            // 
            // Txt_NumClub
            // 
            this.Txt_NumClub.Location = new System.Drawing.Point(194, 87);
            this.Txt_NumClub.Name = "Txt_NumClub";
            this.Txt_NumClub.Size = new System.Drawing.Size(225, 22);
            this.Txt_NumClub.TabIndex = 4;
            this.Txt_NumClub.TextChanged += new System.EventHandler(this.Txt_NumClub_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numéro Liscence :";
            // 
            // Txt_NumLiscence
            // 
            this.Txt_NumLiscence.Location = new System.Drawing.Point(194, 36);
            this.Txt_NumLiscence.Name = "Txt_NumLiscence";
            this.Txt_NumLiscence.Size = new System.Drawing.Size(225, 22);
            this.Txt_NumLiscence.TabIndex = 2;
            this.Txt_NumLiscence.TextChanged += new System.EventHandler(this.Txt_NumLiscence_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(227, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 62);
            this.button3.TabIndex = 1;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 0;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(622, 499);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(615, 403);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NOM_CLUB,
            this.VILLE_CLUB});
            this.dataGridView1.Location = new System.Drawing.Point(20, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 345);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NUM_CLUB";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // NOM_CLUB
            // 
            this.NOM_CLUB.HeaderText = "NOM_CLUB";
            this.NOM_CLUB.MinimumWidth = 6;
            this.NOM_CLUB.Name = "NOM_CLUB";
            this.NOM_CLUB.Width = 125;
            // 
            // VILLE_CLUB
            // 
            this.VILLE_CLUB.HeaderText = "VILLE_CLUB";
            this.VILLE_CLUB.MinimumWidth = 6;
            this.VILLE_CLUB.Name = "VILLE_CLUB";
            this.VILLE_CLUB.Width = 125;
            // 
            // Frm_GestionMembre_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Frm_GestionMembre_M";
            this.Text = "Frm_GestionMembre_M";
            this.Load += new System.EventHandler(this.Frm_GestionMembre_M_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_NumClub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_NumLiscence;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Ville;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_CodePostal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Adresse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_DateNaissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Prenom;
        private System.Windows.Forms.DataGridView Grid_Membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_NAISSANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_MEMBRE;
        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn VILLE_CLUB;
    }
}