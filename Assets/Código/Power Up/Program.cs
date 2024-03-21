using UnityEngine;
using System.Collections;

public class PowerUpController : MonoBehaviour
{
    public bool isSpeedActive = false;
    public bool isInvincible = false;

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
        isSpeedActive = true;
        Debug.Log("¡Obtuviste velocidad!");

        isInvincible = true;
        Debug.Log("¡Eres invencible!");

        // Aplicamos ambos efectos al recolectar el Power-Up
        AplicarEfecto();
    }

    void AplicarEfecto()
    {
        // Lógica para aplicar el efecto de Power-Ups
        StartCoroutine(DesactivarEfecto());

        if (isSpeedActive)
        {
            Debug.Log("Efecto de velocidad activado.");
            // Aquí puedes agregar la lógica para aplicar el efecto de velocidad al jugador
        }

        if (isInvincible)
        {
            Debug.Log("Efecto de invencibilidad activado.");
            // Aquí puedes agregar la lógica para aplicar el efecto de invencibilidad al jugador
        }
    }

    IEnumerator DesactivarEfecto()
    {
        yield return new WaitForSeconds(5f); // Simular la duración del efecto (5 segundos)

        // Desactivar ambos efectos después de la duración especificada
        isSpeedActive = false;
        isInvincible = false;

        Debug.Log("Efectos desactivados.");
        // Aquí puedes agregar la lógica para desactivar los efectos del jugador
    }
}