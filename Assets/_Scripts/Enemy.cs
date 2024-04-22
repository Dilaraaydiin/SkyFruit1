using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] GameObject[] enemyPrefab;
    [SerializeField] float secondSpawn = 0.3f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)],
                position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }

}
