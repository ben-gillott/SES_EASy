using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using static PhotoUploadT;


public class SignManager : MonoBehaviour
{
    //  //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            // ScreenCapture.CaptureScreenshot("Screenshots/Signature.jpg");
            SceneManager.LoadSceneAsync("Loading_Scene1", LoadSceneMode.Single);
        }

        //TODO: Uncomment to for 
        // if (Input.GetKeyDown("z")){
        //     PhotoUploadT p = new PhotoUploadT();
        //     p.CallThisInPhotoUpload();
        // }
    }
}
