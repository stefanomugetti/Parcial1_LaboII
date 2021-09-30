
namespace Pet_Shop
{
    partial class Form_Stock
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
            this.dtgv_Lista = new System.Windows.Forms.DataGridView();
            this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TipoProducto = new System.Windows.Forms.ComboBox();
            this.lbl_Filtrar = new System.Windows.Forms.Label();
            this.btn_RestaurarLista = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Lista
            // 
            this.dtgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Lista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Id,
            this.clm_Nombre,
            this.clm_Marca,
            this.clm_Tipo,
            this.clm_Cantidad,
            this.clm_Precio});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_Lista.Location = new System.Drawing.Point(-1, 36);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.Size = new System.Drawing.Size(741, 358);
            this.dtgv_Lista.TabIndex = 30;
            this.dtgv_Lista.TabStop = false;
           
            // 
            // clm_Id
            // 
            this.clm_Id.HeaderText = "ID";
            this.clm_Id.Name = "clm_Id";
            this.clm_Id.ReadOnly = true;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clm_Nombre.FillWeight = 150F;
            this.clm_Nombre.HeaderText = "NOMBRE";
            this.clm_Nombre.MinimumWidth = 100;
            this.clm_Nombre.Name = "clm_Nombre";
            this.clm_Nombre.ReadOnly = true;
            // 
            // clm_Marca
            // 
            this.clm_Marca.HeaderText = "MARCA";
            this.clm_Marca.Name = "clm_Marca";
            this.clm_Marca.ReadOnly = true;
            // 
            // clm_Tipo
            // 
            this.clm_Tipo.HeaderText = "TIPO";
            this.clm_Tipo.Name = "clm_Tipo";
            this.clm_Tipo.ReadOnly = true;
            // 
            // clm_Cantidad
            // 
            this.clm_Cantidad.HeaderText = "CANTIDAD";
            this.clm_Cantidad.Name = "clm_Cantidad";
            this.clm_Cantidad.ReadOnly = true;
            // 
            // clm_Precio
            // 
            this.clm_Precio.HeaderText = "PRECIO";
            this.clm_Precio.Name = "clm_Precio";
            this.clm_Precio.ReadOnly = true;
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
            this.cmb_TipoProducto.Location = new System.Drawing.Point(79, 4);
            this.cmb_TipoProducto.Name = "cmb_TipoProducto";
            this.cmb_TipoProducto.Size = new System.Drawing.Size(121, 23);
            this.cmb_TipoProducto.TabIndex = 31;
            this.cmb_TipoProducto.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoProducto_SelectedIndexChanged);
            // 
            // lbl_Filtrar
            // 
            this.lbl_Filtrar.AutoSize = true;
            this.lbl_Filtrar.Location = new System.Drawing.Point(12, 7);
            this.lbl_Filtrar.Name = "lbl_Filtrar";
            this.lbl_Filtrar.Size = new System.Drawing.Size(61, 15);
            this.lbl_Filtrar.TabIndex = 32;
            this.lbl_Filtrar.Text = "Filtrar por:";
            // 
            // btn_RestaurarLista
            // 
            this.btn_RestaurarLista.Location = new System.Drawing.Point(280, 4);
            this.btn_RestaurarLista.Name = "btn_RestaurarLista";
            this.btn_RestaurarLista.Size = new System.Drawing.Size(174, 23);
            this.btn_RestaurarLista.TabIndex = 33;
            this.btn_RestaurarLista.Text = "Restaurar lista";
            this.btn_RestaurarLista.UseVisualStyleBackColor = true;
            this.btn_RestaurarLista.Click += new System.EventHandler(this.btn_RestaurarLista_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(494, 4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(174, 23);
            this.btn_Agregar.TabIndex = 34;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Form_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(740, 394);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_RestaurarLista);
            this.Controls.Add(this.lbl_Filtrar);
            this.Controls.Add(this.cmb_TipoProducto);
            this.Controls.Add(this.dtgv_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio;
        private System.Windows.Forms.ComboBox cmb_TipoProducto;
        private System.Windows.Forms.Label lbl_Filtrar;
        private System.Windows.Forms.Button btn_RestaurarLista;
        private System.Windows.Forms.Button btn_Agregar;
    }
}