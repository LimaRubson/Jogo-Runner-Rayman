using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirador : MonoBehaviour {

    [Header("Atirar para direita")]
    public GameObject Tiro;
    public float direcao;
    public bool automatico;
    public float tempo;
    public KeyCode tecla;
    float timer;

    private void Update()
    {
        if (Tiro)
        {
            if (automatico)
            {
                timer += Time.deltaTime;
                if (timer >= tempo)
                {
                    timer = 0;
                    Atirar();
                }
            }else if (Input.GetKeyDown(tecla))
            {
                timer = 0;
                Atirar();
            }
        }
           
    }

    public void Atirar()
    {
        GameObject tiro = Instantiate(Tiro, transform.position,Quaternion.identity);

        tiro.transform.Rotate(0, 0, direcao,Space.World);
        
        if (tiro.transform.childCount > 0)
        {
            Destroy(tiro, 0.5f);

        }
    }
}
