using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "CartaVentaja", menuName = "CartaVentaja")]	

public class CartaV : ScriptableObject{
    public int V_id;

    public string V_titulo;
    public string V_descripcion;
    public string V_verqor;
    public string V_coyote;   
    public string V_canco;

    // public Sprite V_img;

    //Comprador Nacional Aumenta el precio de TODOS los productos
    public void VentajaCompradorNacional(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.1f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.1f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.1f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.1f;
            RecapScript.precioChile += RecapScript.precioChile * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.08f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.08f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.08f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.08f;
            RecapScript.precioChile += RecapScript.precioChile * 0.08f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.09f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.09f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.09f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.09f;
            RecapScript.precioChile += RecapScript.precioChile * 0.09f;
        }
    }
    //Nueva Certificacion Aumenta el precio de TODOS los productos
    public void VentajaNuevaCertificacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.17f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.17f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.17f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.17f;
            RecapScript.precioChile += RecapScript.precioChile * 0.17f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.15f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.15f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.15f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.15f;
            RecapScript.precioChile += RecapScript.precioChile * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.20f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.20f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.20f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.20f;
            RecapScript.precioChile += RecapScript.precioChile * 0.20f;
        }
    }
    //LLuvia Moderada Aumenta el spawn rate de TODOS LOS CULTIVOS un 
    public void VentajaLluviaModerada(){
        RandomSpawner.spawnIntervalMaiz -= 1f;
        RandomSpawner.spawnIntervalAguacate -= 1f;
        RandomSpawner.spawnIntervalChile -= 1f;
        RandomSpawner.spawnIntervalCafe -= 1f;
        RandomSpawner.spawnIntervalJitomate -= 1f;
    }
    public void VentajaReduccionDeDeuda(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ElectionManager.deuda -= ElectionManager.deuda * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.deuda -= ElectionManager.deuda * 0.05f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.deuda -= ElectionManager.deuda * 0.07f;
        }      
    }
    public void VentajaVentaExitosa(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount += 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount += 900;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount += 950;
        }      
    }
    public void VentajaNegociacionInteligente(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ElectionManager.interes -= ElectionManager.interes * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.interes -= ElectionManager.interes * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.interes -= ElectionManager.interes * 0.18f;
        }      
    }
    public void VentajaAvanceTecnologico(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.15f;
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.15f;
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.15f;
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.15f;
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.1f;
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.1f;
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.1f;
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.1f;
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.12f;
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.12f;
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.12f;
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.12f;
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.12f;
        }
    }
    public void VentajaOptimizacionRecursos(){
        if(ElectionManager.TipoFinanciamiento == 1){
            Debug.Log("Optimizacion de recursos Verqor");
        }else if(ElectionManager.TipoFinanciamiento == 2){
            Debug.Log("Optimizacion de recursos Coyote");
        }else if(ElectionManager.TipoFinanciamiento == 3){
            Debug.Log("Optimizacion de recursos Banco");
        }
    
    }

    public void VentajaEstrategiaComercializacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.12f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.12f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.12f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.12f;
            RecapScript.precioChile += RecapScript.precioChile * 0.12f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.1f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.1f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.1f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.1f;
            RecapScript.precioChile += RecapScript.precioChile * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.11f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.11f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.11f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.11f;
            RecapScript.precioChile += RecapScript.precioChile * 0.11f;
        }
    }
    public void VentajaCosechaDorada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalMaiz -= RandomSpawner.spawnIntervalMaiz * 0.18f;
        }
    }
    public void VentajaFestivalChile(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalChile -= RandomSpawner.spawnIntervalChile * 0.18f;
        }
    }
    public void VentajaDespertarAromatico(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalCafe -= RandomSpawner.spawnIntervalCafe * 0.18f;
        }
    }
    public void VentajaBoomOroVerde(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalAguacate -= RandomSpawner.spawnIntervalAguacate * 0.18f;
        }
    }
    public void VentajaAvanceRojo(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RandomSpawner.spawnIntervalJitomate -= RandomSpawner.spawnIntervalJitomate * 0.18f;
        }
    }
    public void VentajaAccesoAgroinsumos(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.22f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.22f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.22f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.22f;
            RecapScript.precioChile += RecapScript.precioChile * 0.22f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.2f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.2f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.2f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.2f;
            RecapScript.precioChile += RecapScript.precioChile * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz += RecapScript.precioMaiz * 0.22f;
            RecapScript.precioCafe += RecapScript.precioCafe * 0.22f;
            RecapScript.precioJitomate += RecapScript.precioJitomate * 0.22f;
            RecapScript.precioAguacate += RecapScript.precioAguacate * 0.22f;
            RecapScript.precioChile += RecapScript.precioChile * 0.22f;
        }

    }
    public void VentajaOptimizacionCiclo(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount += 1500;
        }
        else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount += 1500;   
        }
        else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount += 1500;   
        }
    }
}