# UnityWebcamTool
**WebTool.cs** is a simple script to control webcam in Unity.
There is a **Test_WebcamTool** sample scene showing how to use the script.

How to Use
---
- Attach **WebTool.cs** to a GameObject.
- In the inpector, set your webcam device name and requested resolution.
- (optional) Assign a material to apply the WebCamTexture.
- In another script, reference to the **WebTool** component and call `Init()` function in Start(). Enter play mode and your webcam will be opened. If `targetMaterial` is assigned in the previous step, its mainTexture will be automatically replaced with WebCamTexture.

Scripting Reference
---
- `Init()` opens webcam and starts rendering to WebCamTexture. If `targetMaterial` has been assigned, its mainTexture will be automatically replaced with WebCamTexture.
- Texture `GetWebcamTex()` returns the WebCamTexture.
- `SetToMaterial(Material _material)` applys WebCamTexture to the material's mainTexture.
- `PauseWebcam()` pauses the webcam input.
- `PlayWebcam()` starts the webcam input.

Note
---
This project use Git submodule [gm_WebcamTool](https://github.com/GimChuang/gm_WebcamTool). You need to call
```
git clone --recurse-submodules https://github.com/GimChuang/UnityWebcamTool.git
``` 
when you clone this reposiory.

