using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private stats p_stats;
    public hudmanager hudm;

    

    private void Awake()
    {
        p_stats = GetComponent<stats>();
        hudm.updatehealthtext(p_stats.health);

    }

    // Update is called once per frame
    void Update()
    {
        if(p_stats.health<=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        float horizontalinput = Input.GetAxis("Horizontal");
      /* if(Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
                horizontalinput.x = speed;
            else
                horizontalinput.x = -speed;
        }*/
       
        transform.position = new Vector3(transform.position.x + horizontalinput * Time.deltaTime * speed,
            1,
            transform.position.z);

    }
    public void recievedamage()
    {
        p_stats.updatehealth(10);

        hudm.updatehealthtext(p_stats.health);
    }


}

