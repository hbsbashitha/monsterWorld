using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;


    [SerializeField]
    private Transform leftPosition, rightPosition,leftPosition2,rightPosition2,leftPosition3,rightPosition3,leftPosition4,rightPosition4,leftPosition5,rightPosition5,leftPosition6,rightPosition6,leftPosition7,rightPosition7,leftPosition8,rightPosition8,leftPosition9,rightPosition9,leftPosition10,rightPosition10;

    private int randomIndex;
    private int randomSide;


    private GameObject spawnMonster,spawnMonster2,spawnMonster3,spawnMonster4,spawnMonster5,spawnMonster6,spawnMonster7,spawnMonster8,spawnMonster9,spawnMonster10;


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
        spawnMonster2=Instantiate(monsterReference[randomIndex]);
        spawnMonster3=Instantiate(monsterReference[randomIndex]);
        spawnMonster4=Instantiate(monsterReference[randomIndex]);
        spawnMonster5=Instantiate(monsterReference[randomIndex]);
        spawnMonster6=Instantiate(monsterReference[randomIndex]);
        spawnMonster7=Instantiate(monsterReference[randomIndex]);
        spawnMonster8=Instantiate(monsterReference[randomIndex]);
        spawnMonster9=Instantiate(monsterReference[randomIndex]);
        spawnMonster10=Instantiate(monsterReference[randomIndex]);
        

        //left
        if (randomSide == 0)
        {
            spawnMonster.transform.position = leftPosition.position;
            spawnMonster2.transform.position = leftPosition2.position;
            spawnMonster3.transform.position = leftPosition3.position;
            spawnMonster4.transform.position = leftPosition4.position;
            spawnMonster5.transform.position = leftPosition5.position;
            spawnMonster6.transform.position = leftPosition6.position;
            spawnMonster7.transform.position = leftPosition7.position;
            spawnMonster8.transform.position = leftPosition8.position;
            spawnMonster9.transform.position = leftPosition9.position;
            spawnMonster10.transform.position = leftPosition10.position;
            



            spawnMonster.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster2.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster2.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster3.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster3.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster4.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster4.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster5.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster5.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster6.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster6.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster7.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster7.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster8.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster8.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster9.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster9.GetComponent<SpriteRenderer>().flipX = false;

            spawnMonster10.GetComponent<Monster>().speed = Random.Range(4,10);
            spawnMonster10.GetComponent<SpriteRenderer>().flipX = false;




    
        }
        //right
        else
        {
            spawnMonster.transform.position = rightPosition.position;
            spawnMonster2.transform.position = rightPosition2.position;
            spawnMonster3.transform.position = rightPosition3.position;
            spawnMonster4.transform.position = rightPosition4.position;
            spawnMonster5.transform.position = rightPosition5.position;
            spawnMonster6.transform.position = rightPosition6.position;
            spawnMonster7.transform.position = rightPosition7.position;
            spawnMonster8.transform.position = rightPosition8.position;
            spawnMonster9.transform.position = rightPosition9.position;
            spawnMonster10.transform.position = rightPosition10.position;
            




            spawnMonster.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster.GetComponent<SpriteRenderer>().flipX = true;


            spawnMonster2.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster2.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster3.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster3.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster4.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster4.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster5.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster5.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster6.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster6.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster7.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster7.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster8.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster8.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster9.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster9.GetComponent<SpriteRenderer>().flipX = true;

            spawnMonster10.GetComponent<Monster>().speed = -Random.Range(4,10);

            spawnMonster10.GetComponent<SpriteRenderer>().flipX = true;

            




        }
        
        StartCoroutine(SpawnMonster());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
