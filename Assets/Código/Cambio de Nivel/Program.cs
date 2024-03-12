using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio_de_Nivel
{
    using System;

    class Game
    {
        static void Main(string[] args)
        {
            // Inicialización del juego:

            Console.WriteLine("Bienvenido al juego!");

            Console.WriteLine("Presiona 't' para ir al siguiente nivel o 'y' para salir.");

            // Bucle principal del juego:

            bool gameOver = false;

            int currentLevel = 1;

            while (!gameOver)
            {
                // Lógica del juego:

                Console.WriteLine("Estás en el nivel " + currentLevel);

                // Entrada del jugador:

                ConsoleKeyInfo keyInput = Console.ReadKey();

                Console.WriteLine(); // Salto de línea después de la entrada del jugador:

                // Procesamiento de la entrada del jugador:

                switch (keyInput.KeyChar)
                {
                    case 't':
                        currentLevel++;
                        Console.WriteLine("Has avanzado al nivel " + currentLevel);
                        break;

                    case 'y':
                        gameOver = true;
                        Console.WriteLine("Gracias por jugar. Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Entrada no válida. Por favor, presiona 't' para avanzar al siguiente nivel o 'y' para salir.");
                        break;
                }
            }
        }
    }
}
