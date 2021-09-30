
namespace Pet_Shop
{
    partial class Frm_FacturacionTotal
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
            this.clm_IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_IdProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Facturacion = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
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
            this.clm_IdCliente,
            this.clm_IdProd,
            this.clm_Nombre,
            this.clm_Marca,
            this.clm_Tipo,
            this.clm_Cantidad,
            this.clm_Precio});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_Lista.Location = new System.Drawing.Point(12, 4);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.Size = new System.Drawing.Size(700, 321);
            this.dtgv_Lista.TabIndex = 34;
            this.dtgv_Lista.TabStop = false;
            // 
            // clm_IdCliente
            // 
            this.clm_IdCliente.HeaderText = "ID CLIENTE";
            this.clm_IdCliente.Name = "clm_IdCliente";
            this.clm_IdCliente.ReadOnly = true;
            // 
            // clm_IdProd
            // 
            this.clm_IdProd.HeaderText = "ID PROD";
            this.clm_IdProd.Name = "clm_IdProd";
            this.clm_IdProd.ReadOnly = true;
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
            // lbl_Facturacion
            // 
            this.lbl_Facturacion.AutoSize = true;
            this.lbl_Facturacion.Location = new System.Drawing.Point(12, 328);
            this.lbl_Facturacion.Name = "lbl_Facturacion";
            this.lbl_Facturacion.Size = new System.Drawing.Size(99, 15);
            this.lbl_Facturacion.TabIndex = 35;
            this.lbl_Facturacion.Text = "Facturacion total:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(108, 328);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(13, 15);
            this.lbl_Total.TabIndex = 36;
            this.lbl_Total.Text = "0";
            // 
            // Frm_FacturacionTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(724, 355);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Facturacion);
            this.Controls.Add(this.dtgv_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FacturacionTotal";
            this.Text = "Frm_FacturacionTotal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_IdProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Precio;
        private System.Windows.Forms.Label lbl_Facturacion;
        private System.Windows.Forms.Label lbl_Total;
    }
}