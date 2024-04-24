using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables de cada logro:

        bool logroDesbloqueado = false;

        int alturaDelSalto = 10; // Altura del salto en unidades de juego.

        int alturaMinima = 8; // Altura mínima requerida para el logro.

        int danioRecibido = 0; // Daño recibido durante el nivel.

        int tiempoTranscurrido = 100; // Tiempo transcurrido en segundos.

        int cantidadMonedasAmarillas = 60; // Cantidad de monedas amarillas recolectadas.

        int vidaRecuperadaRoja = 0; // Vida recuperada mediante monedas rojas.

        int porcentajeVida = 1; // Porcentaje de vida restante.

        int enemigosAcabados = 0; // Número de enemigos eliminados.

        bool primerEnemigoAcabado = true; // Indica si el primer enemigo fue eliminado.

        int nivelActual = 1; // Nivel actual en el juego.

        bool nivelTerminado = true; // Indica si el nivel actual fue completado.

        bool todosLosNivelesTerminados = true; // Indica si todos los niveles fueron completados.

        // Salto Bomba:

        if (alturaDelSalto > alturaMinima)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Salto Bomba!");
        }

        // Intocable:

        if (danioRecibido == 0)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Intocable!");
        }

        // A Toda Máquina:

        if (tiempoTranscurrido < 120)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: A Toda Máquina!");
        }

        // Ricachón:

        if (cantidadMonedasAmarillas > 50)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Ricachón!");
        }

        // Vital:

        if (vidaRecuperadaRoja == 0)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Vital!");
        }

        // Suicida:

        if (porcentajeVida <= 1)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Suicida!");
        }

        // Ruta Pacífista:

        if (enemigosAcabados == 0)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Ruta Pacífista!");
        }

        // Primera Sangre:

        if (primerEnemigoAcabado)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Primera Sangre!");
        }

        // Un Gran Paso:

        if (nivelActual == 1 && nivelTerminado)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Un Gran Paso!");
        }

        // Hombre Hecho y Derecho:

        if (todosLosNivelesTerminados)
        {
            logroDesbloqueado = true;
            Console.WriteLine("¡Logro desbloqueado: Hombre Hecho y Derecho!");
        }

        // Ejemplo de activación: 
        if (logroDesbloqueado)
        {
            // Aquí iría el código para activar el logro en el juego, para tener pues, de ejemplo nada más.
        }
    }
}