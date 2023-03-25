using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public float width = 1;
    public GameObject prefabPipe;
    public GameObject prefabPipeRed;
    public GameObject prefabCoinn;

    // Update is called once per frame

    private int randPipe;
    private int randCoin;
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
            // coinSpawner();
            randPipe = Random.Range(0, 2);
            randCoin = Random.Range(0, 2);
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        if (randPipe == 0)
        {
            GameObject newPipe = Instantiate(prefabPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }

        if (randPipe == 1)
        {
            GameObject newPipe = Instantiate(prefabPipeRed);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }
    }

    /* private void coinSpawner()
     {
         if (randCoin == 1)
         {
             GameObject newPipe = Instantiate(prefabCoinn);
             newPipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), Random.Range(-height, height), 0);
             Destroy(newPipe, 10f);
         }

     

}
*/
}
