using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float height = 5;
    public float width = 1;
    private int randCoin;
    public GameObject prefabCoinn;

    // Update is called once per frame
    public void Awake()
    {
  
            
            randCoin = Random.Range(0, 2);

        if (randCoin == 1)
        {
            GameObject newPipe = Instantiate(prefabCoinn);
            newPipe.transform.position = transform.position + new Vector3(2, 2, 0);
            Destroy(newPipe, 10f);
        }

    }
   
}
