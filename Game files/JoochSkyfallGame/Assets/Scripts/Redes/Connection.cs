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
using UnityEngine.Networking;
using System.Text;
using System;
using UnityEngine.SceneManagement;
//Clase para la conexión con el servidor y el envío de datos
public class Connection : MonoBehaviour
{
  public GameObject panelError;
  public TMP_Text resultado;

  public TMP_InputField ifNombre;
  public TMP_InputField ifPassword;

  [Serializable]
  public class Credenciales
  {
    public string email;
    public string password;
  }

  public Credenciales player = new();

  //Función para enviar los datos al servidor
    public void EnviarJSON()
  {
    StartCoroutine(GenerarJSON());
  }

  //Función para generar el JSON con los datos del jugador
  IEnumerator GenerarJSON()
  {
    player.email = string.IsNullOrEmpty(ifNombre.text) ? "Mai Sakurajima" : ifNombre.text;
    player.password = string.IsNullOrEmpty(ifPassword.text) ? "Mai Sakurajima" : ifPassword.text;

    string datosJSON = JsonUtility.ToJson(player);

    UnityWebRequest request = new("http://198.199.66.6/auth/login", "POST");
    byte[] bodyRaw = Encoding.UTF8.GetBytes(datosJSON);
    request.uploadHandler = new UploadHandlerRaw(bodyRaw);
    request.downloadHandler = new DownloadHandlerBuffer();
    request.SetRequestHeader("Content-Type", "application/json");

    yield return request.SendWebRequest();

    var jsonResponse = JsonUtility.FromJson<Response>(request.downloadHandler.text);

    if (request.result == UnityWebRequest.Result.Success)
    {
      SceneManager.LoadScene("GameStartScene");
      Jugador jugador = DataSaver.jugador;
      jugador.ModificarId(jsonResponse.id_jugador);

    }
    else
    {
      if (jsonResponse.status == 0)
      {
        panelError.SetActive(true); // Muestra el mensaje en la escena
        yield return new WaitForSeconds(3); // Espera 3 segundos
        panelError.SetActive(false); // Oculta el mensaje
      }
    }
  }

  //Función para cerrar la aplicación
  [Serializable]
  public class Response
  {
    public string message;
    public int status;
    public string id_jugador;
  }
}
