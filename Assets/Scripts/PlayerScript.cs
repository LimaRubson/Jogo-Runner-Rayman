using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float Velocidade = 2;
    private float num = 0;
    public bool Pulo;
    public float forçaDoPulo;
    private float pontosA = 0;
    private float vidaA = 3;
    private float bonusFase1 = 0;
    private float bonusFase2 = 0;
    private float bonusFase3 = 0;
    Rigidbody2D meuCorpo;
    Animator meuAnim;

    // Start is called before the first frame update
    void Start()
    {
        meuCorpo = GetComponent<Rigidbody2D>();
        meuAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vidaA = PlayerPrefs.GetFloat("TotalVida");
        pontosA = PlayerPrefs.GetFloat("TotalPontos");
        bonusFase1 = PlayerPrefs.GetFloat("BonusFase1");
        bonusFase2 = PlayerPrefs.GetFloat("BonusFase2");
        bonusFase3 = PlayerPrefs.GetFloat("BonusFase3");
        
        if(pontosA == 60 && num == 0) {
            num = 1;
            vidaA += 3;
            PlayerPrefs.SetFloat("TotalVida", vidaA);
        }
        if(pontosA == 100 && num == 0) {
            num = 1;
            vidaA += 3;
            PlayerPrefs.SetFloat("TotalVida", vidaA);
        }
        float velX = Input.GetAxisRaw("Horizontal");		
        meuCorpo.velocity = new Vector2(velX * Velocidade, meuCorpo.velocity.y);
        if(Input.GetKeyDown("space"))
		{
			if(Pulo == false)
			{
				meuCorpo.velocity += new Vector2(0, forçaDoPulo);
				Pulo = true;
			}
		}

        if(velX	== 1f)
          {
            transform.rotation = new Quaternion(0,0,0,0);
          }
        else if(velX == -1f)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
        meuAnim.SetInteger("velocidade", Mathf.RoundToInt(meuCorpo.velocity.x));
    }

    void OnCollisionEnter2D(Collision2D outroObjeto)
	{
		Pulo = false;

        // Colisões - Morrer 
        if (outroObjeto.collider.tag == "Inimigo" || outroObjeto.collider.tag == "Inimigo1" || outroObjeto.collider.tag == "Inimigo2" || outroObjeto.collider.tag == "Inimigo3" || outroObjeto.collider.tag == "Inimigo4")
        {
            //Reinicia a mesma cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (outroObjeto.collider.tag == "Nivel2" && pontosA > 29)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("ObjetivosNivel2");
        }

        if (outroObjeto.collider.tag == "Nivel3" && pontosA > 99)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("level3");
        }

        if (outroObjeto.collider.tag == "BandeiraAzul")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("RESULTADO");
        }
	}
}
