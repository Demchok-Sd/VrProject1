using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyer : MonoBehaviour
{
    public Material MaterialConveyer;
    public Transform EndPoint;
    public float SpeedObjectsMovement;

    public float SpeedConveyerMovement = 5f;
    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, EndPoint.position, SpeedObjectsMovement * Time.deltaTime);
    }
}
