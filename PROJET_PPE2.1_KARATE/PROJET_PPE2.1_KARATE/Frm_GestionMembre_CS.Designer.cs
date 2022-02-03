
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_GestionMembre_CS
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid_Membre = new System.Windows.Forms.DataGridView();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRENOM_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_NAISSANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_RUE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODE_POST_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR_VILLE_MEMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PhotoMembre = new System.Windows.Forms.PictureBox();
            this.lbl_NumLicence = new System.Windows.Forms.Label();
            this.lbl_PrenomMembre = new System.Windows.Forms.Label();
            this.lbl_NumLiscence = new System.Windows.Forms.Label();
            this.lbl_NomMembre = new System.Windows.Forms.Label();
            this.lbl_DateNaissance = new System.Windows.Forms.Label();
            this.lbl_AdresseMembre = new System.Windows.Forms.Label();
            this.lbl_CodePostal = new System.Windows.Forms.Label();
            this.lbl_VilleMembre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_NumClub = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(174, 11);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Size = new System.Drawing.Size(813, 58);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(741, 29);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "GESTION DES MEMBRES [CONSULTATION DES LICENCES]";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Refresh);
            this.groupBox2.Controls.Add(this.Grid_Membre);
            this.groupBox2.Location = new System.Drawing.Point(46, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1132, 389);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
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
            this.Grid_Membre.Location = new System.Drawing.Point(27, 83);
            this.Grid_Membre.Name = "Grid_Membre";
            this.Grid_Membre.RowHeadersWidth = 51;
            this.Grid_Membre.RowTemplate.Height = 24;
            this.Grid_Membre.Size = new System.Drawing.Size(1078, 259);
            this.Grid_Membre.TabIndex = 23;
            this.Grid_Membre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Membre_CellContentClick);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_NumClub);
            this.groupBox3.Controls.Add(this.lbl_NumLiscence);
            this.groupBox3.Controls.Add(this.lbl_NomMembre);
            this.groupBox3.Controls.Add(this.lbl_VilleMembre);
            this.groupBox3.Controls.Add(this.lbl_CodePostal);
            this.groupBox3.Controls.Add(this.lbl_AdresseMembre);
            this.groupBox3.Controls.Add(this.lbl_DateNaissance);
            this.groupBox3.Controls.Add(this.lbl_PrenomMembre);
            this.groupBox3.Controls.Add(this.lbl_NumLicence);
            this.groupBox3.Controls.Add(this.PhotoMembre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1209, 104);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(602, 362);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackgroundImage = global::PROJET_PPE2._1_KARATE.Properties.Resources.refresh;
            this.Btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Refresh.Location = new System.Drawing.Point(249, 20);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(73, 57);
            this.Btn_Refresh.TabIndex = 23;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUMERO DE LICENCE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOM MEMBRE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "PRENOM MEMBRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "DATE NAISSANCE :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "ADRESSE MEMBRE :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "CODE POSTAL :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "VILLE MEMBRE :";
            // 
            // PhotoMembre
            // 
            this.PhotoMembre.Location = new System.Drawing.Point(346, 20);
            this.PhotoMembre.Name = "PhotoMembre";
            this.PhotoMembre.Size = new System.Drawing.Size(250, 310);
            this.PhotoMembre.TabIndex = 4;
            this.PhotoMembre.TabStop = false;
            // 
            // lbl_NumLicence
            // 
            this.lbl_NumLicence.AutoSize = true;
            this.lbl_NumLicence.Location = new System.Drawing.Point(190, 40);
            this.lbl_NumLicence.Name = "lbl_NumLicence";
            this.lbl_NumLicence.Size = new System.Drawing.Size(0, 17);
            this.lbl_NumLicence.TabIndex = 18;
            // 
            // lbl_PrenomMembre
            // 
            this.lbl_PrenomMembre.AutoSize = true;
            this.lbl_PrenomMembre.Location = new System.Drawing.Point(168, 123);
            this.lbl_PrenomMembre.Name = "lbl_PrenomMembre";
            this.lbl_PrenomMembre.Size = new System.Drawing.Size(0, 17);
            this.lbl_PrenomMembre.TabIndex = 18;
            this.lbl_PrenomMembre.Click += new System.EventHandler(this.lbl_PrenomMembre_Click);
            // 
            // lbl_NumLiscence
            // 
            this.lbl_NumLiscence.AutoSize = true;
            this.lbl_NumLiscence.Location = new System.Drawing.Point(185, 17);
            this.lbl_NumLiscence.Name = "lbl_NumLiscence";
            this.lbl_NumLiscence.Size = new System.Drawing.Size(0, 17);
            this.lbl_NumLiscence.TabIndex = 18;
            this.lbl_NumLiscence.Click += new System.EventHandler(this.lbl_NumLiscence_Click);
            // 
            // lbl_NomMembre
            // 
            this.lbl_NomMembre.AutoSize = true;
            this.lbl_NomMembre.Location = new System.Drawing.Point(140, 83);
            this.lbl_NomMembre.Name = "lbl_NomMembre";
            this.lbl_NomMembre.Size = new System.Drawing.Size(0, 17);
            this.lbl_NomMembre.TabIndex = 18;
            this.lbl_NomMembre.Click += new System.EventHandler(this.lbl_NomMembre_Click);
            // 
            // lbl_DateNaissance
            // 
            this.lbl_DateNaissance.AutoSize = true;
            this.lbl_DateNaissance.Location = new System.Drawing.Point(163, 157);
            this.lbl_DateNaissance.Name = "lbl_DateNaissance";
            this.lbl_DateNaissance.Size = new System.Drawing.Size(0, 17);
            this.lbl_DateNaissance.TabIndex = 18;
            this.lbl_DateNaissance.Click += new System.EventHandler(this.lbl_DateNaissance_Click);
            // 
            // lbl_AdresseMembre
            // 
            this.lbl_AdresseMembre.AutoSize = true;
            this.lbl_AdresseMembre.Location = new System.Drawing.Point(173, 193);
            this.lbl_AdresseMembre.Name = "lbl_AdresseMembre";
            this.lbl_AdresseMembre.Size = new System.Drawing.Size(0, 17);
            this.lbl_AdresseMembre.TabIndex = 18;
            this.lbl_AdresseMembre.Click += new System.EventHandler(this.lbl_AdresseMembre_Click);
            // 
            // lbl_CodePostal
            // 
            this.lbl_CodePostal.AutoSize = true;
            this.lbl_CodePostal.Location = new System.Drawing.Point(143, 225);
            this.lbl_CodePostal.Name = "lbl_CodePostal";
            this.lbl_CodePostal.Size = new System.Drawing.Size(0, 17);
            this.lbl_CodePostal.TabIndex = 18;
            this.lbl_CodePostal.Click += new System.EventHandler(this.lbl_CodePostal_Click);
            // 
            // lbl_VilleMembre
            // 
            this.lbl_VilleMembre.AutoSize = true;
            this.lbl_VilleMembre.Location = new System.Drawing.Point(145, 258);
            this.lbl_VilleMembre.Name = "lbl_VilleMembre";
            this.lbl_VilleMembre.Size = new System.Drawing.Size(0, 17);
            this.lbl_VilleMembre.TabIndex = 18;
            this.lbl_VilleMembre.Click += new System.EventHandler(this.lbl_VilleMembre_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "NUMERO DU CLUB :";
            // 
            // lbl_NumClub
            // 
            this.lbl_NumClub.AutoSize = true;
            this.lbl_NumClub.Location = new System.Drawing.Point(165, 49);
            this.lbl_NumClub.Name = "lbl_NumClub";
            this.lbl_NumClub.Size = new System.Drawing.Size(0, 17);
            this.lbl_NumClub.TabIndex = 18;
            this.lbl_NumClub.Click += new System.EventHandler(this.lbl_NumLiscence_Click);
            // 
            // Frm_GestionMembre_CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1847, 826);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Frm_GestionMembre_CS";
            this.Text = "Frm_GestionMembre_CS";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoMembre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_Membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRENOM_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_NAISSANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_RUE_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE_POST_MEMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR_VILLE_MEMBRE;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_PrenomMembre;
        private System.Windows.Forms.Label lbl_NumLicence;
        private System.Windows.Forms.PictureBox PhotoMembre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_NumLiscence;
        private System.Windows.Forms.Label lbl_NomMembre;
        private System.Windows.Forms.Label lbl_VilleMembre;
        private System.Windows.Forms.Label lbl_CodePostal;
        private System.Windows.Forms.Label lbl_AdresseMembre;
        private System.Windows.Forms.Label lbl_DateNaissance;
        private System.Windows.Forms.Label lbl_NumClub;
        private System.Windows.Forms.Label label9;
    }
}