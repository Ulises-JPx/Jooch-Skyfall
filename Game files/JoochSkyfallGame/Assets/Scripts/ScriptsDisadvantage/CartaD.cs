/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System;
using UnityEngine;
//Clase de Scriptable Object para las cartas de desventajas
[CreateAssetMenu(fileName = "CartaDesventaja", menuName = "CartaDesventaja")]	

public class CartaD : ScriptableObject{
    //Variables de la clase
    public int D_id;

    public string D_titulo;
    public string D_descripcion;
    public string D_verqor;
    public string D_coyote;
    public string D_banco;

    // public Sprite D_img;

    //Funciones para aplicar las desventajas de las cartas, dependiendo del tipo de financiamiento
    //Se resta una cantidad de monedas al jugador
    public void DesventajaSiniestroHelada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 300;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 2500;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaSiniestroSequia(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 4000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 6000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 4000;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaEnfermedad(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 1500;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 1500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 1500;
        }
    }
    //Se actualizan los precios de los cultivos
    public void DesventajaPlaga(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.1f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.1f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.1f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.1f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.12f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.12f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.12f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.12f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.12f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.11f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.11f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.11f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.11f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.11f;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaGatsosExtra(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 3000;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaCalorExtremo(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 100;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 100;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 100;
        }
    }
    //Se actualiza el interés del jugdor
    public void DesventajaEngano(){
        if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.interes += ElectionManager.interes * 0.4f;
        
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaConflictoNarco(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.12f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.11f);
        }
    }
    //Se resta una cantidad de monedas al jugador   
    public void DesventajaCrisisMercado(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.35f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.25f);

        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaInundacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 4000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 3500;
        }
    }
    //Se aumentan los costos de los servicios
    public void DesventajaIncrementoCostos(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.15f;
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.15f;
            RecapScript.CostosDistribucion += RecapScript.CostosDistribucion * 0.15f;

        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.25f;
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.25f;
            RecapScript.CostosDistribucion += RecapScript.CostosDistribucion * 0.25f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.18f;
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.18f;
            RecapScript.CostosDistribucion += RecapScript.CostosDistribucion * 0.18f;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaRoboCosecha(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.2f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.25f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.22f);

        }
    }
    //Se actualizan los valores de los precios de los cultivos
    public void DesventajaProblemasLogistica(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.08f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.08f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.08f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.08f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.08f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.1f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.1f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.1f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.1f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.1f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz -= RecapScript.precioMaiz * 0.09f;
            RecapScript.precioAguacate -= RecapScript.precioAguacate * 0.09f;
            RecapScript.precioCafe -= RecapScript.precioCafe * 0.09f;
            RecapScript.precioJitomate -= RecapScript.precioJitomate * 0.09f;
            RecapScript.precioChile -= RecapScript.precioChile * 0.09f;
        }

    }
    //Aumenta el interes del jugador
    public void DesventajaAumentotasas(){
        if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.interes += ElectionManager.interes * 0.3f;
        }
    }

    //Se resta una cantidad de monedas al jugador
    public void DesventajaTarifaExortacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.15f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.12f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.14f);

        }

    }
    //Se actualizan los costos de los servicios
    public void DesventajaEscazesAgua(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.2f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.25f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.CostosAgua += RecapScript.CostosAgua * 0.22f;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaIncendio(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= -2000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 5000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 5000;
        }
        
    }
    //Se actualizan los costos de los servicios
    public void DesventajaAumentoCostoEnergetico(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.15f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.17f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.CosotsLuz += RecapScript.CosotsLuz * 0.17f;
        }
    }
    //Se resta una cantidad de monedas al jugador
    public void DesventajaMultasRegulaciones(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 2500;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 2000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 2200;
        }
    }

}
