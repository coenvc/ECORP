namespace ECORP.GUI_s
{
    partial class MedewerkerOverzicht
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
            this.lbMedewerkers = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMedewerkers
            // 
            this.lbMedewerkers.FormattingEnabled = true;
            this.lbMedewerkers.Location = new System.Drawing.Point(12, 124);
            this.lbMedewerkers.Name = "lbMedewerkers";
            this.lbMedewerkers.Size = new System.Drawing.Size(1112, 407);
            this.lbMedewerkers.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 77);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Bewerken";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(6, 19);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(89, 23);
            this.btnVerwijderen.TabIndex = 2;
            this.btnVerwijderen.Text = "Verwijderderen ";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerwijderen);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Location = new System.Drawing.Point(968, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medewerker";
            // 
            // MedewerkerOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbMedewerkers);
            this.Name = "MedewerkerOverzicht";
            this.Text = "MedewerkerOverzicht";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMedewerkers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}