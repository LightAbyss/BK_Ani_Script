using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GenSceneSW : MonoBehaviour{
    public Image BT;

    public void CambioScene(string scname){
        SceneManager.LoadScene(scname);
    }
}
