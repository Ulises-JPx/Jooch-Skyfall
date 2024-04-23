using CsvHelper;
using System.IO;
using System.Globalization;
using UnityEngine;
using UnityEditor;

public class CsvToPreguntaSO : MonoBehaviour
{
    public TextAsset csvFile; // Arrastra tu archivo CSV aquí desde el inspector de Unity

    void Awake()
    {
        using (var reader = new StringReader(csvFile.text))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<PreguntaCsv>();
            int counter = 1;
            foreach (var record in records)
            {
                string assetPath = $"Assets/Preguntas/{counter}.asset";
                PreguntaSO pregunta = AssetDatabase.LoadAssetAtPath<PreguntaSO>(assetPath);

                if (pregunta == null)
                {
                    pregunta = ScriptableObject.CreateInstance<PreguntaSO>();
                    AssetDatabase.CreateAsset(pregunta, assetPath);
                }

                pregunta.id = counter;
                pregunta.pregunta = record.Pregunta;
                pregunta.opc1 = record.op1;
                pregunta.opc2 = record.op2;
                pregunta.opc3 = record.op3;
                pregunta.correcta = record.correcta.HasValue ? record.correcta.Value : 0;

                counter++;
            }
        }

        AssetDatabase.SaveAssets();
    }
}