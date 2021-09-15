using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hudmanager : MonoBehaviour
{
    public Text health;
    
    public void updatehealthtext(float health)
    {
        this.health.text ="Health: "+ health;
    }
  
}
