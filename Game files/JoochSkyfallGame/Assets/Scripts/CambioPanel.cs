using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con elementos de la UI

public class CambioPanel : MonoBehaviour
{
    public Button ControlesBoton; // Referencia al botón ControlesBoton
    public Button IntruccionBoton; // Referencia al botón IntruccionBoton

    public void OnControlesBotonClick()
    {
        // Cambiar la transparencia de IntruccionBoton a 120
        ColorBlock colorBlock = IntruccionBoton.colors;
        colorBlock.normalColor = new Color(colorBlock.normalColor.r, colorBlock.normalColor.g, colorBlock.normalColor.b, 120f / 255);
        // Al pasar el cursor por encima del boton InstruccionBoton, se cambia el highlighted color a FFB20B
        colorBlock.highlightedColor = new Color(1f, 0.698f, 0.043f, 1f);
        IntruccionBoton.colors = colorBlock;
    }

    public void OnIntruccionBotonClick()
    {
        // Cambiar la transparencia de ControlesBoton a 120
        ColorBlock colorBlock = ControlesBoton.colors;
        colorBlock.normalColor = new Color(colorBlock.normalColor.r, colorBlock.normalColor.g, colorBlock.normalColor.b, 120f / 255);
        ControlesBoton.colors = colorBlock;
        // Al pasar el cursor por encima del boton ControlesBoton, se cambia el highlighted color a FFB20B
        colorBlock.highlightedColor = new Color(1f, 0.698f, 0.043f, 1f);
        ControlesBoton.colors = colorBlock;
    }
}