using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum enemytype
{
    catcher, 
    evader
}

public class enemycontroller : MonoBehaviour
{
    private float thresholdpositionZ = -12.0f;
    public float speed;
    private playercontroller pc;
    public enemytype et;
    void Start()
    {
        pc = GameObject.Find("player").GetComponent<playercontroller>();
    }

   
    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            transform.position.y,
            transform.position.z - 1.0f * Time.deltaTime * speed);


        if (Vector3.Distance(pc.transform.position, transform.position) < 1.0f)
        {
            if (et == enemytype.evader)
            {
                pc.recievedamage();
            }
            Destroy(gameObject);
        }
        else if (pc.transform.position.z - transform.position.z > 1.0f && et == enemytype.catcher)
        {
            pc.recievedamage();
            Destroy(gameObject);
        }
        else
        if(transform.position.z<=thresholdpositionZ)
        {
            Destroy(gameObject);
        }
    }
}