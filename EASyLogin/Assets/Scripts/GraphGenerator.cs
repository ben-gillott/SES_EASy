using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphGenerator : MonoBehaviour
{
    private int widthScale = 2;
    private float smoothness = .125f;
    private GameObject[] bars;
    private bool spreadDone = false;
    private bool growDone = false;


    public int[] graphValues = new int[12]; 
    //{1, 2, 5, 6, 4, 3, 6, 8, 6, 4, 6, 10, 0};
    // Start is called before the first frame update
    void Start(){

        bars = new GameObject[gameObject.transform.childCount];

        for(int i = 0; i < bars.Length; i++){
            bars[i] = gameObject.transform.GetChild(i).gameObject;
        }

    
    }

    // Update is called once per frame
    void Update()
    {

        if (!spreadDone){
            for(int i = 0; i < bars.Length; i++){
                Vector3 desPos = gameObject.transform.position + new Vector3(widthScale*i, 0f, 0f);
                Vector3 smoothPos = Vector3.Lerp (bars[i].transform.position, desPos, smoothness);
                bars[i].transform.position = smoothPos;

                if(i == bars.Length-1 && bars[i].transform.position.x > desPos.x - .1f){
                    spreadDone = true;
                }
            }
        }

        else if (!growDone){
            for(int i = 0; i < bars.Length; i++){
                Vector3 desPos = gameObject.transform.position + new Vector3(widthScale*i, graphValues[i], 0);
                Vector3 smoothPos = Vector3.Lerp (bars[i].transform.position, desPos, smoothness);
                
                while(bars[i].transform.position.y < smoothPos.y){
                    bars[i].transform.localScale += new Vector3(0, smoothness, 0);
                    bars[i].transform.position += new Vector3(0, smoothness/2, 0);
                }
                if(i == bars.Length-1 && bars[i].transform.position.y > desPos.y - .1f){
                    growDone = true;
                }
            }
        }
    }
}
