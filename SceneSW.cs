using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSW : MonoBehaviour{
    //Declaracion de variable para conocer el modo
    public Text modo;
    
    string ind = "0",ser = "1", par = "2";

    //Metodo para cambiar las escenas
    /*Nota: La idea es poder ir a cada grupo de escenas (Fuente, Circuito, Frontal) utilizando un número. Luego, si no
    es para ir al frontal, se revisa el modo en que está y se va hacia ese modo. La variable mode es quien tiene el modo
    de operacion. Para los grupos Circuito y Fuente, esta es una constante ya que el mismo nombre de la escena dice el
    modo.*/
    public void ChangeSc(int sc){
        /*sc=0 -> Fuente
          sc=1 -> circuito
          sc=2 -> frontal*/

        switch(sc){
            case 0:
                if(modo.text == ind){
                    SceneManager.LoadScene("FuenteInd");
                }else if(modo.text == ser){
                    SceneManager.LoadScene("FuenteSer");
                }else if(modo.text == par){
                    SceneManager.LoadScene("FuentePar");
                }
                break;
            case 1:
                if(modo.text == ind){
                    SceneManager.LoadScene("CircuitoInd");
                }else if(modo.text == ser){
                    SceneManager.LoadScene("CircuitoSer");
                }else if(modo.text == par){
                    SceneManager.LoadScene("CircuitoPar");
                }
                break;
            case 2:
                SceneManager.LoadScene("Frontal");
                break;
        }
        
    }
}
