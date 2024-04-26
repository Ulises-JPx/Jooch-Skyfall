using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRottenCrops : MonoBehaviour
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
        trail.startColor = new Color(112f / 255f, 128f / 255f, 34f / 255f, 1f);
        trail.endColor = new Color(112f / 255f, 128f / 255f, 34f / 255f, 0.5f);
        trail.sortingOrder = -1;

        
        
    }
}
