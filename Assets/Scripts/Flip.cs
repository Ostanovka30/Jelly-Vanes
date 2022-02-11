using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Animator>().SetTrigger("Flip");
    }
}
