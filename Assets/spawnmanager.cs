using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject enemyprefab;
    public GameObject bonusprefab;
    public Vector2 spawnrangeX;

    void Start()
    {

        InvokeRepeating(nameof(spawnevader), 0, 2.0f);
        InvokeRepeating(nameof(spawncatcher), 1, 2.0f);

    }

    private void spawncatcher()
    {
        spawnenemy(enemytype.catcher);
    }
    private void spawnevader()
    {
        spawnenemy(enemytype.evader);
    }

    private void spawnenemy(enemytype et)
    {
        Vector3 spawnposition = new Vector3(
            Random.Range(spawnrangeX[0], spawnrangeX[1]),
            enemyprefab.transform.position.y,
            enemyprefab.transform.position.z);

        if (et == enemytype.evader)
        {
            Instantiate(enemyprefab,
               spawnposition,
               enemyprefab.transform.rotation);
        }
        else
        {
            Instantiate(bonusprefab,
           spawnposition,
           bonusprefab.transform.rotation);
        }
    }
}
