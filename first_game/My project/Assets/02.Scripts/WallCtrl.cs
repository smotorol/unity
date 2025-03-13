using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCtrl : MonoBehaviour
{
    public GameObject sparkEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "BULLET")
        {
            GameObject spark = (GameObject)Instantiate(sparkEffect, collision.transform.position, Quaternion.identity);

            Destroy(spark, spark.GetComponent<ParticleSystem>().main.duration + 0.2f);

            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
