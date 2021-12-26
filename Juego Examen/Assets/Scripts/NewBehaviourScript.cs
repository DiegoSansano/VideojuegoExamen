using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject transition;

    public Text levelCleared;
    
    public Text totalFruits;

    public Text fruitsCollected;

    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;

    }

    private void Update()
    {
        AllFruitsCollected();

        totalFruits.text = totalFruitsInLevel.ToString();

        fruitsCollected.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true);
        }
        
    }

}
