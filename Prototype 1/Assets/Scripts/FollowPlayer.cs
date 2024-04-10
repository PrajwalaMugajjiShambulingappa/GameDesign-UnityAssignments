using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {
            // Set this object's position to match the player's position
            transform.position = player.transform.position + offset;
        }
        else
        {
            Debug.LogWarning("Player reference is null. Make sure to assign the player GameObject in the inspector.");
        }
    }
}
