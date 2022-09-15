using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finanzas.Models;



namespace Finanzas
{
    public partial class frmEgresosMensuales : Form
    {

       

        public frmEgresosMensuales()
        {
            InitializeComponent();
           

        }

        private void frmEgresosMensuales_Load(object sender, EventArgs e)//--------------Load el WindowForms.
        {

            RefreshPagosMensuales();
            RefreshAfip();

            txtHorasExtras.Enabled = false;
            txtValorHoraExtra.Enabled = false;
            txtDescuento.Enabled = false;
            txtSac.Enabled = false;
            txtConceptosVarios.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)//---------------------------Boton de Calcular Total de Sueldo.
        {
            int horasT;
            int horasE;
            float valorHora;
            float valorHoraE;
            int antiguedad;            
            float sac;
            float conceptos;
            float descuento;
            float totalP;
            float remunerado;

            horasT = int.Parse(txtHorasTabajadas.Text);
            horasE = int.Parse(txtHorasExtras.Text);
            valorHora = float.Parse(txtValorHora.Text);
            valorHoraE = float.Parse(txtValorHoraExtra.Text);
            antiguedad = int.Parse(txtPorcentajeAnual.Text);
            sac = float.Parse(txtSac.Text);
            conceptos = float.Parse(txtConceptosVarios.Text);
            descuento = float.Parse(txtDescuento.Text);
            

            //totalP = valorHora * (horasT+horasE);
            totalP = (valorHora * horasT)+(valorHoraE * horasE);

            remunerado = totalP + (antiguedad / 100) * totalP + sac + conceptos - descuento ;

            txtTotalRemunerado.Text = Convert.ToString(remunerado);
        }

        private void ckbHoraExtra_CheckedChanged(object sender, EventArgs e)//----------------Check Horas Extras.
        {
            if (ckbHoraExtra.Checked) 
            {
                txtHorasExtras.Enabled = true;
                txtValorHoraExtra.Enabled = true;
            }
            else
            {
                txtHorasExtras.Enabled = false;
                txtValorHoraExtra.Enabled = false;
            }
                
        }
        private void ckbSAC_CheckedChanged(object sender, EventArgs e)//-----------------------Check SAC.
        {
            if (ckbSAC.Checked)
                txtSac.Enabled = true;

            else
                txtSac.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//--------------------Check Conceptos Varios.
        {

            if (ckbConceptos.Checked)
                txtConceptosVarios.Enabled = true;

            else
                txtConceptosVarios.Enabled = false;
        }

        private void ckbDescuento_CheckedChanged(object sender, EventArgs e)//-----------------Check Descuento.
        {
            if (ckbDescuento.Checked)
                txtDescuento.Enabled = true;

            else
                txtDescuento.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)//----------------------------------Boton de Cargar Recibo de Sueldo.
        {

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (FINANZASEntities db = new FINANZASEntities())
            {
                AfipSueldo afip = new AfipSueldo();//;;;---------------------------------------------------------------------------------------------
                afip.Fecha_de_pago = dtpFechaCarga.Value;
                afip.Período = cmbAfipMes.Text;
                afip.Horas_trabajadas = int.Parse(txtHorasTabajadas.Text);
                afip.Horas_extras = int.Parse(txtHorasExtras.Text);
                afip.Descuento = float.Parse(txtDescuento.Text);
                afip.S_A_C = float.Parse(txtSac.Text);
                afip.Conceptos_vaios = float.Parse(txtConceptosVarios.Text);
                afip.Total_Remunerado = float.Parse(txtTotalRemunerado.Text);
                afip.Número_de_VEP = int.Parse(txtNumeroVep.Text);
                afip.Comprobante_Recibo_Sueldo = file;
                afip.Nota = txtNotas.Text;


                db.AfipSueldo.Add(afip);
                db.SaveChanges();
            }

            RefreshAfip();

            cmbAfipMes.Text = "";
            txtHorasTabajadas.Text ="";
            txtValorHora.Text ="";
            txtHorasExtras.Text="";
            txtValorHoraExtra.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)//-------------------------------Boton de Ver recibo de sueldo.
        {

        }

        private void RefreshAfip()//------------------------------------------------Refresca formulario de Recibos de Sueldos.
        {


            using (FINANZASEntities db = new FINANZASEntities())
            {
                var lst = from d in db.AfipSueldo
                              //select d;
                          select new { 
                                       d.Fecha_de_pago,
                                       d.Período,
                                       d.Horas_trabajadas,
                                       d.Horas_extras,
                                       d.Descuento,
                                       d.S_A_C,
                                       d.Conceptos_vaios,
                                       d.Total_Remunerado,
                                       d.Número_de_VEP,
                                       d.Nota};
                dgvSueldos.DataSource = lst.ToList();


            }
        }

        private void button4_Click(object sender, EventArgs e)//---------------------------Boton Ver Modificar Recibo de sueldo.
        {
            frmVerSueldoAfip ver = new frmVerSueldoAfip();
            ver.ShowDialog();
        }

        private void btnCargarRecibo_Click(object sender, EventArgs e)//---------------OpenFileDialog de Recibos de sueldos
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtComprobanteReciboSueldo.Text = openFileDialog1.FileName;
            }
        }



                                                              //RECIBOS DE SUELDO / AFIP 
        //========================================================================================================================================================================
        //========================================================================================================================================================================
                                                                //PAGOS MENSUALES   


        private void button7_Click(object sender, EventArgs e)//------------------------ Boton de Carga el formulario de PAgos mensuales.
        {
            byte[] file = null;
            Stream myStream = openFileDialog2.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (FINANZASEntities db = new FINANZASEntities())
            {
                PagosMensuales egresosmensuales = new PagosMensuales();
                egresosmensuales.Fecha_de_carga = dtpFechaCarga.Value;
                egresosmensuales.Mes = cmbMes.Text;
                egresosmensuales.Nombre_Tipo = cmbNombreTipo.Text;
                egresosmensuales.Monto = decimal.Parse(txtMonto.Text);
                egresosmensuales.Comprobantes = file;
                egresosmensuales.NombreReal = openFileDialog2.SafeFileName;

                db.PagosMensuales.Add(egresosmensuales);
                db.SaveChanges();
            }

            RefreshPagosMensuales();

            cmbMes.Text = "";
            cmbNombreTipo.Text = "";
            txtMonto.Text = "";
            txtComprobantes.Text = "";
        }

        #region HELPER
        private void RefreshPagosMensuales()
        {


            using (FINANZASEntities db = new FINANZASEntities()) //---------------------------------------Refresca formulario de Pagos mensuales.
            {
                //dgvPagosMensuales.DataSource = db.PagosMensuales.ToList();
                var lst = from d in db.PagosMensuales                           //Select de SQL
                                                                                //select d;
                          select new
                          {
                              d.Id,
                              d.Fecha_de_carga,
                              d.Mes,
                              d.Nombre_Tipo,
                              d.Monto
                          };
                dgvPagosMensuales.DataSource = lst.ToList();


            }
        }

        private int? Getid()
        {
            try
            {
                return int.Parse(dgvPagosMensuales.Rows[dgvPagosMensuales.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Aguantaaa");
                return null; 
                
            }
        }//--------------------------------------------------------Procedimiento de obtencion de Id.

        #endregion

        private void button8_Click(object sender, EventArgs e) //--------------------------Boton de Ver/Editar Registros mensuales
        {

            int? id = Getid();

            if (id != null)
            {
                frmVerMensuales filtro = new frmVerMensuales(id);
                filtro.ShowDialog();
            }

            RefreshPagosMensuales();

        }

        private void button11_Click(object sender, EventArgs e)//--------------------------Boton Eliminar Registros mensuales.
        {
            try
            {
                int? id = Getid();

                if (id != null)
                {
                    using (FINANZASEntities db = new FINANZASEntities())
                    {
                        PagosMensuales pagos = db.PagosMensuales.Find(id);
                        db.PagosMensuales.Remove(pagos);
                        db.SaveChanges();

                    }

                    RefreshPagosMensuales();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No quedan datos para eliminar");
            }
           

        }

        private void button1_Click(object sender, EventArgs e)//--------------------------OpenFileDialog Comprobantes Mensuales.
        {
            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtComprobantes.Text = openFileDialog2.FileName;
            }
        }

        private void btnVerComprobante_Click(object sender, EventArgs e)//-------------------Ver comprobante/ Pago mensual.
        {
            int id = int.Parse(dgvPagosMensuales.Rows[dgvPagosMensuales.CurrentRow.Index].Cells[0].Value.ToString());

            using (FINANZASEntities db = new FINANZASEntities())
            {
                var oPagosMensuales = db.PagosMensuales.Find(id);

                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullFilePath = folder + oPagosMensuales.NombreReal;

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFilePath))
                    //Directory.Delete(fullFilePath);-------------Da error a la hora de volver a abrir los combrobantes.
                    File.Delete(fullFilePath);


                File.WriteAllBytes(fullFilePath,oPagosMensuales.Comprobantes);

                Process.Start(fullFilePath);
                
            }
        }

        


        //========================================================================================================================================================================
        //========================================================================================================================================================================
                                                                //LINKS

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hb.redlink.com.ar/bna/login.htm");
        }//----------------LInks

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.macro.com.ar/bancainternet/#");
        }//----------------Links

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www2.personas.santander.com.ar/obp-webapp/angular/#!/login");
        }//----------------Links

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www2.personas.santander.com.ar/obp-webapp/angular/#!/login");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hb.redlink.com.ar/bna/login.htm");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.macro.com.ar/bancainternet/#");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://casasparticulares.afip.gob.ar/default.aspx");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www2.personas.santander.com.ar/obp-webapp/angular/#!/login");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www2.personas.santander.com.ar/obp-webapp/angular/#!/login");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.argentina.gob.ar/trabajo/casasparticulares/trabajador/sueldo");
        }

        

        //========================================================================================================================================================================
        //========================================================================================================================================================================
                                                                            //CODIGO RESIDUO

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {


        }

        

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtSac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConceptosVarios_TextChanged(object sender, EventArgs e)
        {
          

            
        }

       
    }
}