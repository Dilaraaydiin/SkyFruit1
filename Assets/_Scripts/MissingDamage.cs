using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            playerHealth.TakeDamage(1);
        }
    }
}
