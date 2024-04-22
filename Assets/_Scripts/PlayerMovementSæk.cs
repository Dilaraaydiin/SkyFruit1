using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSæk : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision: " + collision.gameObject.name);
    }

    public float speed = 1.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Æble"))
        {
            collision.gameObject.GetComponent<Fruit>();

            // Håndter logikken for at samle skatten op
            Debug.Log("Apple collected!");
            // Tilføj her logikken for at øge spillerens score eller anden relevant handling

            // Fjern skatten fra scenen
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.GetComponent<Enemy>();

            Debug.Log("Game over");

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



        Vector3 move = transform.position;

      

        if (Input.GetKey(KeyCode.A))

        {

            move.x -= speed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.D))

        {

            move.x += speed * Time.deltaTime;

        }

     

        transform.position = move;



    }
}
