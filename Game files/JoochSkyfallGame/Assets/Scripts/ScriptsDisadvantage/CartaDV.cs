using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NuevaCartaDV", menuName = "CartaDV")]	

public class CartaDV : ScriptableObject{

    public string nombrecartaDv;
    public string descripcionDesventaja;
    public string desventajaVerqor;
    public string desventajaCoyote;   
    public string desventajaBanco;

    public Sprite arteCartaDv;

    public void DesventajaSiniestroHelada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 300;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 2500;
        }
    }
    public void DesventajaSiniestroSequia(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 5000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 5000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 4000;
        }
    }
    public void DesventajaEnfermedad(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 1100;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount = ItemManager.verCoinsCount - 1200;
        }
    }

}
