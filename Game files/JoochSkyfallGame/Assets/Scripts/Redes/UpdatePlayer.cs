
/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using System.Text;

public class UpdatePlayer : MonoBehaviour
{

    public static IEnumerator UpdatePlayerData() {
        Jugador jugador = DataSaver.jugador;

        string url = "http://198.199.66.6/updatePlayer";

        // Convierte la nueva estructura a JSON
        string json = JsonUtility.ToJson(jugador);

        // Crea una nueva solicitud POST
        UnityWebRequest www = new(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(json);
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "application/json");

        // Envía la solicitud
        yield return www.SendWebRequest();

        // Comprueba si hay errores
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
    }

    public static IEnumerator UpdatePlayerPartida() {
        Jugador jugador = DataSaver.jugador;

        string url = "http://198.199.66.6/updatePlayer/Partida";

        // Convierte la nueva estructura a JSON
        string json = JsonUtility.ToJson(jugador);

        // Crea una nueva solicitud POST
        UnityWebRequest www = new(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(json);
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "application/json");

        // Envía la solicitud
        yield return www.SendWebRequest();

        // Comprueba si hay errores
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
    }

    public static IEnumerator GeneratePlayerPartida()
    {
        Jugador jugador = DataSaver.jugador;

        string url = "http://198.199.66.6/updatePlayer/GeneratePartida";

        // Convierte la nueva estructura a JSON
        string json = JsonUtility.ToJson(jugador);

        // Crea una nueva solicitud POST
        UnityWebRequest www = new(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(json);
        www.uploadHandler = new UploadHandlerRaw(bodyRaw);
        www.downloadHandler = new DownloadHandlerBuffer();
        www.SetRequestHeader("Content-Type", "application/json");

        // Envía la solicitud
        yield return www.SendWebRequest();

        // Comprueba si hay errores
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            var jsonResponse = JsonUtility.FromJson<Response>(www.downloadHandler.text);
            jugador.partida.id_partida = jsonResponse.id_partida;
        }
    }
    [System.Serializable]
    public class Response
    {
        public string message;
        public string id_partida;
    }
}