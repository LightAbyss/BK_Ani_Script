using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSW : MonoBehaviour{

    private GenSceneSW escena;
    public Sprite intro;
    public Image fondo;

    void Start() {
        escena = FindObjectOfType<GenSceneSW>();
    }

    public void SCambio(){
        fondo.sprite = intro;
        StartCoroutine(delay());
    }

    public IEnumerator delay(){
        yield return new WaitForSeconds(2);
        escena.CambioScene("Ayuda");
    }

}
