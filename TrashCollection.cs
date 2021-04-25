using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashCollection : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject totalText;
    public static int theScore = 0;
    public AudioSource collectSound;
    public static int totalBottles = 150;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 1;
        totalBottles -= 1;
        scoreText.GetComponent<Text>().text = "Trash Collected: " + theScore;
        totalText.GetComponent<Text>().text = "Trash Remaining: " + totalBottles;
        Destroy(gameObject);
    }

}
