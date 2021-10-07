using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{       public GameObject sheep;
        public GameObject duck;
    void Update()
    {
        
   
        float dist = Vector3.Distance(sheep.transform.position, duck.transform.position);
        if (dist<1.4)
        {
               sheep.GetComponent<Animation>().Play("jump");
               duck.GetComponent<Animation>().Play("jump");
        }
        else
        {
             sheep.GetComponent<Animation>().Play("idle");
             duck.GetComponent<Animation>().Play("idle");
        }

    }

}
