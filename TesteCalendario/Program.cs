using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trab_de_ProgVis
{
    internal static class Program
    {
        static void Main()
        {
            Calendario c = new Calendario();
            do
            {
                try
                {
                    Console.WriteLine("Escreva o mês desejado: ");
                    c.mes = Convert.ToByte(Console.ReadLine());

                }
                catch (Exception e)
                {
                }
            } while (c.isMesValido() == false);

            do
            {
                try
                {
                    Console.WriteLine("Escreva o ano desejado: ");
                    c.ano = Convert.ToUInt16(Console.ReadLine());
                }
                catch (Exception e)
                {
                }
            } while (c.isAnoValido() == false);


            Console.WriteLine(c.GerarCalendario());
        }
    }
}