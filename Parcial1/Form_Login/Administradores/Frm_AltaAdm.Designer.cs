
namespace Pet_Shop
{
    partial class Frm_AltaAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AltaAdm));
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(89, 70);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(202, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(89, 100);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Ingrese apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(202, 23);
            this.txt_Apellido.TabIndex = 1;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(89, 132);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "Ingrese DNI";
            this.txt_Dni.Size = new System.Drawing.Size(202, 23);
            this.txt_Dni.TabIndex = 2;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(89, 161);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(202, 23);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(89, 190);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Ingrese contraseña";
            this.txt_Password.Size = new System.Drawing.Size(202, 23);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(314, 272);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(156, 249);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_ConfirmarPassword
            // 
            this.txt_ConfirmarPassword.Location = new System.Drawing.Point(89, 220);
            this.txt_ConfirmarPassword.Name = "txt_ConfirmarPassword";
            this.txt_ConfirmarPassword.PlaceholderText = "Confirme contraseña";
            this.txt_ConfirmarPassword.Size = new System.Drawing.Size(202, 23);
            this.txt_ConfirmarPassword.TabIndex = 5;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(117, 20);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(144, 37);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "PET SHOP";
            // 
            // Frm_AltaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(401, 307);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_ConfirmarPassword);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_ConfirmarPassword;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}