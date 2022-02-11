using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target;
    public float smooth = 5.0f;
    public Vector3 offset = new Vector3(0, 9f, 0);



    public void PositionGame() // вид камеры во время игры (Развернута вниз по оси Y)
    {
        transform.position = new Vector3(4.16f, Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * smooth).y, -4.45f);
    }

    public void PositionScreen() // вид камеры на canvas победы и проигрыша
    {
        transform.position = new Vector3(-5.42f, 16.68f, 14.12f);
    }

}
