
namespace Pet_Shop
{
    partial class Frm_AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AgregarProducto));
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.cmb_TipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(318, 278);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 11;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(161, 254);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(104, 75);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Ingrese nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(202, 23);
            this.txt_Nombre.TabIndex = 12;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(130, 25);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(144, 37);
            this.lbl_Titulo.TabIndex = 13;
            this.lbl_Titulo.Text = "PET SHOP";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(104, 192);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.PlaceholderText = "Ingrese cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(202, 23);
            this.txt_Cantidad.TabIndex = 16;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(104, 163);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.PlaceholderText = "Ingrese precio";
            this.txt_Precio.Size = new System.Drawing.Size(202, 23);
            this.txt_Precio.TabIndex = 15;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(104, 104);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.PlaceholderText = "Ingrese marca";
            this.txt_Marca.Size = new System.Drawing.Size(202, 23);
            this.txt_Marca.TabIndex = 14;
            // 
            // cmb_TipoProducto
            // 
            this.cmb_TipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoProducto.FormattingEnabled = true;
            this.cmb_TipoProducto.Items.AddRange(new object[] {
            "Alimentos",
            "Juguetes",
            "Camas",
            "Medicamento",
            "Limpieza"});
            this.cmb_TipoProducto.Location = new System.Drawing.Point(200, 134);
            this.cmb_TipoProducto.Name = "cmb_TipoProducto";
            this.cmb_TipoProducto.Size = new System.Drawing.Size(106, 23);
            this.cmb_TipoProducto.TabIndex = 32;
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tipo.Location = new System.Drawing.Point(106, 137);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(88, 15);
            this.lbl_Tipo.TabIndex = 33;
            this.lbl_Tipo.Text = "Tipo producto:";
            // 
            // Frm_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(401, 307);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.cmb_TipoProducto);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.ComboBox cmb_TipoProducto;
        private System.Windows.Forms.Label lbl_Tipo;
    }
}