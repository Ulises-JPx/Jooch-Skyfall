/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


//Clase para que se muestren los items que se han recolectado, administra las cuentas a lo largo del juego
public class ItemManager : MonoBehaviour
{
    //Definir variables y referencias a unity
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

    // Actualiza las cuentas de los items
    void Update()
    {
        aguacateText.text = ":" + aguacateCount;
        cafeText.text = ":" + cafeCount;
        jitomateText.text = ":" + jitomateCount;
        maizText.text = ":" + maizCount;
        chileText.text = ":" + chileCount;
        verqorText.text = ":" + verqorCount;
        verCoinsText.text = ":$ " + verCoinsCount;
        deudaText.text = "$" + ElectionManager.deuda;
        
        VerqorChange();
    }

    //lógica para que se hgaga el cambio de escena
    void VerqorChange()
    {
        if (verqorCount == 3)
        {
            StartCoroutine(TransitionAndLoadScene());
        }
    }

    //Corrutina para que se muestre el panel de transición
    IEnumerator TransitionAndLoadScene()
{
    EndingTransition.SetActive(true);
    yield return new WaitForSeconds(3f); // Espera 3 segundos
    SceneManager.LoadScene("TriviaScene");
    verqorCount = 0;
}
    
}
