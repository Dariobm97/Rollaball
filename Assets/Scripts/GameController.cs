using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour
{

    //Pick up element to spawn
    public GameObject pickUp;

    //Pick up to spawn on start/spawned
    private int maxPickUp;

    // Start is called before the first frame update
    void Start()
    {
        //Evita que se generen en el mismo sitio
        Collider[] checkIfOverlaps = Physics.OverlapBox(transform.position, pickUp.transform.localScale / 2, Quaternion.identity);
        
        //Random generated pickups
        maxPickUp = Random.Range(1,20);
        //Generates pickups in game
        GameObject tempPickUp;
        for (int i = 0; i < maxPickUp; i++)
        {
            //Generate random location
            Vector3 randPosition = RandTransform();
            tempPickUp = Instantiate(pickUp, randPosition, Quaternion.identity);
        }
    }
    private Vector3 RandTransform()
    {
        return new Vector3(Random.Range(-9, 9), 0.5f, Random.Range(-9, 9));
    }
}
