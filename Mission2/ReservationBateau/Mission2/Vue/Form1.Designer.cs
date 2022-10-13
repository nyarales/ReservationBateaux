
namespace Connecte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListBoxSecteur = new System.Windows.Forms.ListBox();
            this.ListBoxLiaison = new System.Windows.Forms.ListBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxSecteur
            // 
            this.ListBoxSecteur.BackColor = System.Drawing.Color.SandyBrown;
            this.ListBoxSecteur.FormattingEnabled = true;
            this.ListBoxSecteur.ItemHeight = 16;
            this.ListBoxSecteur.Location = new System.Drawing.Point(21, 31);
            this.ListBoxSecteur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxSecteur.Name = "ListBoxSecteur";
            this.ListBoxSecteur.Size = new System.Drawing.Size(359, 228);
            this.ListBoxSecteur.TabIndex = 0;
            this.ListBoxSecteur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxSecteur_MouseClick);
            // 
            // ListBoxLiaison
            // 
            this.ListBoxLiaison.BackColor = System.Drawing.Color.SandyBrown;
            this.ListBoxLiaison.FormattingEnabled = true;
            this.ListBoxLiaison.ItemHeight = 16;
            this.ListBoxLiaison.Location = new System.Drawing.Point(451, 31);
            this.ListBoxLiaison.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxLiaison.Name = "ListBoxLiaison";
            this.ListBoxLiaison.Size = new System.Drawing.Size(418, 228);
            this.ListBoxLiaison.TabIndex = 1;
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImage = global::Mission2.Properties.Resources.viper;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjout.Location = new System.Drawing.Point(21, 429);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(127, 52);
            this.btnAjout.TabIndex = 2;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.BackgroundImage = global::Mission2.Properties.Resources.viper;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModif.Location = new System.Drawing.Point(236, 429);
            this.btnModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(127, 52);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackgroundImage = global::Mission2.Properties.Resources.viper;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupp.Location = new System.Drawing.Point(451, 429);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(127, 52);
            this.btnSupp.TabIndex = 4;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::Mission2.Properties.Resources.viper;
            this.label1.Location = new System.Drawing.Point(13, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vous souhaitez :";
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(249, 486);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(100, 22);
            this.duree.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(193, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1540, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.ListBoxLiaison);
            this.Controls.Add(this.ListBoxSecteur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Interface admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxSecteur;
        private System.Windows.Forms.ListBox ListBoxLiaison;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.Label label2;
    }
}

