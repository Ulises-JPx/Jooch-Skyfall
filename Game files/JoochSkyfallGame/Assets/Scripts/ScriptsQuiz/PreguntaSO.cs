using UnityEngine;

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