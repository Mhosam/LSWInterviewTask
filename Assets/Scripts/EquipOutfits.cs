using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipOutfits : MonoBehaviour
{
    public bool isActive;
    public Text text;
    public GameObject player;
    public GameObject changeFirst;
    public GameObject buy;
    public GameObject sell;
    public GameObject equip;

    public GameObject outfit;

    private void Update()
    {
        if (isActive)
        {
            text.text = "Equipped";
        }
        else
        {
            text.text = "Equip";
        }
    }
    public void ChangeOutfit(Sprite sprite)
    {
        isActive = true;
        outfit.GetComponent<SpriteRenderer>().sprite = sprite;
    }
    public void TakeoffOutfit()
    {
        isActive = false;
    }

    public void BuyOutfit()
    {
        if (player.GetComponent<Inventory>().coins >= 100)
        {
            player.GetComponent<Inventory>().coins -= 100;
            buy.SetActive(false);
            sell.SetActive(true);
            equip.SetActive(true);
        }
    }
    public void SellOutfit()
    {
        if (!isActive)
        {
            player.GetComponent<Inventory>().coins += 100;
            buy.SetActive(true);
            sell.SetActive(false);
            equip.SetActive(false);
        }
        else
        {
            changeFirst.SetActive(true);
        }
    }
}
