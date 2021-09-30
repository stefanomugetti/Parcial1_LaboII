
namespace Pet_Shop
{
    partial class Frm_ModificarCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificarCli));
            this.lbl_IdCli = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Aviso = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.txt_Saldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_IdCli
            // 
            this.lbl_IdCli.AutoSize = true;
            this.lbl_IdCli.Location = new System.Drawing.Point(64, 7);
            this.lbl_IdCli.Name = "lbl_IdCli";
            this.lbl_IdCli.Size = new System.Drawing.Size(14, 15);
            this.lbl_IdCli.TabIndex = 32;
            this.lbl_IdCli.Text = "X";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(9, 7);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(59, 15);
            this.lbl_Id.TabIndex = 31;
            this.lbl_Id.Text = "ID cliente:";
            // 
            // lbl_Aviso
            // 
            this.lbl_Aviso.AutoSize = true;
            this.lbl_Aviso.Location = new System.Drawing.Point(9, 281);
            this.lbl_Aviso.Name = "lbl_Aviso";
            this.lbl_Aviso.Size = new System.Drawing.Size(293, 15);
            this.lbl_Aviso.TabIndex = 30;
            this.lbl_Aviso.Text = "Aviso: Los datos que no se modifiquen se mantendran";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(122, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(144, 37);
            this.lbl_Titulo.TabIndex = 29;
            this.lbl_Titulo.Text = "PET SHOP";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(151, 242);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 27;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(317, 277);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 28;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(89, 141);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "Ingrese nuevo DNI";
            this.txt_Dni.Size = new System.Drawing.Size(213, 23);
            this.txt_Dni.TabIndex = 24;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(89, 109);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Ingrese nuevo apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(213, 23);
            this.txt_Apellido.TabIndex = 23;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(89, 79);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nuevo nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(213, 23);
            this.txt_Nombre.TabIndex = 22;
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(89, 173);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.PlaceholderText = "Ingrese nueva edad";
            this.txt_Edad.Size = new System.Drawing.Size(213, 23);
            this.txt_Edad.TabIndex = 25;
            // 
            // txt_Saldo
            // 
            this.txt_Saldo.Location = new System.Drawing.Point(89, 203);
            this.txt_Saldo.Name = "txt_Saldo";
            this.txt_Saldo.PlaceholderText = "Confirme nuevo saldo";
            this.txt_Saldo.Size = new System.Drawing.Size(213, 23);
            this.txt_Saldo.TabIndex = 26;
            // 
            // Frm_ModificarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(401, 307);
            this.Controls.Add(this.lbl_IdCli);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Aviso);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Saldo);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_IdCli;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Aviso;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.TextBox txt_Saldo;
    }
}