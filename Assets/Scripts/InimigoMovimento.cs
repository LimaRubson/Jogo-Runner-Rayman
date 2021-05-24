using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    public float velocidade;
    int direcao = -1;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        //fazendo andar
        myRigidbody.velocity = new Vector3(direcao * velocidade * Time.deltaTime , myRigidbody.velocity.y);

        //fazendo girar quando bater na parede
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right * direcao, 0.6f);
        
        if (hit.collider != null && hit.collider.tag != "Player")
        {
            direcao *= -1;

            if(transform.rotation.y == 0)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);

            }

        }
    }
}
