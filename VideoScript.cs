using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoScript : MonoBehaviour{
    public VideoPlayer video;
    //Esta es la URL del lugar donde se sube el juego. Toca buscarla con F12 cuando se suba el juego
    string url = "https://v6p9d9t4.ssl.hwcdn.net/html/7648507/Video/Intro.mp4";
    
    void Awake() {
        video = GetComponent<VideoPlayer>(); //Variable que apunta al objeto video
        video.url = url;
        video.Play(); //Reproducir video
        video.loopPointReached += Finish; //Cuando el video acabe, llamar funcion "Finish"
    }
    //Al finalizar ir al panel frontal
    void Finish(VideoPlayer vp){
        SceneManager.LoadScene("Frontal");
    }
}
