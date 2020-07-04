using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public GameObject Head;
    public GameObject SpaceShip;
    public GameObject Cam;
    
    float currentRotation;
    float previousRotation;
    float deltaRotation; //기본값이 0으로 존재하는 듯하다.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 10f);
        tilt();
    }

    void tilt() //캠이 바라보는 방향(이전 프레임 기준으로) 에 따라 좌우로 회전하게 함.
    {
        currentRotation = Cam.transform.eulerAngles.y;
        deltaRotation = currentRotation - previousRotation; 
        previousRotation = currentRotation;

        if (deltaRotation > 0)
        {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x,
                    SpaceShip.transform.localRotation.y,
                    -45),
                Time.deltaTime);
        } else if (deltaRotation < 0)
        {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x,
                    SpaceShip.transform.localRotation.y,
                    45),
                Time.deltaTime);
        } else {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation,
                Quaternion.Euler(SpaceShip.transform.localRotation.x,
                    SpaceShip.transform.localRotation.y,
                    0),
                Time.deltaTime);
        }
    }
}
