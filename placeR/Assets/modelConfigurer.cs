using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelConfigurer : MonoBehaviour {

    public GameObject modelObject;

	void Start () {
        ProductDataModel model = GameController.Instance.currentlySelected;
        GameObject modelOutput = GameObject.Instantiate(model.prefab);
        modelOutput.transform.parent = modelObject.transform;
    }
}
