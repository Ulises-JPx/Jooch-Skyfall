/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
using UnityEngine.SceneManagement;
//Clase para que funcione el botón de Start en el menú principal con su audio
public class PauseMenu : MonoBehaviour
{
    //Definir variables y referencias a unity
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Funcionalidad con el boton esc de pausa
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused){
                Resume();
            }else{
                Pause();
            }
        }
        
    }
    //regresar el tiempo dentro de unity a la normalidad

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //pausar el timepo dentro de unity
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Funcion que apaga el juego
    public void QuitGame(){
        Application.Quit();
    }
    
}
