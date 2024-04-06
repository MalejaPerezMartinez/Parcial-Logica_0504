internal class Program
{
    public static void Main(string[] args)

    {
        bool jugar1 = true;
        while (jugar1)
        {
            // adivina el numero Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50
            //Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
            // Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200
            int jugadores, numini, numfin, numing;
            numfin = 0; numini = 0;// inciar variables
            Console.WriteLine("|--------- Juguemos a Adivina el numero-------|");
            Console.WriteLine("|--Reglas: Solo puede jugar 2,3 o 4 personas--|");
            Console.WriteLine("|------Ingresa el numero de participantes: ---|");

            jugadores = Convert.ToInt32(Console.ReadLine());

            switch (jugadores)
            {
                case 2:
                    numfin = 50;
                    break;
                case 3:
                    numfin = 100;
                    break;
                case 4:
                    numfin = 200;
                    break;
                default:
                    Console.WriteLine("Numero de jugadores incorrecto");
                    continue;
            }
            // Generar un numero aleatorio

            Random random = new Random();
            int aleato = random.Next(numini, numfin);
            int turno = 0;
            bool juego2 = false;

            // Comienza el ciclo

            while (!juego2)

            {
                Console.Write("Turno del jugador:" + turno);
                Console.Write("Digite el numero : ");
                numing = Convert.ToInt32(Console.ReadLine());

                // Condicionales para la validación

                if(numing < aleato) 
                {
                    Console.Write("MENOR, turno para el siguiente jugador");
                }

                else if(numing > aleato)
                {
                    Console.Write("MAYOR, turno para el siguiente jugador");
                }
                else
                {
                    Console.Write("¡¡HAS GANADO!!");
                    juego2=true;
                }

                
            }


        }
    }
}



        
            
        

    

        

    

        
            

        

       




        
    
