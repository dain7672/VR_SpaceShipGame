using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject explosionParticle;
    private void OnTriggerEnter(Collider other)
    {
        explosion();
    }

    private void OnCollisionEnter(Collision other)
    {
        explosion();
    }
    void explosion()
    {
        explosionParticle.SetActive(true);
        GetComponent<MeshRenderer>().enabled = false;
        // Destroy(gameObject); 
        //destroy 해버리면, explosion도 사라지므로, meshrenderer만 false로 바꿈.
        Invoke("destroyObject", 2f);
        // -> invoke를 사용하면 n초 뒤에 object 정리가 가능
        // mesh rederer 만 false이면, 충돌이 가능할까?
    }

    void destroyObject()
    {
        Destroy(gameObject);
    }
}
