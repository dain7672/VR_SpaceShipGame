using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject SpaceShip;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 5f);
    }
}
