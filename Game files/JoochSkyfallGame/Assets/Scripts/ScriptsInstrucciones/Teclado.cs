/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Fucnion para mostrar el teclado y su interacción con el usuario
public class Teclado : MonoBehaviour
{
    public RawImage ESC;
    public RawImage Shift;
    public RawImage Espacio;
    public RawImage Izquierda;
    public RawImage Derecha;

    // Update is called once per frame
    void Update()
    {
        UpdateKeyColor(KeyCode.Escape, ESC);
        UpdateKeyColor(KeyCode.LeftShift, Shift);
        UpdateKeyColor(KeyCode.Space, Espacio);
        UpdateKeyColor(KeyCode.LeftArrow, Izquierda);
        UpdateKeyColor(KeyCode.RightArrow, Derecha);
    }

    void UpdateKeyColor(KeyCode key, RawImage image)
    {
        if (Input.GetKeyDown(key))
        {
            image.color = Color.green; // Cambia el color a verde cuando se presiona la tecla
        }
        if (Input.GetKeyUp(key))
        {
            image.color = Color.white; // Cambia el color a blanco (o cualquier otro color original) cuando se suelta la tecla
        }
    }
}