using System.Collections.Generic;
using System.IO;
using System.Globalization;
using CsvHelper;
using UnityEditor;
using UnityEngine;

public class VentajasSOGenerator : MonoBehaviour
{
    public class VentajaCsv
    {
        public string NombreVentaja { get; set; }
        public string Descripcion { get; set; }
        public string EfectoVerqor { get; set; }
        public string EfectoCoyote { get; set; }
        public string EfectoBanco { get; set; }
    }

    [MenuItem("Tools/Generate VentajaSOs")]
    public static void GenerateVentajaSOs()
    {
        string csvFilePath = "Assets/csv files/Ventajas_JoochSkyfall.csv"; // Reemplaza esto con la ruta a tu archivo CSV
        string ventajasFolderPath = "Assets/Resources/Ventajas"; // Reemplaza esto con la ruta a la carpeta donde quieres guardar los ScriptableObjects

        // Lee el contenido del archivo CSV
        string csvText = File.ReadAllText(csvFilePath);

        // Lee los datos del CSV
        List<VentajaCsv> ventajasCsv = LeerDatosDelCsv<VentajaCsv>(csvText);

        int id = 1; // Inicia el contador

        // Genera un VentajaSO para cada VentajaCsv
        foreach (VentajaCsv ventajaCsv in ventajasCsv)
        {
            CartaV ventajaSO = ScriptableObject.CreateInstance<CartaV>();

            ventajaSO.V_id = id; // Asigna el id actual
            ventajaSO.V_titulo = ventajaCsv.NombreVentaja;
            ventajaSO.V_descripcion = ventajaCsv.Descripcion;
            ventajaSO.V_verqor = ventajaCsv.EfectoVerqor;
            ventajaSO.V_coyote = ventajaCsv.EfectoCoyote;
            ventajaSO.V_canco = ventajaCsv.EfectoBanco;

            // Guarda el VentajaSO como un archivo .asset
            AssetDatabase.CreateAsset(ventajaSO, $"{ventajasFolderPath}/{ventajaSO.V_id}.asset");

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