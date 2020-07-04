using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        explosion();
    }
    void explosion()
    {
        Destroy(gameObject);
    }
}
