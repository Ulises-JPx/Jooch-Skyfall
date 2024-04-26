using CsvHelper;
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

public class TipsSoGenerator : MonoBehaviour
{

    public class TipCsv
    {
        public string T_Tip { get; set; }
    }

    [MenuItem("Tools/Generate TipsSOs")]
    public static void GenerateTipsSOs()
    {
        string csvFilePath = "Assets/csv files/Tips_JoochSkyfall.csv"; // Reemplaza esto con la ruta a tu archivo CSV
        string tipsFolderPath = "Assets/Resources/Tips"; // Reemplaza esto con la ruta a la carpeta donde quieres guardar los ScriptableObjects

        // Lee el contenido del archivo CSV
        string csvText = File.ReadAllText(csvFilePath);

        // Lee los datos del CSV
        List<TipCsv> tipsCsv = LeerDatosDelCsv(csvText);

        int id = 1; // Inicia el contador

        // Genera un TipSO para cada TipCsv
        foreach (TipCsv tipCsv in tipsCsv)
        {
            TipsSO tipSO = ScriptableObject.CreateInstance<TipsSO>();

            tipSO.T_id = id; // Asigna el id
            tipSO.T_Tip = tipCsv.T_Tip; // Asigna el tip

            // Guarda el TipSO como un archivo .asset
            AssetDatabase.CreateAsset(tipSO, $"{tipsFolderPath}/{tipSO.T_id}.asset");

            id++; // Incrementa el contador
        }

        // Refresca el AssetDatabase para que los nuevos ScriptableObjects aparezcan en el editor
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static List<TipCsv> LeerDatosDelCsv(string csvText) {
        using var reader = new StringReader(csvText);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<TipCsv>();
        List<TipCsv> tipsCsv = new();
        foreach (var record in records)
        {
            tipsCsv.Add(record);
        }
        return tipsCsv;
    }
}