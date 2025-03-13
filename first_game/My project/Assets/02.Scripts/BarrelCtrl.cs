using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl : MonoBehaviour
{
    public GameObject expEffect;
    public Texture[] textures;
    private Transform tr;

    private int hitCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();

        int idx = Random.Range(0, textures.Length);
        GetComponentInChildren<MeshRenderer>().material.mainTexture = textures[idx];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "BULLET")
        {
            Destroy(collision.gameObject);

            if(++hitCount >= 3)
            {
                ExpBarrel();
            }
        }
    }

    void ExpBarrel()
    {
        Instantiate(expEffect, tr.position, Quaternion.identity);

        Collider[] colls = Physics.OverlapSphere(tr.position, 10.0f);

        foreach (Collider collider in colls)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.mass = 1.0f;
                rb.AddExplosionForce(1000.0f, tr.position, 10.0f, 300.0f);
            }
        }

        Destroy(gameObject, 5.0f);
    }
}
