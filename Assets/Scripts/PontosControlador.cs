using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosControlador : MonoBehaviour
{
    public Text textoPontos;
    private float pontosA = 0;
    public AudioClip mySound;
    public AudioSource mySource;
    
    // Update is called once per frame
    void Update()
    {
        pontosA = PlayerPrefs.GetFloat("TotalPontos");
    }

    // Colisões por Trigger -  Ganhar pontos
    void OnTriggerEnter2D(Collider2D objeto)
    {

        if (objeto.tag == "Pontos")
        {
            // in method, assign the clip to the audioSource
            mySource.clip = mySound;
            // AudioSource.Play();
            mySource.Play();
            pontosA += 1;
            textoPontos.text = pontosA.ToString();
            PlayerPrefs.SetFloat("TotalPontos", pontosA);
            Destroy(objeto.gameObject);
        }

    }
}
