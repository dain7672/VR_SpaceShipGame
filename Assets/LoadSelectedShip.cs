using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectedShip : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;
    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("ShipType") == 2)
        {
            ship02.SetActive(true);
        }
        else
        {
            ship01.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
