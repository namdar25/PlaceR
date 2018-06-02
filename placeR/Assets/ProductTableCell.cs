using System.Collections;
using System.Collections.Generic;
using Tacticsoft;
using UnityEngine;
using UnityEngine.UI;

public class ProductTableCell : TableViewCell {

    public Text label;
    public ProductDataModel model;
	// Use this for initialization
    public void configureCellForDataModel(ProductDataModel model)
    {
        this.label.text = model.title;
        this.model = model;
    }

    public void handelClicked()
    {
        GameController.Instance.currentlySelected = model;
        this.GetComponent<ScreenChange>().ChangeMenuScene("ARScreen");
    }

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
