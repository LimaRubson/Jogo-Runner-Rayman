using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoFish : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         myAnimator.SetInteger("velocidade", Mathf.RoundToInt(myRigidbody.velocity.x));
    }
}
