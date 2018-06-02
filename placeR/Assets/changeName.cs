using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeName : MonoBehaviour {

    private bool state = false;
    public Text label;

    public void toggleName()
    {
        state = !state;
        if (state)
        {
            label.text = "unlock";
        } else
        {
            label.text = "lock";
        }
    }
}
