/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
//Clase para las preguntas de ScriptableObjects

[CreateAssetMenu(fileName = "NuevaPregunta", menuName = "Pregunta")]    
public class PreguntaSO : ScriptableObject{

    public int SO_Id;
    public string SO_Pregunta;
    public string SO_Op1;
    public string SO_Op2;
    public string SO_Op3;
    public int SO_Correcta;
    internal string opc1;
}