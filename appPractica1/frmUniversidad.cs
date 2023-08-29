using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeUniversidad;

namespace appPractica1
{
    public partial class frmUniversidad : Form
    {
        public frmUniversidad()
        {
            InitializeComponent();
        }

        #region Methots Propios
        private void Mensaje(string texto)  
        {
            this.MensajError.Text = texto;
        } 
        private void llenarCombo()
        {
            this.comboBoxTipoEst.Items.Add("Seleccione un tipo de estudiante"); //Index = 0
            this.comboBoxTipoEst.Items.Add("Pregrado"); //Index 1
            this.comboBoxTipoEst.Items.Add("Postgrado"); // Index 2
            this.comboBoxTipoEst.SelectedIndex = 0;
        }
        private void Limpiar()
        {
           
            this.comboBoxTipoEst.SelectedIndex = 0;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            this.groupBoxResults.Visible = false;
            this.comboBoxTipoEst.Focus();
        }
        #endregion

        #region Eventos del objeto
        private void frmUniversidad_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void ButtonTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            string nombre;
            float pNota;
            int carnet, tipoE;

            try
            {
                Mensaje("");
                //Captura de datos

                tipoE = this.comboBoxTipoEst.SelectedIndex;
                if (tipoE <= 0)
                {
                    Mensaje("Tipo de estudiante no válido");
                    this.comboBoxTipoEst.Focus();
                    return;
                }
                carnet = Convert.ToInt32(this.textBoxCarnet.Text);
                pNota = Convert.ToSingle(this.textBoxProm.Text);

                //Se crea el objeto
                clsOpeUniversidad oP = new clsOpeUniversidad();
                //Enviar informaciòn al objeto
                oP.tipoEstudiante = tipoE;
                oP.Promedio = pNota;
                //Invocar el metodo y tratamiento de error
                if (! oP.hallarPago())
                {
                    Mensaje(oP.Error);
                    oP = null;
                    return;
                }
                //Recuperar inforación
                this.textBoxNumCred.Text = oP.numCreditos.ToString();
                this.txtVrCred.Text = oP.ValorCred.ToString();
                this.txtDscto.Text = oP.Descuento.ToString();
                this.txtVrPagar.Text = oP.valorPago.ToString();
                this.groupBoxResults.Visible = true;
                oP = null;
            }
            catch (Exception ex)
            {
                Mensaje (ex.Message);
            }
        }
        #endregion

    }
}
