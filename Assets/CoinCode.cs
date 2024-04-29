using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCode : MonoBehaviour
{
    public float RotateSpeed = 100f;
    public GameObject aCoin;

    void OnTriggerEnter(Collider col)
    {
        // Tag∞° "" ¿œ ∂ß
        if (col.gameObject.tag == "Player")
        {
            // Deactive Item
            aCoin.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, RotateSpeed * Time.deltaTime);
    }
}
