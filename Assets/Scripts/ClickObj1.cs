using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObj1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress() {
       UnityEngine.SceneManagement.SceneManager.LoadScene("ObjetivosNivel1");
    }
}
