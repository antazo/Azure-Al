namespace prueba;

public class CodeKataBowling
{
    /*
    Juego de los bolos
    */
    public static string GenerateBowling()
    {
        Console.WriteLine("Desafío de Bolos (sin puntuación)");
        Console.WriteLine("--------------------------------");
        string result = "";

        int numTurnos = 10;
        int numTiradas = 2;

        // Para 2 jugadores
        int numJugadores = 2;
        //int puntosJugador1 = 0;
        //int puntosJugador2 = 0;
    
        for (int i = 0; i < numTurnos; i++)
        {
            for (int j = 0; j < numJugadores; j++)
            {
                int bolos = 10;
                result += $"Turno {i + 1}, Jugador {j + 1}: ";
                for (int k = 1; k <= numTiradas; k++)
                {
                    int bolosTirados = tirarBolos(bolos);
                    if(bolosTirados == 10)
                    {
                        result += $"Strike! ";
                        bolos = 0;
                        break;
                    }
                    result += $"tirada {k}, ";
                    result += $"ha tirado {bolosTirados}, ";
                    bolos -= bolosTirados;
                    if(bolos == 0)
                    {
                        result += $"Spare! ";
                        bolos = 0;
                        break;
                    }
                }
                result += $" Quedan {bolos}, ";
                result += "\n";
            }
        }
 
        return result;
    }

    public static int tirarBolos(int bolosRestantes)
    {
        // i son los bolos que quedan
        Random random = new Random();
        return random.Next(0, bolosRestantes + 1);
    }
}