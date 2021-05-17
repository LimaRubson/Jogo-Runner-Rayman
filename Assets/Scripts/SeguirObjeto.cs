using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirObjeto : MonoBehaviour
{
    public Transform objetoParaSeguir;
    public float velocidade; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void LateUpdate () {

        //Seguindo Objeto no X e no Y
        transform.position = Vector3.Lerp(transform.position, new Vector3(objetoParaSeguir.position.x,objetoParaSeguir.position.y,-10), velocidade * Time.deltaTime);
     
	}
}
