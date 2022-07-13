using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    private Vector3 tempPosition;

[SerializeField]
    private float maxX,minX;
    // Start is called before the first frame update
    void Start()
    {

        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        tempPosition = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player){
            return;
        }
        tempPosition.x = player.position.x;
        
        if(tempPosition.x > maxX){
            tempPosition.x = maxX;
        }
        if(tempPosition.x < minX){
            tempPosition.x = minX;
        }
        transform.position = tempPosition;
    }

}
