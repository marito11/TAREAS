using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            texto.text= "Es de Pistache";
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            texto.text= "Es de Chicle";
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            texto.text= "Es de Chocolate";
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            texto.text= "Es de Frambueza";
        }
    }
}
