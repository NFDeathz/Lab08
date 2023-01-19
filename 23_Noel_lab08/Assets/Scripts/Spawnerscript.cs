using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject redCube, brownCube, greenCube;
    float PositionY;
    private int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        //Instantiate(redCube, transform.position, transform.rotation);
        //StartCoroutine(waitForSeconds());
        randomNumber = Random.Range(1, 4);

        if (randomNumber == 1)
        {    
            Instantiate(redCube, transform.position, transform.rotation);
        }
        else if (randomNumber == 2)
        {
            Instantiate(brownCube, transform.position, transform.rotation);
        }
        else if (randomNumber == 3)
        {
            Instantiate(greenCube, transform.position, transform.rotation);
        }
    }
}
