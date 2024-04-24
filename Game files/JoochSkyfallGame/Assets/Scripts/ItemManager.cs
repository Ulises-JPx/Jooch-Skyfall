using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject EndingTransition;
    public static int verCoinsCount = 0;
    public TextMeshProUGUI verCoinsText;
    public static int aguacateCount = 0;
    public TextMeshProUGUI aguacateText;
    public static int cafeCount = 0;
    public TextMeshProUGUI cafeText;
    public static int jitomateCount = 0;
    public TextMeshProUGUI jitomateText;
    public static int maizCount = 0;
    public TextMeshProUGUI maizText;
    public static int chileCount = 0;
    public TextMeshProUGUI chileText;
    public float verqorCount = 0;
    public TextMeshProUGUI verqorText;

    public TextMeshProUGUI deudaText; 
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
        chileText.text = ": " + chileCount;
        verqorText.text = ": " + verqorCount;
        verCoinsText.text = ": " + verCoinsCount;
        deudaText.text = " " + ElectionManager.deuda;
        
        VerqorChange();
    }


    void VerqorChange()
    {
        if (verqorCount == 5)
        {
            StartCoroutine(TransitionAndLoadScene());
        }
    }
    IEnumerator TransitionAndLoadScene()
{
    EndingTransition.SetActive(true);
    yield return new WaitForSeconds(3f); // Espera 3 segundos
    SceneManager.LoadScene("TriviaScene");
    verqorCount = 0;
}
    
}
