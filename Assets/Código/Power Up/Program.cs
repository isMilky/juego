using UnityEngine;
using System.Collections;

public class PowerUpController : MonoBehaviour
{
    public bool estaVelocidadActivada = false;
    public bool estaRegenerandoVida = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RecolectarPowerUps();
        }
    }

    void RecolectarPowerUps()
    {
        // Lógica para recolectar Power-Ups
        estaVelocidadActivada = true;
        Debug.Log("¡Obtuviste velocidad!");

        estaRegenerandoVida = true;
        Debug.Log("¡Regenerando toda la vida!");

        // Aplicamos ambos efectos al recolectar el Power-Up
        AplicarEfecto();
    }

    void AplicarEfecto()
    {
        // Lógica para aplicar el efecto de Power-Ups
        StartCoroutine(DesactivarEfecto());

        if (estaVelocidadActivada)
        {
            Debug.Log("Efecto de velocidad activado.");
            // Aquí puedes agregar la lógica para aplicar el efecto de velocidad al jugador
        }

        if (estaRegenerandoVida)
        {
            Debug.Log("Regenerando vida...");
            // Aquí puedes agregar la lógica para regenerar la vida del jugador completamente
            // Por ejemplo: playerHealth = maxHealth;
        }
    }

    IEnumerator DesactivarEfecto()
    {
        yield return new WaitForSeconds(5f); // Simular la duración del efecto (5 segundos)

        // Desactivar ambos efectos después de la duración especificada
        estaVelocidadActivada = false;
        estaRegenerandoVida = false;

        Debug.Log("Efectos desactivados.");
        // Aquí puedes agregar la lógica para desactivar los efectos del jugador
    }
}