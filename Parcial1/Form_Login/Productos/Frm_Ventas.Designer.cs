
namespace Pet_Shop
{
    partial class Frm_Ventas
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
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DniCliente = new System.Windows.Forms.TextBox();
            this.dtgv_ListaCompras = new System.Windows.Forms.DataGridView();
            this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgv_Lista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_ComprasCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Location = new System.Drawing.Point(76, 304);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(52, 23);
            this.nud_Cantidad.TabIndex = 0;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(12, 333);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(116, 23);
            this.btn_Comprar.TabIndex = 1;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // txt_DniCliente
            // 
            this.txt_DniCliente.Location = new System.Drawing.Point(12, 266);
            this.txt_DniCliente.Name = "txt_DniCliente";
            this.txt_DniCliente.PlaceholderText = "Ingrese DNI del cliente";
            this.txt_DniCliente.Size = new System.Drawing.Size(124, 23);
            this.txt_DniCliente.TabIndex = 3;
            // 
            // dtgv_ListaCompras
            // 
            this.dtgv_ListaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListaCompras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgv_ListaCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_ListaCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_ListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListaCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Id,
            this.clm_Nombre,
            this.clm_Marca,
            this.clm_Tipo,
            this.clm_Cantidad,
            this.clm_Precio});
            this.dtgv_ListaCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_ListaCompras.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_ListaCompras.Location = new System.Drawing.Point(154, 253);
            this.dtgv_ListaCompras.MultiSelect = false;
            this.dtgv_ListaCompras.Name = "dtgv_ListaCompras";
            this.dtgv_ListaCompras.ReadOnly = true;
            this.dtgv_ListaCompras.RowTemplate.Height = 25;
            this.dtgv_ListaCompras.Size = new System.Drawing.Size(574, 115);
            this.dtgv_ListaCompras.TabIndex = 31;
            this.dtgv_ListaCompras.TabStop = false;
            // 
            // clm_Id
            // 
            this.clm_Id.HeaderText = "         ID PRODUCTO";
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
            // dtgv_Lista
            // 
            this.dtgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Lista.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_Lista.Location = new System.Drawing.Point(12, 30);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.Size = new System.Drawing.Size(716, 198);
            this.dtgv_Lista.TabIndex = 32;
            this.dtgv_Lista.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MARCA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Stock.Location = new System.Drawing.Point(306, 5);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(79, 22);
            this.lbl_Stock.TabIndex = 33;
            this.lbl_Stock.Text = "STOCK";
            // 
            // lbl_ComprasCliente
            // 
            this.lbl_ComprasCliente.AutoSize = true;
            this.lbl_ComprasCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ComprasCliente.Location = new System.Drawing.Point(338, 232);
            this.lbl_ComprasCliente.Name = "lbl_ComprasCliente";
            this.lbl_ComprasCliente.Size = new System.Drawing.Size(160, 16);
            this.lbl_ComprasCliente.TabIndex = 34;
            this.lbl_ComprasCliente.Text = "COMPRAS DEL CLIENTE";
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(740, 394);
            this.Controls.Add(this.lbl_ComprasCliente);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.dtgv_Lista);
            this.Controls.Add(this.dtgv_ListaCompras);
            this.Controls.Add(this.txt_DniCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.nud_Cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ventas";
            this.Text = "740; 394";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DniCliente;
        private System.Windows.Forms.DataGridView dtgv_ListaCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio;
        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_ComprasCliente;
    }
}