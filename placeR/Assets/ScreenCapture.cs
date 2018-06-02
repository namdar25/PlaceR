using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCapture : MonoBehaviour {

    public CanvasGroup myCG;
    private bool flash = false;

    public void OnCameraClick()
    {
        flash = true;
        myCG.alpha = 1;
        UnityEngine.ScreenCapture.CaptureScreenshot("Somefurniture");
    }



    void Update()
    {
        if (flash)
        {
            myCG.alpha = myCG.alpha - Time.deltaTime;
            if (myCG.alpha <= 0)
            {
                myCG.alpha = 0;
                flash = false;
            }
        }
    }
}