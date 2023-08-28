using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRnUniversidad;

namespace libOpeUniversidad
{
    public class clsOpeUniversidad
    {
        #region Attributes
        private int _intTipoEst;
        private float _fltProm;
        private float _fltValCredito;
        private int _intCredit;
        private float _fltValDescuento;
        private float _fltValPago;
        private string _strError;
        #endregion

        #region Constructor
        public clsOpeUniversidad()
        {
            _intTipoEst       = 0;
            _fltProm          = 0;
            _fltValCredito    = 0;
            _intCredit        = 0;
            _fltValDescuento  = 0;
            _fltValPago       = 0;
            _strError = string.Empty;
        }
        public clsOpeUniversidad(int intTipoEst, float fltProm, float fltValCredito, int intCredit, float fltValDescuento, float fltValPago, string strError)
        {
            _intTipoEst = intTipoEst;
            _fltProm = fltProm;
            _fltValCredito = fltValCredito;
            _intCredit = intCredit;
            _fltValDescuento = fltValDescuento;
            _fltValPago = fltValPago;
            _strError = strError;
        }
        #endregion

        #region Properties
        public int tipoEstudiante
        {
            get { return _intTipoEst; }
            set { _intTipoEst = value; }
        }

        public float Promedio
        {
            get { return _fltProm; }
            set { _fltProm = value; }
        }

        public float ValorCred
        {
            get { return _fltValCredito; }

        }

        public int numCreditos
        {
            get { return _intCredit; }

        }

        public float Descuento
        {
            get { return _fltValDescuento; }

        }

        public float valorPago
        {
            get { return _fltValPago; }
        }

        public string Error
        {
            get { return _strError; }
        }
        #endregion

        #region Metoths
        public bool hallarPago()
        {
            float subTot = 0;
            clsRnUniversidad oRn = new clsRnUniversidad();
            try
            {
                //Eniar info a clase 
                oRn.tipoEstudiante = _intTipoEst;
                oRn.Promedio = _fltProm;
                //Invocacion del metodo y tto del error
                if (!oRn.hallarDatos())
                {
                    _strError = oRn.Error;
                    return false;
                }
                //Recuperar información
                _fltValCredito = oRn.valorCredito;
                _intCredit = oRn.numCreditos;
                subTot = _intCredit * _fltValCredito;
                _fltValDescuento = subTot * oRn.Descuento / 100;
            }
            catch (Exception ex)
            {
                _strError = ex.Message;
                return false;
            }
            finally
            {
                oRn = null; //No es obligatorio pero lo vuelve mas rapido
            }
            if (_intCredit > 0 && _fltValCredito > 0)
            {
                _fltValPago = (_fltValCredito*_intCredit) - _fltValDescuento;
                return true;
            }
            else
            {
                _strError = "No se puede calcular el pago debido a valores inválidos.";
                return false;
            }
        }
        #endregion
    }
}
