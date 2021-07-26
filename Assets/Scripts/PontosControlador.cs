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
    public float pontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("TotalPontos", pontos);
    }
    
    // Update is called once per frame
    void Update()
    {
        pontosA = PlayerPrefs.GetFloat("TotalPontos");
        textoPontos.text = pontosA.ToString();
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
            PlayerPrefs.SetFloat("TotalPontosFases", pontosA);
            Destroy(objeto.gameObject);
        }

    }
}
