using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopPanel;
    // Start is called before the first frame update
    void Start()
    {
        ShopPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShopButtonClick()
    {
        if (ShopPanel.active == false) ShopPanel.SetActive(true);
        else ShopPanel.SetActive(false);
    }
}
