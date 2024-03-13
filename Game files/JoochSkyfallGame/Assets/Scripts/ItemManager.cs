using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
using TMPro;



public class ItemManager : MonoBehaviour
{

    public int aguacateCount = 0;
    public TextMeshProUGUI aguacateText;
    public int cafeCount = 0;
    public TextMeshProUGUI cafeText;
    public int jitomateCount = 0;
    public TextMeshProUGUI jitomateText;
    public int maizCount = 0;
    public TextMeshProUGUI maizText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aguacateText.text = ": " + aguacateCount;
        cafeText.text = ": " + cafeCount;
        jitomateText.text = ": " + jitomateCount;
        maizText.text = ": " + maizCount;
    }
}
