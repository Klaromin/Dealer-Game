using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float adSpeed = 180f;
    [SerializeField] float wsSpeed = 5.5f;
    [SerializeField] float speedBoost = 180f;
    [SerializeField] float speedBump = 1.0f;
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
       
        float steerSpeed = Input.GetAxis("Horizontal")* adSpeed * Time.deltaTime;
        float verticalSpeed = Input.GetAxis("Vertical")* wsSpeed * Time.deltaTime;
        
        transform.Translate(0, verticalSpeed, 0);
        transform.Rotate(0, 0, -steerSpeed);
       
        
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Boost")
        {

            wsSpeed = speedBoost;
            Destroy(collision.gameObject);

        }



    }





}
