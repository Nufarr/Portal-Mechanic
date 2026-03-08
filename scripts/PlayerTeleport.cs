using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController controller;
    public void Teleport(Vector3 position, Quaternion rotation)
    {
        transform.position = position;
        transform.rotation = rotation;
        Physics.SyncTransforms();
        //velocity = Vector3.zero;
    }
}
