using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    public float repeatRateCoin = 0;
    private float timer = 0;
    public float height = 5;
    public float width = 1;
    public GameObject prefabPipe;
    public GameObject prefabPipeRed;
    
  

    // Update is called once per frame

    private int randPipe;
    private int randCoin;
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();         
            randPipe = Random.Range(0, 2);           
        }

        timer += Time.deltaTime;


      
    }

    private void SpawnPipe()
    {
        if (randPipe == 0)
        {
           
            randCoin = Random.Range(0, 2);

            GameObject newPipe = Instantiate(prefabPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            GameObject sspecificObject = newPipe.transform.Find("Coinn").gameObject;

            sspecificObject.gameObject.SetActive(false);
            Destroy(newPipe, 10f);
            if (randCoin == 0)
            {
                
                
                sspecificObject.gameObject.SetActive(true);
              // sspecificObject.transform.position = transform.position + new Vector3(0, Random.Range(-4, 4), 0);

            }
        }

        if (randPipe == 1)
        {
            randCoin = Random.Range(0, 2);
            GameObject newPipe = Instantiate(prefabPipeRed);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            GameObject sspecificObject = newPipe.transform.Find("Coinn").gameObject;
            Destroy(newPipe, 10f);
            if (randCoin == 0)
            {


                sspecificObject.gameObject.SetActive(true);
               // sspecificObject.transform.position = transform.position + new Vector3(0, Random.Range(-4, 4), 0);

            }
        }

    }



}

