using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public Transform firePosition;
    public GameObject bullet;



    public Transform firePos2;

    bool isPowered;



    private void Start()
    {
        isPowered = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        {
            Instantiate(bullet, firePosition.position, firePosition.rotation);
        }
       


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Power")
        {
            isPowered = true;
            if(Input.GetMouseButtonDown(0) && isPowered)
            {
                Shoot();
            }
            
        }
    }

    void Shoot()
    {
        
            Instantiate(bullet, firePos2.position, firePosition.rotation);
        
    }
}
