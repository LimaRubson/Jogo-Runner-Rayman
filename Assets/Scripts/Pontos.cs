using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    public float pontosTotalFases = 0;
    public float somaPontosFases = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("TotalPontosFases", pontosTotalFases);
        PlayerPrefs.SetFloat("SomaPontosFases", somaPontosFases);
    }

    // Update is called once per frame
    void Update()
    {
        somaPontosFases += PlayerPrefs.GetFloat("TotalPontosFases");
        PlayerPrefs.SetFloat("SomaPontosFases", somaPontosFases);
    }
}
