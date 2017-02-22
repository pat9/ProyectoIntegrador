﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.GUI
{
    public partial class frm_PuntodeVentaGUI : Form
    {
        public bool activo = false;

        HerramientasGUI Herramientas = new HerramientasGUI();

        public frm_PuntodeVentaGUI()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Herramientas.FormAct = this;
            activo = false;
            Herramientas.CerrarForm();
        }
    }
}
