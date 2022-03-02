using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SpawnManager list;
    Vector3 position;
    int horizontalPosition = 0;
    int verticalPosition = 0;
    

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(verticalPosition < list.verticalPosition - 2)
            {
                verticalPosition += 2;
                position = new Vector3(horizontalPosition, 1, verticalPosition);
                transform.position = position;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(verticalPosition > 0)
            {
                verticalPosition -= 2;
                position = new Vector3(horizontalPosition, 1, verticalPosition);
                transform.position = position;
            }
           
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(horizontalPosition > 0)
            {
                horizontalPosition -= 2;
                position = new Vector3(horizontalPosition, 1, verticalPosition);
                transform.position = position;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(horizontalPosition < list.horizontalPosition - 2)
            {
                horizontalPosition += 2;
                position = new Vector3(horizontalPosition, 1, verticalPosition);
                transform.position = position;
            }
            
        }
    }
}
