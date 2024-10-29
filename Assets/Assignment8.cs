using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Q1
        int randomNum;
        while(true)
        {
            randomNum = Random.Range(1 , 21);
            Debug.Log(randomNum);

            if (randomNum == 5) continue;
            else if (randomNum == 15) break;  
        }
        Debug.Log("************************************");

        //End of Q1
        /////////////////////////////////////////////
        
        //Q2
        string [] animalArr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish"
                              ,"Tree", "Monkey", "Ball", "Bird"}; 

        int wordCounter = 0;
        int randomIndex;
        string sentence = "";
        while(wordCounter < 7)
        {
            randomIndex = Random.Range(0 , animalArr.Length);
            sentence += animalArr[randomIndex] + " ";
            wordCounter++;
        }
        Debug.Log(sentence);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
