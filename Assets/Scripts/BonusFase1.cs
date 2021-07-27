using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusFase1 : MonoBehaviour
{
    private float bonusFase1 = 1;
    private float timeFase1 = 1;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("BonusFase1", bonusFase1);
        PlayerPrefs.SetFloat("TimeFase1", timeFase1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
