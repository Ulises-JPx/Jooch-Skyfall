/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
//Clase para guardar los datos del jugador
public class DataSaver : MonoBehaviour {
    public static Jugador jugador = new();

    public static void Recolectar() {
        int aguacate = ItemManager.aguacateCount;
        int cafe = ItemManager.cafeCount;
        int chile = ItemManager.chileCount;
        int maiz = ItemManager.maizCount;
        int tomate = ItemManager.jitomateCount;
        int total_cosechas = aguacate + cafe + chile + maiz + tomate;
        
        jugador.ModificarCosechas(aguacate, cafe, chile, maiz, tomate, total_cosechas);
        // Debug.Log("Cosechas recolectadas " + total_cosechas);
    }

    public static void Trivia(int id_pregunta, int resultado) {
        jugador.ModificarTrivia(id_pregunta, resultado);
        // Debug.Log("Trivia respondida " + id_pregunta);
    }

    public static void Seleccion(int id_carta, string tipo) {
        jugador.ModificarSeleccion(id_carta, tipo);
        // Debug.Log("Carta seleccionada " + id_carta);
    }

    public static void Ciclo(int no_ciclo, float deuda, float dinero, float interes) {
        jugador.ModificarCiclo(no_ciclo, deuda, dinero, interes);
        // Debug.Log("Ciclo actualizado " + no_ciclo);
        // Debug.Log("Deuda actualizada " + deuda);
        // Debug.Log("Dinero actualizado " + dinero);
        // Debug.Log("Interes actualizado " + interes);
    }

    public static void Partida(int eleccion_financiamiento, int puntos, int dinero_total) {
        string tipo_financiamiento = ""; // Assign a default value to the variable
        if (eleccion_financiamiento == 1) {
            tipo_financiamiento = "Verqor";
        } else if (eleccion_financiamiento == 2) {
            tipo_financiamiento = "Coyote";
        } else if (eleccion_financiamiento == 3) {
            tipo_financiamiento = "Banco";
        }

        jugador.ModificarPartida(tipo_financiamiento, puntos, dinero_total);
        // Debug.Log("Partida actualizada " + tipo_financiamiento);
        // Debug.Log("Puntos actualizados " + puntos);
        // Debug.Log("Dinero total actualizado " + dinero_total);
    }

    public static void Resetear() {
        var id_jugador = jugador.id_jugador;
        var email = jugador.email;
        var password = jugador.password;
        var partida = jugador.partida;

        jugador = new Jugador
        {
            id_jugador = id_jugador,
            email = email,
            password = password,
            partida = partida
        };

        // Debug.Log("Valores del jugador reseteados");
    }
}
