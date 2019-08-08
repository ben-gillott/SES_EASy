using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{

	public Camera cam;
	public LineRenderer lr;
    private List<Vector3> positions = new List<Vector3>();
    // Start is called before the first frame update
    void Start()
    {
    	// cam = Camera.main;
    }

    // Update is called once per frame
    void OnGUI()
    {
    	// Vector3 mousePos = Input.mousePosition();

    	// Vector3 test = new Vector3(30,30,-30);
        
        // transform.position =;

        Vector3 point = new Vector3();
        Event   currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        // Get the mouse position from Event.
        // Note that the y position from Event is inverted.
        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane + 10));

        transform.position = point;

        GUILayout.BeginArea(new Rect(20, 20, 250, 120));
        GUILayout.Label("Screen pixels: " + cam.pixelWidth + ":" + cam.pixelHeight);
        GUILayout.Label("Mouse position: " + mousePos);
        GUILayout.Label("World position: " + point.ToString("F3"));
        GUILayout.EndArea();
 		


 		// if (Input.GetMouseButtonDown(0)){
 			// positions.Add(point);


    }

    void Update(){
    	// lr = GetComponent<LineRenderer>();
        // lr.material = new Material(Shader.Find("Sprites/Default"));

        // Set some positions
        
  		// positions.Add(new Vector3(0,0,0));
  		// positions.Add(new Vector3(0,10,0));
  		// positions.Add(new Vector3(10,10,0));
  		// positions.Add(new Vector3(10,0,0));
  		
  		// Vector3[] posArr = positions.ToArray();

        // lr.positionCount = posArr.Length;

		// lr.SetPositions(posArr);

    }




}







