using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    public float dummyHealth = 100;
    public GameObject destroiedDummy;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

        
        GameObject arrowObject = GameObject.Find(collision.gameObject.name);
        ArrowScript arrow = arrowObject.GetComponent<ArrowScript>();

        dummyHealth -= arrow.arrowDamage;
        
        if(dummyHealth <= 0)
        {
            DestroyDummy();
        }

        Debug.Log(arrow.arrowDamage);
    }

    void DestroyDummy()
    {
        Instantiate(destroiedDummy, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1), Quaternion.identity);
        Destroy(gameObject);
    }

}
