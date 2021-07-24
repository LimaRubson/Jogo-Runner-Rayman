using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento2 : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    public float velocidade;
    int direcao = -1;
    private float tiroA = 0;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();   
        PlayerPrefs.SetFloat("Tiro3", tiroA);
    }

    // Update is called once per frame
    void Update()
    {
        //fazendo andar
        myRigidbody.velocity = new Vector3(direcao * velocidade * Time.deltaTime , myRigidbody.velocity.y);
        myAnimator.SetInteger("velocidade", Mathf.RoundToInt(myRigidbody.velocity.x));
        tiroA = PlayerPrefs.GetFloat("Tiro3");
        if(tiroA == 3) {
            Debug.Log("Morreu");
            Destroy(this.gameObject);
        }
    }
}
