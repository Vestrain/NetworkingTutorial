using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Movement : NetworkBehaviour
{
    void HandleMovement()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
        Vector3 movement = new Vector3(x, z, 0);
        transform.position = transform.position + movement;
    }

    private void Update()
    {
        HandleMovement();
    }
}
