using System.Collections;
using System.Collections.Generic;
using Tacticsoft;
using UnityEngine;

public class ProductTableViewController : MonoBehaviour, ITableViewDataSource {

    public TableView tableView;
    public ProductTableCell cellPrefab;


    void Awake()
    {
        tableView.dataSource = this;
    }

    public TableViewCell GetCellForRowInTableView(TableView tableView, int row)
    {
        ProductTableCell cell = tableView.GetReusableCell(cellPrefab.reuseIdentifier) as ProductTableCell;
        if(cell == null)
        {
            cell = (ProductTableCell)GameObject.Instantiate(cellPrefab);
        }
        ProductDataModel model = GameController.Instance.allProducts[row];
        if(model !=null)
        {
            cell.configureCellForDataModel(model);
        }
        return cell;

    }

    public float GetHeightForRowInTableView(TableView tableView, int row)
    {
        return 44;
    }

    public int GetNumberOfRowsForTableView(TableView tableView)
    {
        return GameController.Instance.allProducts.Count;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
