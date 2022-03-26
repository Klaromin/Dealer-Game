using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{


    void OnCollisionEnter2D()
    {

        Debug.Log("Bump!");

    }
    bool hasDrugs = false;

    [SerializeField] float destroyTime = 0.5f;

    [Tooltip("The color when the car get the drug")]
    [SerializeField] Color32 colorPackageOn = new Color32(1, 1, 1, 1);

    [Tooltip("The color when the car have no drug")]
    [SerializeField] Color32 colorPackageOff = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Collectibles" && !hasDrugs)
        {


            Debug.Log("Drug is in your car's trunk");
            hasDrugs = true;
            spriteRenderer.color = colorPackageOn;
            Destroy(collision.gameObject, destroyTime);
        }

        else if (collision.tag == "Collectibles")
        {
            Debug.Log("Your truck is full greedy!");
        }

        if (collision.tag == "Junkies" && hasDrugs)
        {
            Debug.Log("You made the deal.");
            hasDrugs = false;
            spriteRenderer.color = colorPackageOff;
        }

        else if (collision.tag == "Junkies")
        {
            Debug.Log("Where is my drug!");
        }


    }

}
