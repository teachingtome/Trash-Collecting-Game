using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerShop : MonoBehaviour
{
    public GameObject shopText;
    public GameObject shopText1;
    public AudioSource shopSound;
    public int speedCost = 10;
    public int jumpCost = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && TrashTrashed.trashScore >= speedCost) {
            PlayerMovement.moveSpeed += 1000;
            TrashTrashed.trashScore -= speedCost;
        }
        if (Input.GetKeyDown(KeyCode.O) && TrashTrashed.trashScore >= jumpCost) {
            PlayerMovement.jumpForce += 100;
            TrashTrashed.trashScore -= jumpCost;
        }
    }
}
