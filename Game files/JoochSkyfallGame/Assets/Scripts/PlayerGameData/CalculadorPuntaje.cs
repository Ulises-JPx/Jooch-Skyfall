/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;

public class CalculadorPuntaje : MonoBehaviour
{
    public static int GetPuntaje() {
        // Get the player's data
        Jugador jugador = DataSaver.jugador;

        int trivia_correctas = 0;
        int cosechas_totales = jugador.cosechas.total_cosechas * RecapScript.numCiclo;
        float tiempo_jugado = MainMenu.EndTime();

        foreach (int result in jugador.trivia.resultado)
        {
            if (result == 1)
            {
                trivia_correctas++;
            }
        }

        // Get the player's score
        int score = trivia_correctas * 10000 + (int)(cosechas_totales * 0.5) - (int)tiempo_jugado;

        // Debug.Log("Puntaje del jugador (Trivia): " + trivia_correctas);
        // Debug.Log("Puntaje del jugador (Cosechas): " + cosechas_totales);
        // Debug.Log("Puntaje del jugador (Tiempo): " + tiempo_jugado);
        // Debug.Log("Puntaje del jugador (Score): " + score);
        
        return score;
    }
}
