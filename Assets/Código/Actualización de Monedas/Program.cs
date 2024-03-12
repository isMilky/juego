using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actualización_de_Monedas
{
    using System;

    class Game
    {
        static void Main(string[] args)
        {
            // Inicialización del juego:

            Console.WriteLine("¡Bienvenido al juego de recolección de monedas!");

            Console.WriteLine("Presiona 'y' para recolectar monedas amarillas, 'r' para recolectar monedas rojas y 'q' para salir.");

            // Variables del juego:

            int yellowCoins = 0;

            int redCoins = 0;

            int health = 100;

            int currentLevel = 1;

            // Bucle principal del juego:

            bool gameOver = false;

            while (!gameOver)
            {
                // Mostrar estado actual del juego:

                Console.WriteLine("Nivel actual: " + currentLevel);

                Console.WriteLine("Salud: " + health);

                Console.WriteLine("Monedas amarillas recolectadas: " + yellowCoins);

                Console.WriteLine("Monedas rojas recolectadas: " + redCoins);

                // Entrada del jugador:

                ConsoleKeyInfo keyInput = Console.ReadKey();

                // Salto de línea después de la entrada del jugador:

                Console.WriteLine(); 

                // Procesamiento de la entrada del jugador:

                switch (keyInput.KeyChar)
                {
                    case 'y':

                        yellowCoins++;

                        Console.WriteLine("¡Has recolectado una moneda amarilla!");

                        // Avanzar de nivel al recolectar 5 monedas amarillas:

                        if (yellowCoins >= 5) 
                        {
                            currentLevel++;

                            // Reiniciar contador de monedas amarillas:

                            yellowCoins = 0; 

                            Console.WriteLine("¡Has avanzado al nivel " + currentLevel + "!");
                        }
                        break;

                    case 'r':
                        redCoins++;

                        Console.WriteLine("¡Has recolectado una moneda roja!");

                        // Recuperar 20 puntos de salud al recolectar una moneda roja:

                        health += 20;

                        // Limitar la salud máxima a 100:

                        if (health > 100) 
                        {
                            health = 100;
                        }
                        break;          
                }
            }
        }
    }
}
