using System;
using System.Collections.Generic;

// Clase Achievement para representar cada logro:
public class Achievement
{
    public string Name { get; set; }
    public bool IsUnlocked { get; set; }

    public Achievement(string name, bool isUnlocked)
    {
        Name = name;
        IsUnlocked = isUnlocked;
    }
}

// Clase AchievementManager para manejar los logros:
public class AchievementManager
{
    private List<Achievement> achievements;

    // Constructor para inicializar los logros:
    public AchievementManager()
    {
        achievements = new List<Achievement>
        {
            new Achievement("Salto Bomba: Haz que Bob elimine a un enemigo desde arriba con un salto a gran altura.", false),

            new Achievement("Intocable: Termina un nivel sin recibir daño alguno.", false),

            new Achievement("A toda maquina: Termina un nivel en menos de 2 minutos.", false),

            new Achievement("Ricachón: Consigue acabar un nivel con más de 50 monedas amarillas.", false),

            new Achievement("Vital: Termina un nivel sin recuperar vida mediante monedas rojas.", false),

            new Achievement("¿Estas bien?: Termina un nivel con sólo el 1% de la vida restante.", false),

            new Achievement("Ruta Pacífista: No acabes con ningún enemigo al terminar un nivel.", false),

            new Achievement("Primera Sangre: Acaba con tu primer enemigo.", false),

            new Achievement("Un Gran Paso: Acabar el primer nivel.", false),

            new Achievement("Hombre Hecho y Derecho: Acaba todos los niveles.", false),

        };
    }

    // Método para obtener la lista de logros:
    public List<Achievement> GetAchievements()
    {
        return achievements;
    }

    // Método para desbloquear un logro:
    public void UnlockAchievement(string name)
    {
        foreach (var achievement in achievements)
        {
            if (achievement.Name.StartsWith(name))
            {
                achievement.IsUnlocked = true;
                break;
            }
        }
    }

    // Método para reiniciar todos los logros:
    public void ResetAchievements()
    {
        foreach (var achievement in achievements)
        {
            achievement.IsUnlocked = false;
        }
    }

    // Método para mostrar el estado de los logros:
    public void DisplayAchievements()
    {
        foreach (var achievement in achievements)
        {
            if (achievement.IsUnlocked)
            {
                Console.WriteLine($"{achievement.Name} - Unlocked");
            }
            else
            {
                Console.WriteLine($"{achievement.Name} - Locked");
            }
        }
    }

    // Método para mostrar el menú de configuración:
    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu:");

            Console.WriteLine("1. Show Achievements"); // Mostrar Logros

            Console.WriteLine("2. Unlock Achievement"); // Logro Alcanzado = Aparecer Activado

            Console.WriteLine("3. Reset Achievements"); // Botón Reiniciar Logros en Configuración

            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayAchievements();
                    break;

                case "2":
                    Console.Write("Enter the name of the achievement to unlock: ");
                    string name = Console.ReadLine();
                    UnlockAchievement(name);
                    break;

                case "3":
                    ResetAchievements();
                    Console.WriteLine("Achievements have been reset.");
                    break;

                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}

// Clase principal Program para ejecutar la aplicación:
class Program
{
    static void Main(string[] args)
    {
        AchievementManager manager = new AchievementManager();
        manager.ShowMenu();
    }
}