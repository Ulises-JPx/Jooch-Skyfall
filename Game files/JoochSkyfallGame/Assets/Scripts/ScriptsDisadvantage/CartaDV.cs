using UnityEngine;

[CreateAssetMenu(fileName = "CartaDesventaja", menuName = "CartaDesventaja")]	

public class CartaDV : ScriptableObject{

    public int D_id;

    public string D_titulo;
    public string D_descripcion;
    public string D_verqor;
    public string D_coyote;
    public string D_canco;

    // public Sprite D_img;

    public void DesventajaSiniestroHelada(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 300;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 3000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 2500;
        }
    }
    public void DesventajaSiniestroSequia(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 5000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 5000;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 4000;
        }
    }
    public void DesventajaEnfermedad(){
        if(ElectionManager.TipoFinanciamiento == 1){
            ItemManager.verCoinsCount -= 1000;
        }else if(ElectionManager.TipoFinanciamiento == 2){
            ItemManager.verCoinsCount -= 1100;
        }else if(ElectionManager.TipoFinanciamiento == 3){
            ItemManager.verCoinsCount -= 1200;
        }
    }

}
