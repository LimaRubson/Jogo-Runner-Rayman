using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosControlador : MonoBehaviour
{
    public Text textoPontos;
    public int pontos = 0;

    // Colisões por Trigger -  Ganhar pontos
    void OnTriggerEnter2D(Collider2D objeto)
    {

        if (objeto.tag == "Pontos")
        {
            pontos++;
            textoPontos.text = pontos.ToString();
            PlayerPrefs.SetFloat("TotalPontos", pontos);
            Destroy(objeto.gameObject);
        }

    }
}
