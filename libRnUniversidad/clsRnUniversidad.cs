using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace libRnUniversidad
{
    public class clsRnUniversidad
    {
        #region Attributes
        private int _intTipoEst;
        private float _fltProm;
        private float _fltValCredito;
        private int _intCredit;
        private float _fltDesc;
        private string _strError;
        #endregion

        #region Constructor 
        public clsRnUniversidad()
        {
            _intTipoEst = 0;
            _fltProm = 0;
            _fltValCredito = 0;
            _intCredit = 0;
            _fltDesc = 0;
            _strError = string.Empty;
        }
        #endregion 

        #region Properties
        public int tipoEstudiante
        {
            set { _intTipoEst = value; }
        }
        public float Promedio
        {
            get => _fltProm;
            set => _fltProm = value;
        }
        public float valorCredito
        {
            get => _fltValCredito;
            set => _fltValCredito = value;
        }
        public int numCreditos
        {
            get => _intCredit;
            set => _intCredit = value;
        }
        public float Descuento
        {
            get { return _fltDesc; }
            set {_fltDesc = value; }
        }
        public string Error
        {
            get => _strError;
            set => _strError = value;
        }
        #endregion

        #region Methotd privates

        private bool Validar()
        {
            if (_intTipoEst != 1 && _intTipoEst != 2)
            {
                _strError = "Tipo de estudiante no valido";
                return false;
            }
            if (_fltProm < 0 || _fltProm > 5)
            {
                _strError = "promedio de nota no valido";
                return false;
            }
            return true;

        }

        private bool leerArchivo()
        {
            if (!Validar())
                return false;
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt";
                int intCant = 0;
                string strLinea;
                string[] vectorLinea;
                string strCodigo;
                float fltNota;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); //Crear objeto para leer el archivo
                while ((strLinea = Archivo.ReadLine()) != null)      //Leer línea * línea el archivo
                {
                    vectorLinea = strLinea.Split(':');
                    strCodigo = vectorLinea[0];          //Tipo de estudiante (Programa)
                    fltNota = Convert.ToSingle(vectorLinea[1]);  //Promedio mínimo de nota
                    if (strCodigo == _intTipoEst.ToString() && _fltProm >= fltNota)
                    {
                        _fltValCredito = Convert.ToSingle(vectorLinea[2]); //Valor crédito
                        _intCredit = Convert.ToInt16(vectorLinea[3]); //Cantidad Créditos
                        _fltDesc = Convert.ToSingle(vectorLinea[4]); //Porcentaje de Dscto
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                _strError = ex.Message;
                return false;
            }
        }
#endregion

        #region Methotd public
        public bool hallarDatos()
        {
            return leerArchivo();
        }
#endregion
    }
}
