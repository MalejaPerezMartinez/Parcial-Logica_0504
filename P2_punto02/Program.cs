internal class Program
{
    private static void Main(string[] args)
    {
        //Variables

        bool volver = true;
        const double BONO = 0.4; //Snake Case:Notación para constantes.

        while (volver) // ciclo de donde todo inicia
        {
            // Variables

            decimal aporteMensualp1 = 0, aporteTotalp1 = 0, rendimientoTotalp1 = 0, bonoTotalp1 = 0, prestamoTotalp1 = 0, multasTotalp1 = 0, tasamensualp1, rendimientoMensualp1, bonomensualp1;
            decimal aporteMensualp2 = 0, aporteTotalp2 = 0, rendimientoTotalp2 = 0, bonoTotalp2 = 0, prestamoTotalp2 = 0, multasTotalp2 = 0;

            //Clase random
            Random random = new Random();

            //Bucle para los meses

            for (int mes = 1; mes <= 12; mes++)
            { // PERSONA 1
                Console.Write("Socio 1:\n");
                Console.Write($"\nIngrese la cantidad que desea ahorrar en el mes {mes}: ");
                aporteMensualp1 = Convert.ToDecimal(Console.ReadLine());
                // Multa por no aportar P1

                if (aporteMensualp1 == 0)
                {
                    Console.WriteLine($"¡Persona 1 tiene una multa de 20.000 por no aportar durante el {mes}");
                    multasTotalp1 += 20000;
                }
                tasamensualp1 = (decimal)random.Next(1, 51) / 10;
                rendimientoMensualp1 = aporteMensualp1 * (tasamensualp1 / 100);

                if (tasamensualp1 < 3.5M)
                {
                    bonomensualp1 = aporteMensualp1 * (decimal)BONO;
                    bonoTotalp1 += bonomensualp1;
                    bonomensualp1 = 0;
                }

                aporteTotalp1 += aporteMensualp1;
                rendimientoTotalp1 += rendimientoMensualp1;

                Console.Write($"MES {mes}\n" +
                              $"Aportes: {aporteMensualp1:C}\n" +
                              $"Tasa: {tasamensualp1}%\n" +
                              $"Rendimientos: {rendimientoMensualp1:C}\n" +
                              $"Bono: {bonomensualp1:C}\n" +
                              $"---------------------------------------\n" +
                              $" \n");
            }
        }
        }
    }
}

