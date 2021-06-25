using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    public PlayerController player;
    public GameObject[] thunderList;

    void Start()
    {
        //thunderList[0].SetActive(false);
    }

    void Update()
    { 
        Touched();
    }

    void Touched()
    {
        if (thunderList[0].GetComponent<BoxCollider2D>().IsTouching(player.hitBox))
        {
            Debug.Log("touched!");
        }
    }

    void ThunderSpawn()
    {

    }
}
