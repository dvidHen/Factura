﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{

    public partial class Form1 : Form
    {
        long num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad1.Clear();
            txtCantidad2.Clear();
            txtCantidad3.Clear();
            txtCantidad4.Clear();
            txtCantidad5.Clear();
            txtCantidad6.Clear();
            txtCantidad7.Clear();
            txtCod1.Clear();
            txtCod2.Clear();
            txtCod3.Clear();
            txtCod4.Clear();
            txtCod5.Clear();
            txtCod6.Clear();
            txtCod7.Clear();
            txtDescripcion1.Clear();
            txtDescripcion2.Clear();
            txtDescripcion3.Clear();
            txtDescripcion4.Clear();
            txtDescripcion5.Clear();
            txtDescripcion6.Clear();
            txtDescripcion7.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtFolio.Clear();
            txtImporte1.Clear();
            txtImporte2.Clear();
            txtImporte3.Clear();
            txtImporte4.Clear();
            txtImporte5.Clear();
            txtImporte6.Clear();
            txtImporte7.Clear();
            txtIva.Clear();
            txtPUnitario1.Clear();
            txtPUnitario2.Clear();
            txtPUnitario3.Clear();
            txtPUnitario4.Clear();
            txtPUnitario5.Clear();
            txtPUnitario6.Clear();
            txtPUnitario7.Clear();
            txtRSocial.Clear();
            txtRut.Clear();
            txtSubtotal.Clear();
            txtTelefono.Clear();
            txtTotal.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolio.Enabled = false;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtFolio.Text = num.ToString();
            num++;
            MessageBox.Show("Factura ingresada correctamente bajo número de folio: " + num);
        }
    }
}
