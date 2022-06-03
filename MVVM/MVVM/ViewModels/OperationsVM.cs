using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    class OperationsVM : VMBase
    {
        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChange();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChange();
                }
            }
        }

        String errorDiv;
        public String ErrorDiv
        {
            get { return errorDiv; }
            set
            {
                if (errorDiv != value)
                {
                    errorDiv = value;
                    OnPropertyChange();
                }
            }
        }

        int suma;
        public int ResultSuma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChange();
                }
            }
        }

        int resta;
        public int ResultResta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChange();
                }
            }
        }

        int multiplicacion;
        public int ResultMultiplicacion
        {
            get { return multiplicacion; }
            set
            {
                if (multiplicacion != value)
                {
                    multiplicacion = value;
                    OnPropertyChange();
                }
            }
        }

        float division;
        public float ResultDivision
        {
            get { return division; }
            set
            {
                if (division != value)
                {
                    division = value;
                    OnPropertyChange();
                }
            }
        }
        #endregion

        #region Comandos
        public ICommand Sumar { protected set; get; }

        public ICommand Restar { protected set; get; }

        public ICommand Multiplicar { protected set; get; }

        public ICommand Dividir { protected set; get; }
        #endregion

        #region Constructor
        public OperationsVM()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                ResultResta = Valor1 - Valor2;
            });

            Multiplicar = new Command(() =>
            {
                ResultMultiplicacion = Valor1 * Valor2;
            });

            Dividir = new Command(() =>
            {
                if (Valor2 == 0)
                {
                    ErrorDiv = "Error: no se puede dividir entre 0";
                    ResultDivision = 0;
                }
                else
                {
                    ErrorDiv = "";
                    ResultDivision = Valor1 / Valor2;
                }
                
            });
        }
        #endregion
    }
}
