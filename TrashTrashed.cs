using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashTrashed : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject previousText;
    public static int trashScore;
    public AudioSource trashSound;
   
    private void OnTriggerEnter(Collider other)
    {
        if (TrashCollection.theScore > 0)
        {
            trashSound.Play();
            trashScore += TrashCollection.theScore;
            TrashCollection.theScore = 0;
            scoreText.GetComponent<Text>().text = "Trash Trashed: " + trashScore;
            previousText.GetComponent<Text>().text = "Trash Collected: " + 0;
        }
    }
    private void Update()
    {
        scoreText.GetComponent<Text>().text = "Trash Trashed: " + trashScore;
    }
}
