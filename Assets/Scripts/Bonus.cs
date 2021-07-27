using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    private float pontosA = 0;
    private float vidaA = 3;
    public float timer = 5;
    private float timerA1 = 5;
    private float timerA2 = 5;
    private float timerA3 = 5;
    private float timeFase1 = 0;
    private float timeFase2 = 0;
    private float timeFase3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaA = PlayerPrefs.GetFloat("TotalVida");
        pontosA = PlayerPrefs.GetFloat("TotalPontos");
        timeFase1 = PlayerPrefs.GetFloat("TimeFase1");
        timeFase2 = PlayerPrefs.GetFloat("TimeFase2");
        timeFase3 = PlayerPrefs.GetFloat("TimeFase3");

        if(pontosA == 60 && timeFase1 == 1){
            GetComponent<Text>().text = "Bonus : )! Você ganhou + 3 vidas : )";
            timerA1 -= Time.deltaTime;
            Debug.Log(timerA1);
            if(timerA1 < 0) {
                GetComponent<Text>().text = "";
            }
        }

        if(pontosA == 170 && timeFase2 == 2){
            GetComponent<Text>().text = "Bonus : )! Você ganhou + 3 vidas : )";
            timerA2 -= Time.deltaTime;
            Debug.Log(timerA2);
            if(timerA2 < 0) {
                GetComponent<Text>().text = "";
            }
        }

        if(pontosA == 250 && timeFase3 == 3){
            GetComponent<Text>().text = "Bonus : )! Você ganhou + 3 vidas : )";
            timerA3 -= Time.deltaTime;
            Debug.Log(timerA3);
            if(timerA3 < 0) {
                GetComponent<Text>().text = "";
            }
        }
    }
}
