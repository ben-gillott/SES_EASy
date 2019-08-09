using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AccountSelector : MonoBehaviour
{
    private int selected = -1;
    GameObject cubeZero;
    GameObject cubeOne;

    Renderer rendZero;
    Renderer rendOne;
    
    void Start()
    {
        cubeZero = gameObject.transform.GetChild(0).gameObject;
        cubeOne = gameObject.transform.GetChild(1).gameObject;

        rendZero = cubeZero.GetComponent<Renderer>();
        rendOne = cubeOne.GetComponent<Renderer>();

        // rendZero.material.shader = Shader.Find("Specular");
        // rendOne.material.shader = Shader.Find("Specular");

        rendOne.material.SetColor("_Color", Color.red);
        rendZero.material.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")){
            selected = 0;

            rendZero.material.SetColor("_Color", Color.blue);
            rendOne.material.SetColor("_Color", Color.red);

            //Set 
        }
        else if (Input.GetKeyDown("right")){
            selected = 1;
            rendOne.material.SetColor("_Color", Color.blue);
            rendZero.material.SetColor("_Color", Color.red);
        }


        if(Input.GetKeyDown("space")){
            //Switch to account
            SceneManager.LoadSceneAsync("Account", LoadSceneMode.Single);
        }



    }

    // rend.material.shader = Shader.Find("_Color");
    //     rend.material.SetColor("_Color", Color.green);

    //     //Find the Specular shader and change its Color to red
    //     rend.material.shader = Shader.Find("Specular");
    //     rend.material.SetColor("_SpecColor", Color.red);
}
