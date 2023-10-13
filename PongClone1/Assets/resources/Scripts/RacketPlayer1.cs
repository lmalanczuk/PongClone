using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeedValue;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v)*movementSpeedValue;
    }

}
