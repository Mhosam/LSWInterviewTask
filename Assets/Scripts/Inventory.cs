using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public int coins;
    public Text coinHolder;
    public int equippedOutfit;
    public Image[] outfits;
    public GameObject panelOutfits;
    public int numOfOutfits;

    // Start is called before the first frame update
    void Start()
    {
        equippedOutfit = 0;
        coins = 1000;
        numOfOutfits = 1;
    }

    // Update is called once per frame
    void Update()
    {
        coinHolder.text = coins + "$";

    }
    
    
}
