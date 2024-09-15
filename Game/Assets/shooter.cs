using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject chooseshootingmaterial; 
    public float bulletspeed = 50f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulletvar = Instantiate(chooseshootingmaterial, transform.position, Quaternion.identity); 
        Rigidbody rb = bulletvar.AddComponent<Rigidbody>(); 
        rb.useGravity = false; 
        rb.velocity = transform.forward * bulletspeed; 

        Destroy(bulletvar, 2f); 
    }
}
