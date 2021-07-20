using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    private bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPress() {

        if(pause == false){
            Time.timeScale = 0;
            pause = true;
        } else {
            Time.timeScale = 1;
            pause = false;
        }
        
    }
}
