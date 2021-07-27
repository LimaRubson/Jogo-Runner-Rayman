using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusFase3 : MonoBehaviour
{
    private float bonusFase3 = 3;
    private float timeFase3 = 3;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("BonusFase3", bonusFase3);
        PlayerPrefs.SetFloat("TimeFase3", timeFase3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
