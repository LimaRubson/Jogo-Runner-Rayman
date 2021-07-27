using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento6 : MonoBehaviour
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
        PlayerPrefs.SetFloat("Tiro7", tiroA);
    }

    // Update is called once per frame
    void Update()
    {
        //fazendo andar
        myRigidbody.velocity = new Vector3(direcao * velocidade * Time.deltaTime , myRigidbody.velocity.y);
        tiroA = PlayerPrefs.GetFloat("Tiro7");
        if(tiroA == 7) {
            Debug.Log("Morreu");
            Destroy(this.gameObject);
        }
    }
}
