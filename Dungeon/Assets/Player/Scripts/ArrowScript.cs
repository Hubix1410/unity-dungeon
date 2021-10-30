using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float arrowDamage;

    void Start()
    {
        // Get stats from script
        GameObject thePlayer = GameObject.Find("PlayerObj");
        PlayerStats playerStats = thePlayer.GetComponent<PlayerStats>();

        // Random damage of arrow
        arrowDamage = Mathf.Floor(Random.Range(playerStats.pMinBowDamage, playerStats.pMaxBowDamage));

        // Destroy arrow after 10 seconds
        Destroy(gameObject, 10f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
