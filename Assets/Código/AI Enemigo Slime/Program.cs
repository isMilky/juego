using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Enemigo_Slime
{
class Program
        {
            static void Main(string[] args)
            {
                // Posición inicial de Bob y del slime:

                int posicionBob = 0;
                int posicionSlime = 10;

                // Campo de visión del slime:

                int campoDeVision = 5;

                // Velocidad del slime:

                int velocidadSlime = 1;

                // Dirección inicial del slime (1 para derecha, -1 para izquierda):
                int direccionSlime = 1;

                // Simulación del movimiento de Bob:
                for (int i = 0; i < 20; i++)
                {
                    // Movimiento de Bob:

                    Console.WriteLine("Bob se mueve a la posición: " + posicionBob);

                    // Movimiento del slime:

                    Console.WriteLine("Slime se mueve a la posición: " + posicionSlime);

                    // Si Bob está dentro del campo de visión del slime, el slime lo persigue:

                    if (Math.Abs(posicionSlime - posicionBob) <= campoDeVision)
                    {
                        // Actualizar la dirección del slime según la posición de Bob:

                        if (posicionSlime < posicionBob)
                        {
                            direccionSlime = 1; // El slime se mueve hacia la derecha:
                        }
                        else
                        {
                            direccionSlime = -1; // El slime se mueve hacia la izquierda:
                        }

                        // Mover el slime hacia Bob:

                        posicionSlime += velocidadSlime * direccionSlime;

                        Console.WriteLine("¡Slime persigue a Bob!");
                    }
                    else
                    {
                        Console.WriteLine("Bob está fuera del campo de visión del slime.");
                    }

                    // Simular el tiempo (esperar unos segundos):

                    System.Threading.Thread.Sleep(1000); // Espera 1 segundo:

                    Console.WriteLine("---------------------------------");
                }

                Console.WriteLine("Simulación terminada.");
            }
        }

    }
