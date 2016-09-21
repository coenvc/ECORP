namespace ECORP.GUI_s.Magazijn
{
    partial class Magazijn
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
            this.lbMagazijn = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.Opties = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Opties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMagazijn
            // 
            this.lbMagazijn.FormattingEnabled = true;
            this.lbMagazijn.Location = new System.Drawing.Point(12, 115);
            this.lbMagazijn.Name = "lbMagazijn";
            this.lbMagazijn.Size = new System.Drawing.Size(1031, 446);
            this.lbMagazijn.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(12, 73);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(56, 13);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Producten";
            // 
            // Opties
            // 
            this.Opties.Controls.Add(this.btnAdd);
            this.Opties.Controls.Add(this.btnRemove);
            this.Opties.Controls.Add(this.btnUpdate);
            this.Opties.Location = new System.Drawing.Point(843, 9);
            this.Opties.Name = "Opties";
            this.Opties.Size = new System.Drawing.Size(200, 100);
            this.Opties.TabIndex = 2;
            this.Opties.TabStop = false;
            this.Opties.Text = "Controls";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(6, 42);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(188, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(188, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Magazijn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 576);
            this.Controls.Add(this.Opties);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbMagazijn);
            this.Name = "Magazijn";
            this.Text = "Magazijn";
            this.Opties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMagazijn;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.GroupBox Opties;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
    }
}