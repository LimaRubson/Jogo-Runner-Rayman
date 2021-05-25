using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPontos : MonoBehaviour
{
    public float totalPontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalPontos = PlayerPrefs.GetFloat("TotalPontos");
        GetComponent<Text>().text = "Total de Coins Gold: " + totalPontos;
    }
}
