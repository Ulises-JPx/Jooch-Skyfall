using CsvHelper;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

public class PreguntaSOGenerator : MonoBehaviour
{
    [MenuItem("Tools/Generate PreguntaSOs")]
    public static void GeneratePreguntaSOs()
    {
        string csvFilePath = "Assets/csv files/BancoPreguntas_JoochSkyfall_Update.csv"; // Reemplaza esto con la ruta a tu archivo CSV
        string preguntasFolderPath = "Assets/Resources/Preguntas"; // Reemplaza esto con la ruta a la carpeta donde quieres guardar los ScriptableObjects

        // Lee el contenido del archivo CSV
        string csvText = File.ReadAllText(csvFilePath);

        // Lee los datos del CSV
        List<PreguntaCsv> preguntasCsv = LeerDatosDelCsv(csvText);

        int id = 1; // Inicia el contador

        // Genera un PreguntaSO para cada PreguntaCsv
        foreach (PreguntaCsv preguntaCsv in preguntasCsv)
        {
            PreguntaSO preguntaSO = ScriptableObject.CreateInstance<PreguntaSO>();

            preguntaSO.SO_Id = id; // Asigna el id actual
            preguntaSO.SO_Pregunta = preguntaCsv.Pregunta;
            preguntaSO.SO_Op1 = preguntaCsv.op1;
            preguntaSO.SO_Op2 = preguntaCsv.op2;
            preguntaSO.SO_Op3 = preguntaCsv.op3;
            preguntaSO.SO_Correcta = preguntaCsv.correcta;
            // Guarda el PreguntaSO como un archivo .asset
            AssetDatabase.CreateAsset(preguntaSO, $"{preguntasFolderPath}/{preguntaSO.SO_Id}.asset");

            id++; // Incrementa el contador
        }

        // Refresca el AssetDatabase para que los nuevos ScriptableObjects aparezcan en el editor
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static List<PreguntaCsv> LeerDatosDelCsv(string csvText) {
        using (var reader = new StringReader(csvText))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<PreguntaCsv>();
            List<PreguntaCsv> preguntasCsv = new List<PreguntaCsv>();
            foreach (var record in records)
            {
                preguntasCsv.Add(record);
            }
            return preguntasCsv;
        }
    }
}