internal class Program
{
    public static void Main(string[] args)
    {
        // adivina el numero Si participan 2 jugadores, el número ℕ aleatorio se generará entre 0 y 50
        //Si participan 3 jugadores, el número ℕ aleatorio se generará entre 0 y 100
        // Si participan 4 jugadores, el número ℕ aleatorio se generará entre 0 y 200
        int jugadores, numini, numfin;
        numfin = 0; numini = 0;// inciar variables
        Console.WriteLine("|--------- Juguemos a Adivina el numero-------|");
        Console.WriteLine("|--Reglas: Solo puede jugar 2,3 o 4 personas--|");
        Console.WriteLine("|------Ingresa el numero de participantes: ---|");

        jugadores = Convert.ToInt32(Console.ReadLine());

        // Usar case para saber el rango de acuerdo a los jugadores
        // if (jugadores < 2 && jugadores > 4) Console.Write("Numero de jugadores incorrectos, ingrese de nuevo");
        // else
        //{

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
        }
        //}
        // Generar un numero aleatorio

        Random random = new Random();
        int aleato = random.Next(numini, numfin);
        int turno = 0;
        bool juego = false;

        // Comienza el ciclo
        switch (!juego)
        { Console.WriteLine("Turno del jugador:" + turno); }
    }
}

        
            
        

    

        

    

        
            

        

       




        
    
