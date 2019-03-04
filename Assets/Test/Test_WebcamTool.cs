using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_WebcamTool : MonoBehaviour {

    public WebcamTool webcamTool;
    public Material targetMaterial;
	
	void Start () {

        webcamTool = FindObjectOfType<WebcamTool>();
        if (webcamTool)
            webcamTool.Init();
        else
            Debug.LogError("WebcamUtility Not Found");

        targetMaterial.mainTexture = webcamTool.GetWebcamTex();
    }
	
	void Update () {
		
	}
}
