
namespace Pet_Shop
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.cmb_TipoLogin = new System.Windows.Forms.ComboBox();
            this.lbl_IngresarComo = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(94, 100);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(260, 23);
            this.txt_Usuario.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(94, 140);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Ingrese password";
            this.txt_Password.Size = new System.Drawing.Size(260, 23);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(152, 178);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Location = new System.Drawing.Point(360, 140);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(71, 23);
            this.btn_Autocompletar.TabIndex = 4;
            this.btn_Autocompletar.Text = "Completar";
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click);
            // 
            // cmb_TipoLogin
            // 
            this.cmb_TipoLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoLogin.FormattingEnabled = true;
            this.cmb_TipoLogin.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cmb_TipoLogin.Location = new System.Drawing.Point(219, 69);
            this.cmb_TipoLogin.Name = "cmb_TipoLogin";
            this.cmb_TipoLogin.Size = new System.Drawing.Size(135, 23);
            this.cmb_TipoLogin.TabIndex = 1;
            // 
            // lbl_IngresarComo
            // 
            this.lbl_IngresarComo.AutoSize = true;
            this.lbl_IngresarComo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IngresarComo.Location = new System.Drawing.Point(94, 69);
            this.lbl_IngresarComo.Name = "lbl_IngresarComo";
            this.lbl_IngresarComo.Size = new System.Drawing.Size(111, 20);
            this.lbl_IngresarComo.TabIndex = 5;
            this.lbl_IngresarComo.Text = "Ingresar como:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(166, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(144, 37);
            this.lbl_Titulo.TabIndex = 6;
            this.lbl_Titulo.Text = "PET SHOP";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(488, 214);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_IngresarComo);
            this.Controls.Add(this.cmb_TipoLogin);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Autocompletar;
        private System.Windows.Forms.Label lbl_IngresarComo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cmb_TipoLogin;
    }
}

