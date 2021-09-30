
namespace Pet_Shop
{
    partial class Frm_Inicio
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
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_Pet = new System.Windows.Forms.Label();
            this.lbl_Rangos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(274, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = " SHOP";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pet_Shop.Properties.Resources.huella;
            this.pictureBox3.Location = new System.Drawing.Point(251, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 157);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_Pet
            // 
            this.lbl_Pet.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pet.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbl_Pet.Location = new System.Drawing.Point(277, 54);
            this.lbl_Pet.Name = "lbl_Pet";
            this.lbl_Pet.Size = new System.Drawing.Size(108, 41);
            this.lbl_Pet.TabIndex = 11;
            this.lbl_Pet.Text = "  PET ";
            // 
            // lbl_Rangos
            // 
            this.lbl_Rangos.AutoSize = true;
            this.lbl_Rangos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Rangos.Location = new System.Drawing.Point(33, 39);
            this.lbl_Rangos.Name = "lbl_Rangos";
            this.lbl_Rangos.Size = new System.Drawing.Size(10, 15);
            this.lbl_Rangos.TabIndex = 13;
            this.lbl_Rangos.Text = ".";
            this.lbl_Rangos.Visible = false;
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(702, 364);
            this.Controls.Add(this.lbl_Rangos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_Pet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Inicio";
            this.Text = "Frm_Inicio";
            this.Load += new System.EventHandler(this.Frm_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_Pet;
        public System.Windows.Forms.Label lbl_Rangos;
    }
}