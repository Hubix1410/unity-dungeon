using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float pHealth = 100f;
    public float pMoveSpeed = 5f;
    public float pMinBowDamage = 20f;
    public float pMaxBowDamage = 40f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(pHealth);
        Debug.Log(pMoveSpeed);
        Debug.Log(pMaxBowDamage);
        Debug.Log(pMinBowDamage);
    }

}
