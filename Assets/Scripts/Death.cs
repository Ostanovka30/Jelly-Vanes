using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Animator>().SetTrigger("Death");
     
    }

   
}
