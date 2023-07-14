using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; 
    public GameObject[] obstaclesCoin;
    public GameObject[] obstaclesqjtjt;


    private bool stepped = false;
    private void OnEnable()
    {
        stepped = false;

        for (int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
        for (int i = 0; i < obstaclesCoin.Length; i++)
        {
            if (Random.Range(0, 5) == 0)
            {
                obstaclesCoin[i].SetActive(true);
            }
            else
            {
                obstaclesCoin[i].SetActive(false);
            }
        }
        for (int i = 0; i < obstaclesqjtjt.Length; i++)
        {
            if (Random.Range(0, 1) == 0)
            {
                obstaclesqjtjt[i].SetActive(true);
            }
            else
            {
                obstaclesqjtjt[i].SetActive(false);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.collider.tag.Equals("Coin") && stepped == false)
    //    {
    //        GameManager.instance.AddScore(1);
    //    }
    //}
}
