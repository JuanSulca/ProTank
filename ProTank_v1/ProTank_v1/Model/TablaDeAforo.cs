using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTank_v1.Model
{
    class TablaDeAforo
    {
        static double areaLateral(double radio, double h)
        {
            return ((Math.PI * Math.Pow(radio, 2)) - (Math.Pow(radio, 2) * (Math.Acos((radio - h) / radio))) + ((radio - h) * Math.Sqrt((2 * radio * h) - Math.Pow(h, 2))));
        }

        static double volCilindro(double longitud, double radio, double h)
        {
            return (areaLateral(radio, h) * longitud);
        }

        static double volesfera(double diametro, double alturaLlena)
        {
            return (Math.PI / 3) * Math.Pow(alturaLlena, 2) * ((1.5 * diametro) - alturaLlena);
        }

        static double volTanque(double diametro, double alturaLlena, double longitud)
        {
            return (volesfera(diametro, alturaLlena) + volCilindro(longitud, diametro / 2, diametro - alturaLlena));
        }

        static double cm3ToLitters(double valor)
        {
            return (valor * 0.001);
        }
        static double cmToInch(double valor)
        {
            return (valor / 2.54);
        }
        static double inchToCm(double valor)
        {
            return (valor * 2.54);
        }

        static double littersToGallons(double valor)
        {
            return (valor * 3.78541178);
        }

        static double gallonsToLitters(double valor)
        {
            return (valor / 3.78541178);
        }

        static void tablaAforo(double diametro, String uniDiametro, double longitud, String uniLongitud, double cabeza, String uniCabeza, String volumen, int paso, int iteraciones)
        {
            double radio, volActual, resVolumen = 0, volTotal;
            int pasoAux = 0, i = 0;

            switch (uniDiametro)
            {
                case "cm":
                    break;
                case "pulgadas":
                    diametro = inchToCm(diametro);
                    break;
            }

            switch (uniLongitud)
            {
                case "cm":
                    break;
                case "pulgadas":
                    longitud = inchToCm(longitud);
                    break;
            }

            switch (uniCabeza)
            {
                case "cm":
                    break;
                case "pulgadas":
                    cabeza = inchToCm(cabeza);
                    break;
            }

            volTotal = volTanque(diametro, diametro, longitud);

            radio = diametro / 2;
            for (pasoAux = 0, i = 1; i <= iteraciones; pasoAux += paso, i++)
            {
                volActual = volTanque(diametro, pasoAux, longitud); //valor volumétrico en cm3 de la iteración

                switch (volumen)
                {
                    case "cm3":
                        resVolumen = volActual;
                        break;
                    case "litros":
                        resVolumen = cm3ToLitters(volActual);
                        break;
                    case "galones":
                        resVolumen = littersToGallons(cm3ToLitters(volActual));
                        break;
                    default:
                        Console.WriteLine("Unidad incorrecta para salida de volumen");
                        break;
                }
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", i, pasoAux, Math.Round(resVolumen, 2), Math.Round((resVolumen / volTotal) * 100, 4));
            }

        }

        static double superficieTanque(double longitud, double diametro, int tapas)
        {
            double circulares, cilindro;

            cilindro = Math.PI * diametro * longitud;
            circulares = (tapas + 2) * (Math.Pow((diametro / 2), 2) * Math.PI);
            return cilindro + circulares;
        }

        static double posicionTapas(double diametro, double volumen)
        {

            return ((Math.PI * Math.Pow(diametro / 2, 2)) / volumen);
        }
    }
}
