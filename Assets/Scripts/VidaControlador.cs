using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaControlador : MonoBehaviour
{
    public Text textoVida;
    private float vidaA = 3;
    // Start is called before the first frame update
    void Start()
    {
        vidaA = PlayerPrefs.GetFloat("TotalVida");
        textoVida.text = vidaA.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        vidaA = PlayerPrefs.GetFloat("TotalVida");
        if(vidaA == 0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Game Over");
        }
    }

    // Colisões por Trigger -  Ganhar pontos
    void OnCollisionEnter2D(Collision2D outroObjeto)
	{

        if (outroObjeto.collider.tag == "Inimigo")
        {
            vidaA -= 1;
            textoVida.text = vidaA.ToString();
            PlayerPrefs.SetFloat("TotalVida", vidaA);
        }

    }
}
