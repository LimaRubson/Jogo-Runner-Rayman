using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public float pontosTotalFases = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("TotalPontosFases", pontosTotalFases);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
