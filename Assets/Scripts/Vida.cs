using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public float vida = 3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("TotalVida", vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
