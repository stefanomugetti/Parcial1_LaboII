
namespace Pet_Shop
{
    partial class Frm_Admin
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_BuscarPorId = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_RestaurarLista = new System.Windows.Forms.Button();
            this.dtgv_Lista = new System.Windows.Forms.DataGridView();
            this.clm_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(482, 339);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(174, 23);
            this.btn_Eliminar.TabIndex = 0;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(21, 12);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(174, 23);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_BuscarPorId
            // 
            this.btn_BuscarPorId.Location = new System.Drawing.Point(21, 338);
            this.btn_BuscarPorId.Name = "btn_BuscarPorId";
            this.btn_BuscarPorId.Size = new System.Drawing.Size(174, 23);
            this.btn_BuscarPorId.TabIndex = 4;
            this.btn_BuscarPorId.Text = "Buscar por ID";
            this.btn_BuscarPorId.UseVisualStyleBackColor = true;
            this.btn_BuscarPorId.Click += new System.EventHandler(this.btn_BuscarPorId_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(214, 339);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.PlaceholderText = "ID";
            this.txt_Id.Size = new System.Drawing.Size(45, 23);
            this.txt_Id.TabIndex = 9;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_RestaurarLista
            // 
            this.btn_RestaurarLista.Location = new System.Drawing.Point(482, 12);
            this.btn_RestaurarLista.Name = "btn_RestaurarLista";
            this.btn_RestaurarLista.Size = new System.Drawing.Size(174, 23);
            this.btn_RestaurarLista.TabIndex = 10;
            this.btn_RestaurarLista.Text = "Restaurar lista";
            this.btn_RestaurarLista.UseVisualStyleBackColor = true;
            this.btn_RestaurarLista.Click += new System.EventHandler(this.btn_RestaurarLista_Click);
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
            this.NOMBRE,
            this.clm_Apellido,
            this.DNI,
            this.clm_Usuario});
            this.dtgv_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtgv_Lista.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgv_Lista.Location = new System.Drawing.Point(21, 41);
            this.dtgv_Lista.MultiSelect = false;
            this.dtgv_Lista.Name = "dtgv_Lista";
            this.dtgv_Lista.ReadOnly = true;
            this.dtgv_Lista.RowTemplate.Height = 25;
            this.dtgv_Lista.Size = new System.Drawing.Size(635, 291);
            this.dtgv_Lista.TabIndex = 28;
            this.dtgv_Lista.TabStop = false;
            // 
            // clm_Id
            // 
            this.clm_Id.HeaderText = "ID";
            this.clm_Id.Name = "clm_Id";
            this.clm_Id.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOMBRE.FillWeight = 150F;
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 100;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // clm_Apellido
            // 
            this.clm_Apellido.HeaderText = "APELLIDO";
            this.clm_Apellido.Name = "clm_Apellido";
            this.clm_Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // clm_Usuario
            // 
            this.clm_Usuario.HeaderText = "USUARIO";
            this.clm_Usuario.Name = "clm_Usuario";
            this.clm_Usuario.ReadOnly = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(289, 339);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(174, 23);
            this.btn_Modificar.TabIndex = 29;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(694, 365);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.dtgv_Lista);
            this.Controls.Add(this.btn_RestaurarLista);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_BuscarPorId);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 43);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_BuscarPorId;
        private System.Windows.Forms.Button btn_RestaurarLista;
        private System.Windows.Forms.DataGridView dtgv_Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Usuario;
        private System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.TextBox txt_Id;
    }
}