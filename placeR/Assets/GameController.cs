using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject sofaPrefab;
    public GameObject cabinetPrefab;
    public GameObject deskPrefab;
    public GameObject benchPrefab;
    public GameObject modernDeskPrefab;
    public GameObject kitchenChairPrefab;
    public GameObject modernChairPrefab;
    public GameObject nightStandPrefab;
    public GameObject rockingChairPrefab;
    public GameObject woodenChairPrefab;

    public Sprite sofaSprite;
    public Sprite cabinetSprite;
    public Sprite deskSprite;
    public Sprite benchSprite;
    public Sprite modernDeskSprite;
    public Sprite kitchenChairSprite;
    public Sprite modernChairSprite;
    public Sprite nightStandSprite;
    public Sprite rockingChairSprite;
    public Sprite woodenChairSprite;

    // Make global
    public static GameController Instance
    {
        get;
        set;
    }

    void Awake()
    {
        Debug.Log("being called");
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;
        this.allProducts = new List<ProductDataModel>();
        this.allProducts.Add(createBench());
        this.allProducts.Add(createCabinet());
        this.allProducts.Add(createDesk());
        this.allProducts.Add(createModernDesk());
        this.allProducts.Add(createKitchenChair());
        this.allProducts.Add(createModernChair());
        this.allProducts.Add(createRockingChair());
        this.allProducts.Add(createSofa());
        this.allProducts.Add(createWoodenChair());
        this.allProducts.Add(createNightStand());
        SceneManager.LoadScene("CompanyLandingPage");
    }

    void Start()
    {
    }

    public ProductDataModel currentlySelected;
    public List<ProductDataModel> allProducts;

    private ProductDataModel createCabinet()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Cabinet";
        ret.dimensions = "60\" L x 22\" D x 70\"H";
        ret.materials = "Wood, Glass";
        ret.cost = 650f;
        ret.shippingHandeling = 200f;
        ret.prefab = cabinetPrefab;
        ret.sprite = cabinetSprite;
        return ret;
    }

    private ProductDataModel createSofa()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Sofa";
        ret.dimensions = "75\" L x 38\" D x 30\"H";
        ret.materials = "Wood, Cloth";
        ret.cost = 500f;
        ret.shippingHandeling = 100f;
        ret.prefab = sofaPrefab;
        ret.sprite = sofaSprite;
        return ret;
    }

    private ProductDataModel createDesk()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Desk";
        ret.dimensions = "50\" L x 30\" D x 30\"H";
        ret.materials = "Wood";
        ret.cost = 200f;
        ret.shippingHandeling = 80f;
        ret.prefab = deskPrefab;
        ret.sprite = deskSprite;
        return ret;
    }

    private ProductDataModel createModernDesk()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Modern Desk";
        ret.dimensions = "60\" L x 30\" D x 30\"H";
        ret.materials = "Wood, Metal";
        ret.cost = 250f;
        ret.shippingHandeling = 80f;
        ret.prefab = modernDeskPrefab;
        ret.sprite = modernDeskSprite;
        return ret;
    }

    private ProductDataModel createBench()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Bench";
        ret.dimensions = "70\" L x 20\" D x 25\"H";
        ret.materials = "Wood, Metal";
        ret.cost = 150f;
        ret.shippingHandeling = 100f;
        ret.prefab = benchPrefab;
        ret.sprite = benchSprite;
        return ret;
    }

    private ProductDataModel createKitchenChair()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Kitchen Chair";
        ret.dimensions = "25\" L x 25\" D x 36\"H";
        ret.materials = "Wood, Leather";
        ret.cost = 100f;
        ret.shippingHandeling = 50f;
        ret.prefab = kitchenChairPrefab;
        ret.sprite = kitchenChairSprite;
        return ret;
    }

    private ProductDataModel createModernChair()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Modern Chair";
        ret.dimensions = "70\" L x 25\" D x 36\"H";
        ret.materials = "Leather, Metal";
        ret.cost = 300f;
        ret.shippingHandeling = 80f;
        ret.prefab = modernChairPrefab;
        ret.sprite = modernChairSprite;
        return ret;
    }

    private ProductDataModel createNightStand()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Night Stand";
        ret.dimensions = "24\" L x 24\" D x 24\"H";
        ret.materials = "Wood, Brass";
        ret.cost = 120f;
        ret.shippingHandeling = 50f;
        ret.prefab = nightStandPrefab;
        ret.sprite = nightStandSprite;
        return ret;
    }

    private ProductDataModel createRockingChair()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Rocking Chair";
        ret.dimensions = "28\" L x 26\" D x 36\"H";
        ret.materials = "Wood";
        ret.cost = 70f;
        ret.shippingHandeling = 30f;
        ret.prefab = rockingChairPrefab;
        ret.sprite = rockingChairSprite;
        return ret;
    }

    private ProductDataModel createWoodenChair()
    {
        ProductDataModel ret = new ProductDataModel();
        ret.title = "Wooden Chair";
        ret.dimensions = "25\" L x 25\" D x 36\"H";
        ret.materials = "Wood";
        ret.cost = 70f;
        ret.shippingHandeling = 30f;
        ret.prefab = woodenChairPrefab;
        ret.sprite = woodenChairSprite;
        return ret;
    }
}