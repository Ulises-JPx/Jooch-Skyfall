/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//Clase para las instrucciones del juego
public class SpawnerInstruct : MonoBehaviour
{
    //Referencias a todos los elementos de UI de la escena
    public GameObject[] RainingObjects;
    public GameObject[] InstructionImages;
    public GameObject panel;
    public Button startButton;
    public Button nextButtonSpawn;
    public Button nextButtonImages;
    public Button homeButton;
    public string[] textMessages;
    public string[] imageTextMessages;

    private int currentObjectIndex = 0;
    private int currentImageIndex = 0;
    private GameObject currentObject;
    //Funcion  que inicializA los botones y llama a las funciones correspondientes
    void Start()
    {
        startButton.onClick.AddListener(StartButtonClicked);
        nextButtonSpawn.onClick.AddListener(NextButtonSpawnClicked);
        nextButtonImages.onClick.AddListener(NextButtonImagesClicked);
        homeButton.onClick.AddListener(HomeButtonClicked);
        nextButtonSpawn.gameObject.SetActive(false);
        nextButtonImages.gameObject.SetActive(false);
        panel.SetActive(false);
    }
    //Funcion para mostrar la imagen de instrucciones
    void StartButtonClicked()
    {
        startButton.gameObject.SetActive(false);
        ShowImage();
    }
    //Funcion para mostrar la imagen de instrucciones
    void ShowImage()
    {
        InstructionImages[currentImageIndex].SetActive(true);
        StartCoroutine(WaitAndShowPanel());
    }
    //Corrutina para mostrar el panel de instrucciones despues de u tiempo

    IEnumerator WaitAndShowPanel()
    {
        yield return new WaitForSeconds(2f);
        InstructionImages[currentImageIndex].SetActive(false);
        panel.SetActive(true);
        panel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = imageTextMessages[currentImageIndex];
        if (currentImageIndex == 0) // Si es la primera imagen, mostrar nextButtonSpawn
        {
            nextButtonSpawn.gameObject.SetActive(true);
        }
        else // Si no es la primera imagen, mostrar nextButtonImages
        {
            nextButtonImages.gameObject.SetActive(true);
        }
    }

    //
    void NextButtonSpawnClicked()
    {
        panel.SetActive(false); // Ocultar el panel cuando se hace clic en el botón "Siguiente"
        nextButtonSpawn.gameObject.SetActive(false); // Ocultar el botón "Siguiente"
        DestroyCurrentObject();

        if (currentObjectIndex < RainingObjects.Length) // Verificar si todavía hay objetos en el array
        {
            Spawn();
            currentObjectIndex++;
        }
        else
        {
            nextButtonImages.gameObject.SetActive(true);
            nextButtonSpawn.gameObject.SetActive(false); // Desactivar el botón de spawn
        }
    }
    //Funcion para generar los objetos que caen dentro de las instrucciones
    void Spawn()
    {
        float x = 0.3f;
        float y = -0.54f;
        currentObject = Instantiate(RainingObjects[currentObjectIndex], new Vector3(x, y, 0), transform.rotation);
        Debug.Log("CurrentObject Index:" + currentObjectIndex + " " + RainingObjects[currentObjectIndex].name); // Mostrar en la consola el nombre del objeto que se está generando (para depuración)
        Debug.Log("Spawned object at: " + currentObject.transform.position);
    }
    //Funcion para mostrar la siguiente imagen de instrucciones
    void NextButtonImagesClicked()
    {
        panel.SetActive(false);
        nextButtonImages.gameObject.SetActive(false); // Desactivar el botón inmediatamente después de hacer clic en él
        currentImageIndex++;

        if (currentImageIndex < InstructionImages.Length)
        {
            ShowImage();
        }
        else
        {
            ResetGame();
        }
    }
    //Funcion para regresar al menu principal
    void HomeButtonClicked()
    {
        DestroyCurrentObject();
        ResetGame();
    }
    //Funcion para destruir el objeto actual
    void DestroyCurrentObject()
    {
        if (currentObject != null)
        {
            Destroy(currentObject);
            currentObject = null;
        }
    }
    //Funcion para mostrar el panel de instrucciones
    public void ObjectCaught()
    {
        panel.SetActive(true);
        // Mostrar el botón "Siguiente" cuando el jugador colisiona con el objeto y solo si no es el ultimo index
        if (currentObjectIndex < RainingObjects.Length)
        {
            panel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = textMessages[currentObjectIndex-1];
            nextButtonSpawn.gameObject.SetActive(true);
        }
        else
        {
            panel.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = textMessages[currentObjectIndex-1];
            nextButtonImages.gameObject.SetActive(true);
        }
    }
    //Funcion para reiniciar el estado de instrucciones
    void ResetGame()
    {
        currentImageIndex = 0;
        currentObjectIndex = 0;
        InstructionImages[currentImageIndex].SetActive(false);
        startButton.gameObject.SetActive(true);
        nextButtonSpawn.gameObject.SetActive(false);
        nextButtonImages.gameObject.SetActive(false);
        panel.SetActive(false);
    }
    
}
