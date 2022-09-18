using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    public GameObject gateClosed01,gateOpened01,gateClosed02,gateOpened02,gateClosed03,gateOpened03;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Coin.scoreValue < 40){
            gateClosed01.SetActive(true);
            gateOpened01.SetActive(false);
            gateClosed02.SetActive(true);
            gateOpened02.SetActive(false);
            gateClosed03.SetActive(true);
            gateOpened03.SetActive(false);
            
        }

        if(Coin.scoreValue >= 40){
            gateClosed01.SetActive(false);
            gateOpened01.SetActive(true);
            gateClosed02.SetActive(true);
            gateOpened02.SetActive(false);
            gateClosed03.SetActive(true);
            gateOpened03.SetActive(false);
        }
        if(Coin.scoreValue >= 80){
            gateClosed01.SetActive(false);
            gateOpened01.SetActive(true);
            gateClosed02.SetActive(false);
            gateOpened02.SetActive(true);
            gateClosed03.SetActive(true);
            gateOpened03.SetActive(false);
        }
        if(Coin.scoreValue >= 130){
            gateClosed01.SetActive(false);
            gateOpened01.SetActive(true);
            gateClosed02.SetActive(false);
            gateOpened02.SetActive(true);
            gateClosed03.SetActive(false);
            gateOpened03.SetActive(true);
        }
    }
    

    
}
