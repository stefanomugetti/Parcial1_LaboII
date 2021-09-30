using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();     
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            if (this.lbl_Rangos.Text == "Empleado")
                this.BackColor = System.Drawing.Color.SlateGray;
            else if (this.lbl_Rangos.Text == "Administrador")
                this.BackColor = System.Drawing.Color.DarkGray;
        }
    }
}
