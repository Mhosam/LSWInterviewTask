using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{

    public GameObject text;
    bool inShopArea = false;
    public GameObject shop;
    bool open = false;
    
    private void Update()
    {
        if (inShopArea)
        {
            if (Input.GetKeyDown(KeyCode.E) && !open)
            {
                shop.SetActive(true);
                text.SetActive(false);
                gameObject.GetComponent<PlayerMovement>().inShop = true;
                open = true;
            }
            else if (Input.GetKeyDown(KeyCode.E) && open)
            {
                shop.SetActive(false);
                text.SetActive(true);
                gameObject.GetComponent<PlayerMovement>().inShop = false;
                open = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shop"))
        {
            inShopArea = true;
            text.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Shop"))
        {
            inShopArea = false;
            text.SetActive(false);
        }
    }
}
