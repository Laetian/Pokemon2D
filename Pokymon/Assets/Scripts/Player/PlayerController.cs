using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isMoving;
    [SerializeField]
    private float speed;
    private Vector2 input;

    private void Update()
    {
        if(!isMoving)
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            //input.x = Input.GetAxisRaw("Horizontal");
            //input.y = Input.GetAxisRaw("Vertical");
            if(input != Vector2.zero)
            {
                var targetPosition = transform.position;
                targetPosition.x += input.x;
                targetPosition.y += input.y;
            }
        }
    }
}
