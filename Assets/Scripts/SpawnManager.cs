using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject Enemy1;
    [SerializeField] private GameObject Enemy2;
    [SerializeField] private GameObject Enemy3;

    private int maxXPosition = 30;
    private int maxYPosition = 3;
    private int maxZPosition = 50;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemies();
    }

    // Instantiate 
    private IEnumerator SpawnEnemies(){

        while(true){

            // Generate random enemy number
            int Enemy = Random.Range(1,4);

            // Spawn enemy based on chosen random number
            if (Enemy == 1){
                Instantiate(Enemy1, new Vector3(Random.Range(-maxXPosition, maxXPosition + 1), maxYPosition, maxZPosition), Quaternion.identity);

            } else if(Enemy == 2){
                Instantiate(Enemy2, new Vector3(Random.Range(-maxXPosition, maxXPosition + 1), maxYPosition, maxZPosition), Quaternion.identity);

            } else if(Enemy == 3){
                Instantiate(Enemy3, new Vector3(Random.Range(-maxXPosition, maxXPosition + 1), maxYPosition, maxZPosition), Quaternion.identity);

            }

            yield return new WaitForSeconds(.75f);
        }

    }
}
