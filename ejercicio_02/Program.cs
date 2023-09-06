using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estrellas, dias, monto;
            Console.WriteLine("ingrese la cantidad de estrellas del hotel:");
            estrellas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de dias:");
            dias = Convert.ToInt32(Console.ReadLine());

            if (estrellas == 3)
            {
                if (dias <= 5)
                {
                    monto = 100 * dias;
                }
                else if (dias <= 10)
                {
                    monto = 85 * dias;
                }
                else
                {
                    monto = 70 * dias;
                }
            }
            else
            {
                if (dias <= 5)
                {
                    monto = 300 * dias;
                }
                else if (dias <= 10)
                {
                    monto = 270 * dias;
                }
                else
                {
                    monto = 250 * dias;
                }
            }

            monto = monto + dias * 7;

            Console.WriteLine("El monto final es :" + monto);

            dias = Convert.ToInt32(Console.ReadLine());
        }
    }
}
