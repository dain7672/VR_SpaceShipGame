using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShip : MonoBehaviour
{
    public void shipBlue()
    {
        PlayerPrefs.SetInt("ShipType", 1);
        SceneManager.LoadScene("GameScene");
    }
    
    public void shipRed()
    {
        PlayerPrefs.SetInt("ShipType", 2);
        SceneManager.LoadScene("GameScene");
    }
}
