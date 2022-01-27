
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
            this.Txt_Recherche = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmd_Recherche = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(144, 21);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox1.Size = new System.Drawing.Size(514, 58);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(470, 29);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "GESTION DES MEMBRES [MODIFIER]";
            // 
            // Txt_Recherche
            // 
            this.Txt_Recherche.Location = new System.Drawing.Point(185, 172);
            this.Txt_Recherche.Name = "Txt_Recherche";
            this.Txt_Recherche.Size = new System.Drawing.Size(254, 22);
            this.Txt_Recherche.TabIndex = 15;
            this.Txt_Recherche.TextChanged += new System.EventHandler(this.Txt_Recherche_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(249, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(254, 58);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Recherche :";
            // 
            // Cmd_Recherche
            // 
            this.Cmd_Recherche.BackgroundImage = global::PROJET_PPE2._1_KARATE.Properties.Resources.recherche;
            this.Cmd_Recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cmd_Recherche.Location = new System.Drawing.Point(445, 146);
            this.Cmd_Recherche.Name = "Cmd_Recherche";
            this.Cmd_Recherche.Size = new System.Drawing.Size(82, 74);
            this.Cmd_Recherche.TabIndex = 17;
            this.Cmd_Recherche.UseVisualStyleBackColor = true;
            this.Cmd_Recherche.Click += new System.EventHandler(this.Cmd_Recherche_Click);
            // 
            // Frm_GestionMembre_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cmd_Recherche);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Txt_Recherche);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Frm_GestionMembre_M";
            this.Text = "Frm_GestionMembre_M";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Txt_Recherche;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cmd_Recherche;
    }
}