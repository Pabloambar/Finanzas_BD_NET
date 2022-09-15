using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finanzas.Models;

namespace Finanzas
{
    public partial class frmVerMensuales : Form
    {
        public int? id;
        PagosMensuales egresosmensuales = null;
        public frmVerMensuales(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                Cargar();
        }

        private void Cargar()
        {
            using (FINANZASEntities db = new FINANZASEntities())
            {
                egresosmensuales = db.PagosMensuales.Find(id);
                dtpFechaCarga.Value = (DateTime)egresosmensuales.Fecha_de_carga;
                cmbMes.Text = egresosmensuales.Mes;
                cmbNombreTipo.Text = egresosmensuales.Nombre_Tipo;
                txtMonto.Text = egresosmensuales.Monto.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FINANZASEntities db = new FINANZASEntities())
            {
                if (id==null)  
                egresosmensuales = new PagosMensuales();
                egresosmensuales.Fecha_de_carga = dtpFechaCarga.Value;
                egresosmensuales.Mes = cmbMes.Text;
                egresosmensuales.Nombre_Tipo = cmbNombreTipo.Text;
                egresosmensuales.Monto = decimal.Parse(txtMonto.Text);
                

                if(id==null)
                db.PagosMensuales.Add(egresosmensuales);
                else
                {
                    db.Entry(egresosmensuales).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
                this.Close();
            }
        }
    }

   
}
