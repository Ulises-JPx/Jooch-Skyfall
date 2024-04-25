using System.Collections.Generic;
using System.IO;
using System.Globalization;
using CsvHelper;
using UnityEditor;
using UnityEngine;

public class DesventajasSOGenerator : MonoBehaviour
{
    public class DesventajaCsv
    {
        public string NombreDesventaja { get; set; }
        public string Descripcion { get; set; }
        public string EfectoVerqor { get; set; }
        public string EfectoCoyote { get; set; }
        public string EfectoBanco { get; set; }
    }

    [MenuItem("Tools/Generate DesventajaSOs")]
    public static void GenerateDesventajaSOs()
    {
        string csvFilePath = "Assets/csv files/Desventajas_JoochSkyfall.csv"; // Reemplaza esto con la ruta a tu archivo CSV
        string desventajasFolderPath = "Assets/Resources/Desventajas"; // Reemplaza esto con la ruta a la carpeta donde quieres guardar los ScriptableObjects

        // Lee el contenido del archivo CSV
        string csvText = File.ReadAllText(csvFilePath);

        // Lee los datos del CSV
        List<DesventajaCsv> desventajasCsv = LeerDatosDelCsv<DesventajaCsv>(csvText);

        int id = 1; // Inicia el contador

        // Genera un DesventajaSO para cada DesventajaCsv
        foreach (DesventajaCsv desventajaCsv in desventajasCsv)
        {
            CartaD desventajaSO = ScriptableObject.CreateInstance<CartaD>();

            desventajaSO.D_id = id; // Asigna el id actual
            desventajaSO.D_titulo = desventajaCsv.NombreDesventaja;
            desventajaSO.D_descripcion = desventajaCsv.Descripcion;
            desventajaSO.D_verqor = desventajaCsv.EfectoVerqor;
            desventajaSO.D_coyote = desventajaCsv.EfectoCoyote;
            desventajaSO.D_banco = desventajaCsv.EfectoBanco;

            // Guarda el DesventajaSO como un archivo .asset
            AssetDatabase.CreateAsset(desventajaSO, $"{desventajasFolderPath}/{desventajaSO.D_id}.asset");

            id++; // Incrementa el contador
        }

        // Refresca el AssetDatabase para que los nuevos ScriptableObjects aparezcan en el editor
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static List<T> LeerDatosDelCsv<T>(string csvText) {
        using var reader = new StringReader(csvText);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<T>();
        List<T> datosCsv = new();
        foreach (var record in records)
        {
            datosCsv.Add(record);
        }
        return datosCsv;
    }
}