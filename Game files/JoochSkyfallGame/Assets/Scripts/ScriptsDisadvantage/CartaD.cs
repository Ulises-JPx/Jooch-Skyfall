using System;
using UnityEngine;

[CreateAssetMenu(fileName = "CartaDesventaja", menuName = "CartaDesventaja")]	

public class CartaD : ScriptableObject{

    public int D_id;

    public string D_titulo;
    public string D_descripcion;
    public string D_verqor;
    public string D_coyote;
    public string D_banco;

    // public Sprite D_img;

    public void DesventajaSiniestroHelada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 300;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 2500;
        }
    }
    public void DesventajaSiniestroSequia(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 4000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 6000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 4000;
        }
    }
    public void DesventajaEnfermedad(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 1500;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 1500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 1500;
        }
    }
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
    public void DesventajaGatsosExtra(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 3000;
        }
    }
    public void DesventajaCalorExtremo(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 100;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 100;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 100;
        }
    }
    public void DesventajaEngano(){
        if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.interes += ElectionManager.interes * 0.4f;
        
        }
    }
    public void DesventajaConflictoNarco(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.12f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.11f);
        }
    }
    public void DesventajaCrisisMercado(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.35f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.25f);

        }
    }
    public void DesventajaInundacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 4000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 3500;
        }
    }
    public void DesventajaIncrementoCostos(){
        if(ElectionManager.TipoFinanciamiento == 1){
            Debug.Log("Desventaja Incremento Costos Verqor");
        }else if(ElectionManager.TipoFinanciamiento == 2){
            Debug.Log("Desventaja Incremento Costos Coyote");
        }else if(ElectionManager.TipoFinanciamiento == 3){
            Debug.Log("Desventaja Incremento Costos Banco");
        }
    }
    public void DesventajaRoboCosecha(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.2f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.25f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.22f);

        }
    }
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
    public void DesventajaAumentotasas(){
        if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.interes += ElectionManager.interes * 0.3f;
        }
    }

    public void DesventajaTarifaExortacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.15f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.12f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= (int)Math.Round(ItemManager.verCoinsCount * 0.14f);

        }

    }
    public void DesventajaEscazesAgua(){
        if(ElectionManager.TipoFinanciamiento == 1){
            Debug.Log("Desventaja Escazes Agua Verqor");
        }else if(ElectionManager.TipoFinanciamiento == 2){
            Debug.Log("Desventaja Escazes Agua Coyote");
        }else if(ElectionManager.TipoFinanciamiento == 3){
            Debug.Log("Desventaja Escazes Agua Banco");
        }
    }
    public void DesventajaIncendio(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= -2000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 5000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 5000;
        }
        
    }
    public void DesventajaAumentoCostoEnergetico(){
        if(ElectionManager.TipoFinanciamiento == 1){
            Debug.Log("Desventaja Aumento Costo Energetico Verqor");
        }else if(ElectionManager.TipoFinanciamiento == 2){
            Debug.Log("Desventaja Aumento Costo Energetico Coyote");
        }else if(ElectionManager.TipoFinanciamiento == 3){
            Debug.Log("Desventaja Aumento Costo Energetico Banco");
        }
    }
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
