
namespace PROJET_PPE2._1_KARATE
{
    partial class acceuil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aJOUTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFIERSUPPRIMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTERLESLICENCESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fERMERAPPLICATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(159, 182);
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
            this.Label1.Location = new System.Drawing.Point(26, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(454, 29);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "GESTION DES MEMBRES - ACCEUIL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aJOUTERToolStripMenuItem,
            this.mODIFIERSUPPRIMERToolStripMenuItem,
            this.cONSULTERLESLICENCESToolStripMenuItem,
            this.fERMERAPPLICATIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aJOUTERToolStripMenuItem
            // 
            this.aJOUTERToolStripMenuItem.Name = "aJOUTERToolStripMenuItem";
            this.aJOUTERToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.aJOUTERToolStripMenuItem.Text = "AJOUTER";
            this.aJOUTERToolStripMenuItem.Click += new System.EventHandler(this.aJOUTERToolStripMenuItem_Click);
            // 
            // mODIFIERSUPPRIMERToolStripMenuItem
            // 
            this.mODIFIERSUPPRIMERToolStripMenuItem.Name = "mODIFIERSUPPRIMERToolStripMenuItem";
            this.mODIFIERSUPPRIMERToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.mODIFIERSUPPRIMERToolStripMenuItem.Text = "MODIFIER/SUPPRIMER";
            this.mODIFIERSUPPRIMERToolStripMenuItem.Click += new System.EventHandler(this.mODIFIERSUPPRIMERToolStripMenuItem_Click);
            // 
            // cONSULTERLESLICENCESToolStripMenuItem
            // 
            this.cONSULTERLESLICENCESToolStripMenuItem.Name = "cONSULTERLESLICENCESToolStripMenuItem";
            this.cONSULTERLESLICENCESToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.cONSULTERLESLICENCESToolStripMenuItem.Text = "CONSULTER LES LICENCES";
            this.cONSULTERLESLICENCESToolStripMenuItem.Click += new System.EventHandler(this.cONSULTERLESLICENCESToolStripMenuItem_Click);
            // 
            // fERMERAPPLICATIONToolStripMenuItem
            // 
            this.fERMERAPPLICATIONToolStripMenuItem.Name = "fERMERAPPLICATIONToolStripMenuItem";
            this.fERMERAPPLICATIONToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.fERMERAPPLICATIONToolStripMenuItem.Text = "FERMER APPLICATION";
            this.fERMERAPPLICATIONToolStripMenuItem.Click += new System.EventHandler(this.fERMERAPPLICATIONToolStripMenuItem_Click);
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "acceuil";
            this.Text = "acceuil";
            this.Load += new System.EventHandler(this.acceuil_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aJOUTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFIERSUPPRIMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTERLESLICENCESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fERMERAPPLICATIONToolStripMenuItem;
    }
}