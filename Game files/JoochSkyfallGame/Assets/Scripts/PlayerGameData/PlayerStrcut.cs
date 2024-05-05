/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
//Clase con las estructuras de datos del jugador
using System.Collections.Generic;

[System.Serializable]
public struct Partida
{
    public string id_partida;
    public string tipo_financiamiento;
    public int puntos;
    public decimal dinero_total;
    public float tiempo_total;
}

[System.Serializable]
//Estructura de datos para el ciclo del jugador
public struct Ciclo
{
    public int no_ciclo;
    public float deuda;
    public float dinero;
    public float interes;
}

//Estructura de datos para las cosechas del jugador
[System.Serializable]
public struct Cosechas
{
    public int aguacate;
    public int cafe;
    public int chile;
    public int maiz;
    public int tomate;
    public int total_cosechas;
}

//Estructura de datos para las preguntas de trivia
[System.Serializable]
public struct Trivia
{
    public List<int> id_pregunta;
    public List<int> resultado; // Asumiendo que 1 es verdadero y 0 es falso
}

//Estructura de datos para la selección de cartas
[System.Serializable]
public struct Seleccion
{
    public int id_carta;
    public string tipo;
}

//Estructura de datos para el jugador
[System.Serializable]
public class Jugador
{
    public string id_jugador;
    public string email;
    public string password;
    public Partida partida;
    public Ciclo ciclo;
    public Cosechas cosechas;
    public Trivia trivia;
    public Seleccion seleccion;

    //Funciones para modificar los datos del jugador
    public void ModificarCosechas(int aguacate, int cafe, int chile, int maiz, int tomate, int total_cosechas)
    {
        cosechas.aguacate = aguacate;
        cosechas.cafe = cafe;
        cosechas.chile = chile;
        cosechas.maiz = maiz;
        cosechas.tomate = tomate;
        cosechas.total_cosechas = total_cosechas;
    }

    public void ModificarTrivia(int id_pregunta, int resultado)
    {
        trivia.id_pregunta ??= new List<int>();
        trivia.id_pregunta.Add(id_pregunta);

        trivia.resultado ??= new List<int>();
        trivia.resultado.Add(resultado);
    }

    public void ModificarSeleccion(int id_carta, string tipo)
    {
        seleccion.id_carta = id_carta;
        seleccion.tipo = tipo;

    }

    public void ModificarCiclo(int no_ciclo, float deuda, float dinero, float interes)
    {
        ciclo.no_ciclo = no_ciclo;
        ciclo.deuda = deuda;
        ciclo.dinero = dinero;
        ciclo.interes = interes;

    }

    public void ModificarPartida(string tipo_financiamiento, int puntos, decimal dinero_total)
    {
        partida.tipo_financiamiento = tipo_financiamiento;
        partida.puntos = puntos;
        partida.dinero_total = dinero_total;
    }

    public void ModificarId(string id_jugador) {
        this.id_jugador = id_jugador;
    }
}