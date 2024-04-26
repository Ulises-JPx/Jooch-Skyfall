using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRotten : MonoBehaviour
{
    private TrailRenderer trail;

    void Start()
    {
        // Obtiene la referencia al TrailRenderer
        trail = GetComponent<TrailRenderer>();

        trail.time = 0.5f;
        trail.startWidth = 0.4f;
        trail.endWidth = 0.0f;
        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.startColor = new Color(1f, 1f, 1f, 0.5f); // Blanco semitransparente
        trail.endColor = new Color(1f, 1f, 1f, 0f);
        trail.sortingOrder = -1;

        

        
    }
}
