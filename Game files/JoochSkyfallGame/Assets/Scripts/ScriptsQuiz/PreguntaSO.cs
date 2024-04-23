using UnityEngine;

[CreateAssetMenu(fileName = "NuevaPregunta", menuName = "Pregunta")]    
public class PreguntaSO : ScriptableObject{

    public int id;
    public string pregunta;
    public string opc1;
    public string opc2;
    public string opc3;
    public int correcta;
}