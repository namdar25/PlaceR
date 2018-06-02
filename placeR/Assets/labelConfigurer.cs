using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class labelConfigurer : MonoBehaviour {

    public Image sprite;
    public Text title;
    public Text dimensions;
    public Text materials;
    public Text cost;
    public Text shippingHandeling;
    public Text tax;
    public Text total;

    void Start () {
        ProductDataModel model = GameController.Instance.currentlySelected;
        this.sprite.sprite = model.sprite;
        this.title.text = model.title;
        this.dimensions.text = model.dimensions;
        this.materials.text = model.materials;
        this.cost.text = "$" + model.cost.ToString();
        this.shippingHandeling.text = "$" + model.shippingHandeling.ToString();
        this.tax.text = "+   $" + (model.cost * 0.1f).ToString();
        this.total.text = "$" + (model.cost * 1.1f + model.shippingHandeling).ToString();
    }

}
