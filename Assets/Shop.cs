using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject Player;
    public Dropdown ColorDropdown;
    public Material[] PlayersMat = new Material[3];

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

    public void ColorChange()
    {
        int i = ColorDropdown.value;
        Player.GetComponent<MeshRenderer>().material = PlayersMat[i];
    }
}
