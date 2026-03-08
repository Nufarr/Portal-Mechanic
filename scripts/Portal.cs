using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform destination;
    public Transform player;

    void OnTriggerEnter(Collider other) {
        Debug.Log("ok");
        if( other.gameObject.name == "Player")
        {
            Debug.Log("touch me");
            player.GetComponent<PlayerTeleport>().Teleport(destination.position, destination.rotation);
        }
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(destination.position, .4f);
        var direction = destination.TransformDirection(Vector3.forward);
        Gizmos.DrawRay(destination.position, direction);
    }
    
}
