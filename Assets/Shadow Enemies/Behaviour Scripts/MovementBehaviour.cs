using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, 1.0f);
        }
    }
}
