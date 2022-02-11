using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sector : MonoBehaviour
{
    public bool IsGood = true;


    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player player)) return;

        if (IsGood)
        {
          player.Bounce();
        }

        else player.Die();

    }


}
