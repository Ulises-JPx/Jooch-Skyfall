using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NuevaCartaV", menuName = "CartaV")]	

public class CartaV : ScriptableObject{

    public string nombrecarta;
    public string descripcionVentaja;
    public string ventajaVerqor;
    public string ventajaCoyote;   
    public string ventajaBanco;

    public Sprite arteCarta;


    public void VentajaCompradorNacional(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.1f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.1f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.1f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.1f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.08f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.08f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.08f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.08f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.08f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.09f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.09f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.09f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.09f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.09f);
        }
    }
    public void VentajaNuevaCertificacion(){
        if(ElectionManager.TipoFinanciamiento == 1){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.17f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.17f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.17f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.17f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.17f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.15f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.15f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.15f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.15f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.15f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            RecapScript.precioMaiz = RecapScript.precioMaiz + (RecapScript.precioMaiz * 0.20f);
            RecapScript.precioCafe = RecapScript.precioCafe + (RecapScript.precioCafe * 0.20f);
            RecapScript.precioJitomate = RecapScript.precioJitomate + (RecapScript.precioJitomate * 0.20f);
            RecapScript.precioAguacate = RecapScript.precioAguacate + (RecapScript.precioAguacate * 0.20f);
            RecapScript.precioChile = RecapScript.precioChile + (RecapScript.precioChile * 0.20f);
        }
    }
    public void VentajaLluviaModerada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            Debug.Log("Lluvia moderada Verqor");
        }else if(ElectionManager.TipoFinanciamiento == 2){
            Debug.Log("Lluvia moderada Coyote");
        }else if(ElectionManager.TipoFinanciamiento == 3){
            Debug.Log("Lluvia moderada Banco");
        }
    }
    public void VentajaNegociacionInteligente(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ElectionManager.interes = ElectionManager.interes - 0.02f;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.interes = ElectionManager.interes - 0.01f;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.interes = ElectionManager.interes - 0.018f;
        }
    }

    public void VentajaReduccionDeDeuda(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ElectionManager.deuda = ElectionManager.deuda - (ElectionManager.deuda * 0.1f);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.deuda = ElectionManager.deuda - (ElectionManager.deuda * 0.05f);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.deuda = ElectionManager.deuda - (ElectionManager.deuda * 0.07f);
        }      
    }
    public void VentajaVentaExitosa(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + 1300;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + 900;
        }
    }
}