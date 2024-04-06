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


    public void VentajaFortuna(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount += 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount += 500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount += 750;
        }
    }
    public void VentajaFortuna2(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount += 3000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount += 2500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount += 2000;
        }
    }
    public void VentajaLluviaDiaria(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + (int)(ItemManager.verCoinsCount * 0.25);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + (int)(ItemManager.verCoinsCount * 0.15);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount + (int)(ItemManager.verCoinsCount * 0.18);
        }
    }
    public void VentajaPagoDeuda(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ElectionManager.deuda = ElectionManager.deuda - 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ElectionManager.deuda = ElectionManager.deuda - 500;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ElectionManager.deuda = ElectionManager.deuda - 780;
        }
    }
}
