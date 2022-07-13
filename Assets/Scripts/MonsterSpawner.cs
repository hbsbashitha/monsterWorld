using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;
    [SerializeField]
    private Transform leftPosition, rightPosition;

    private int randomIndex;
    private int randomSide;
    private GameObject spawnMonster;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {

        yield return new WaitForSeconds(Random.Range(5,10));
        randomIndex = Random.Range(0, monsterReference.Length);

        randomSide = Random.Range(0, 2);

        spawnMonster=Instantiate(monsterReference[randomIndex]);
        //left
        if (randomSide == 0)
        {
            spawnMonster.transform.position = leftPosition.position;
            spawnMonster.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster.GetComponent<SpriteRenderer>().flipX = false;
        }
        //right
        else
        {
            spawnMonster.transform.position = rightPosition.position;
            spawnMonster.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster.GetComponent<SpriteRenderer>().flipX = true;

        }
        
        StartCoroutine(SpawnMonster());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
