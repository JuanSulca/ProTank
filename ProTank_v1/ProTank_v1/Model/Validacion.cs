using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1.Model
{
    class Validacion
    {
        private bool ValidaCedula(string cedula)
        {
            if (cedula.Length != 10)
            {
                return false;
            }
            else
            {
                int numv = 10;
                int div = 11;
                int[] coeficientes;
                if (int.Parse(cedula[2].ToString()) < 6) { coeficientes = new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 }; div = 10; }
                else
                {
                    if (int.Parse(cedula[2].ToString()) == 6)
                    {
                        coeficientes = new int[] { 3, 2, 7, 6, 5, 4, 3, 2 };
                        numv = 9;
                    }
                    else coeficientes = new int[] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                }
                int total = 0;
                int numprovincia = 24;
                int calculo = 0;
                cedula = cedula.Replace("-", "");
                char[] valores = cedula.ToCharArray(0, 9);

                if (((Convert.ToInt16(valores[2].ToString()) <= 6) || (Convert.ToInt16(valores[2].ToString()) == 9)) && (Convert.ToInt16(cedula.Substring(0, 2)) <= numprovincia))
                {
                    for (int i = 0; i < numv - 1; i++)
                    {
                        calculo = (Convert.ToInt16(valores[i].ToString())) * coeficientes[i];
                        if (div == 10) total += calculo > 9 ? calculo - 9 : calculo;
                        else total += calculo;
                    }
                    return (div - (total % div)) >= 10 ? 0 == Convert.ToInt16(cedula[numv - 1].ToString()) : (div - (total % div)) == Convert.ToInt16(cedula[numv - 1].ToString());
                }
                else return false;
            }
        }

        public string validarCedula(string cedula)
        {
            if (ValidaCedula(cedula))
            {
                return "";
            }
            else
            {
                return "Cédula incorrecta.\n";
            }
        }

        private bool ValidaTelefonoCelular(string celular)
        {
            if (celular.Length != 10)
            {
                return false;
            }
            else
            {
                return celular[0] == '0' && celular[1] == '9';
            }
        }

        public string validarCelular(string celular)
        {
            if (ValidaTelefonoCelular(celular))
            {
                return "";
            }
            else
            {
                return "Número celular incorrecto.\n";
            }
        }

        private bool ValidaTelefonoConvencional(string telefono)
        {
            if (telefono.Length == 7)
            {
                if(telefono[0] == '2' || telefono[0] == '3')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(telefono.Length == 9)
            {
                if(telefono[0]=='0'&& (telefono[1] =='2'|| telefono[1]=='3' || telefono[1] == '4' || telefono[1] == '5' || telefono[1] == '6' || telefono[1] == '7'))
                {
                    if (telefono[2] == '2' || telefono[2] == '3')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public string validarTelefono(string telefono)
        {
            if (ValidaTelefonoConvencional(telefono))
            {
                return "";
            }
            else
            {
                return "Número convencional incorrecto.\n";
            }
        }
    }

}
