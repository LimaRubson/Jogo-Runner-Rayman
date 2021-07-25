using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    private float pontosA = 0;
    private float vidaA = 3;
    public float timer = 5;
    private float timerA = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaA = PlayerPrefs.GetFloat("TotalVida");
        pontosA = PlayerPrefs.GetFloat("TotalPontos");

        if(pontosA == 60){
            GetComponent<Text>().text = "Bonus : )! Você ganhou + 3 vidas : )";
            timerA -= Time.deltaTime;
            Debug.Log(timerA);
            if(timerA < 0) {
                GetComponent<Text>().text = "";
            }
        }
    }
}
