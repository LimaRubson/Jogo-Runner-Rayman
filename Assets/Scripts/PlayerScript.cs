using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Velocidade = 2;
    public bool Pulo;
    public float forçaDoPulo;
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
        if (outroObjeto.collider.tag == "Inimigo")
        {
            //Reinicia a mesma cena
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
