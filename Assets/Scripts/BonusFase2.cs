using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusFase2 : MonoBehaviour
{
    private float bonusFase2 = 2;
    private float timeFase2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("BonusFase2", bonusFase2);
        PlayerPrefs.SetFloat("TimeFase1", timeFase2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
