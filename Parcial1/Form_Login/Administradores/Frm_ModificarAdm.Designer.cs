
namespace Pet_Shop
{
    partial class Frm_ModificarAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificarAdm));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Aviso = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(119, 24);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(144, 37);
            this.lbl_Titulo.TabIndex = 18;
            this.lbl_Titulo.Text = "PET SHOP";
            // 
            // txt_ConfirmarPassword
            // 
            this.txt_ConfirmarPassword.Location = new System.Drawing.Point(86, 205);
            this.txt_ConfirmarPassword.Name = "txt_ConfirmarPassword";
            this.txt_ConfirmarPassword.PlaceholderText = "Confirme nueva contraseña";
            this.txt_ConfirmarPassword.Size = new System.Drawing.Size(213, 23);
            this.txt_ConfirmarPassword.TabIndex = 15;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(148, 244);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(314, 279);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 17;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(86, 175);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Ingrese nueva contraseña";
            this.txt_Password.Size = new System.Drawing.Size(213, 23);
            this.txt_Password.TabIndex = 14;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(86, 143);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "Ingrese nuevo DNI";
            this.txt_Dni.Size = new System.Drawing.Size(213, 23);
            this.txt_Dni.TabIndex = 12;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(86, 111);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Ingrese nuevo apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(213, 23);
            this.txt_Apellido.TabIndex = 11;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(86, 81);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nuevo nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(213, 23);
            this.txt_Nombre.TabIndex = 10;
            // 
            // lbl_Aviso
            // 
            this.lbl_Aviso.AutoSize = true;
            this.lbl_Aviso.Location = new System.Drawing.Point(6, 283);
            this.lbl_Aviso.Name = "lbl_Aviso";
            this.lbl_Aviso.Size = new System.Drawing.Size(293, 15);
            this.lbl_Aviso.TabIndex = 19;
            this.lbl_Aviso.Text = "Aviso: Los datos que no se modifiquen se mantendran";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(6, 9);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(50, 15);
            this.lbl_User.TabIndex = 20;
            this.lbl_User.Text = "Usuario:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(52, 9);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(14, 15);
            this.lbl_Usuario.TabIndex = 21;
            this.lbl_Usuario.Text = "X";
            // 
            // Frm_ModificarAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(401, 307);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Aviso);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_ConfirmarPassword);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_ConfirmarPassword;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Aviso;
        private System.Windows.Forms.Label lbl_User;
        public System.Windows.Forms.Label lbl_Usuario;
    }
}