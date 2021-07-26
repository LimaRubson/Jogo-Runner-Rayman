using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida = 3;
    public float bonusFase1 = 1;
    public float bonusFase2 = 2;
    public float bonusFase3 = 3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("TotalVida", vida);
        PlayerPrefs.SetFloat("BonusFase1", bonusFase1);
        PlayerPrefs.SetFloat("BonusFase2", bonusFase2);
        PlayerPrefs.SetFloat("BonusFase3", bonusFase3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
