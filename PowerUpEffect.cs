using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpEffect : MonoBehaviour
{

    public Transform firePosition;
    public GameObject bullet;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Power")
        {
            Shoot();
           
        }
    }

    void Shoot()
    {
       
        if (Input.GetMouseButtonDown(0) )
        {
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }
    }
}
