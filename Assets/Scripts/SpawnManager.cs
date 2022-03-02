using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject cube;
    public List<List<GameObject>> list = new List<List<GameObject>>();
    [SerializeField] int row;
    [SerializeField] int col;
    public int horizontalPosition = 0;
    public int verticalPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
        display();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        for(int i=0; i<row; i++)
        {
            horizontalPosition = 0;
            list.Add(new List<GameObject>());
            for(int j=0; j<col; j++)
            {
                Vector3 position = new Vector3(horizontalPosition, 0, verticalPosition);
                list[i].Add(Instantiate(cube, position, cube.transform.rotation));
                horizontalPosition += 2;
            }
            verticalPosition += 2;
        }
    }
    void display()
    {
        for(int i=0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                Debug.Log(list[i][j]);
            }
        }
    }
}
