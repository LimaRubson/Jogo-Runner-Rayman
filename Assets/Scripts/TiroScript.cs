using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroScript : MonoBehaviour {

    public float velocidade;
    public bool Amigo;
    public int Dano;
    Rigidbody2D myrig;

	// Use this for initialization
	void Start () {

       transform.SetParent(null);
       myrig = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {

        myrig.transform.Translate(Vector3.up * velocidade * Time.deltaTime);

        if(transform.position.x > 10 || transform.position.x < -10 || transform.position.y > 6 || transform.position.y < -6)
        {
            Destroy(this.gameObject);

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            if (!Amigo)
            {
                //collision.SendMessage("perderVida", Dano);
                Destroy(this.gameObject);
            }
        }else if (collision.transform.CompareTag("Inimigo"))
        {
            if (Amigo)
            {
                //collision.SendMessage("perderVida", Dano);
                Destroy(this.gameObject);
            }
        }
    }
}
