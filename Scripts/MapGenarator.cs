using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenarator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    public GameObject coin;
    public GameObject mace;
    public GameObject heart;
    public GameObject power;
    public GameObject saw;
    private int forbiddenDistFloor, forbiddenDistDist;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlatformAdder(float pos)
    {
        int randomFloor, randomDistance;
        int Counter = 3;
        Instantiate(platform, new Vector3(pos,-0.81f,0), Quaternion.identity);
       
        
        //RandomCoinMaker

        for (int i=0; i<Counter; i++)
        {
            randomFloor = Random.Range(0, 3);
            randomDistance = Random.Range(1, 8);
            if (forbiddenDistFloor != randomFloor || forbiddenDistDist != randomDistance)
            {
                

                Instantiate(coin, new Vector3(pos - 15f + (3.83f * randomDistance), -4.4f + (randomFloor * 5), 0), Quaternion.identity);

                forbiddenDistDist = randomDistance;
                forbiddenDistFloor = randomFloor;
            }
            else
            {
                i--;
            }
        }


        //Random Enemy Maker

        for (int i = 1; i < Counter; i++)
        {
            randomFloor = Random.Range(0, 3);
            randomDistance = Random.Range(1, 8);
            if (forbiddenDistFloor != randomFloor || forbiddenDistDist != randomDistance)
            {


                Instantiate(mace, new Vector3(pos - 15f + (3.83f * randomDistance), -4.4f + (randomFloor * 5), 0), Quaternion.identity);

                forbiddenDistDist = randomDistance;
                forbiddenDistFloor = randomFloor;
            }
            else
            {
                i--;
            }
        }

        //random Power Maker

        for (int i = 2; i < Counter; i++)
        {
            randomFloor = Random.Range(0, 3);
            randomDistance = Random.Range(1, 8);
            int randomPossibilty = Random.Range(0,8);
            if ((forbiddenDistFloor != randomFloor || forbiddenDistDist != randomDistance) && randomPossibilty == 2)
            {


                Instantiate(power, new Vector3(pos - 15f + (3.83f * randomDistance), -4.4f + (randomFloor * 5), 0), Quaternion.identity);

                forbiddenDistDist = randomDistance;
                forbiddenDistFloor = randomFloor;
            }
            else
            {
                
            }
        }

        //random Saw Maker

        for (int i = 2; i < Counter; i++)
        {
            randomFloor = Random.Range(0, 3);
            randomDistance = Random.Range(1, 8);
            int randomPossibilty = Random.Range(0, 4);
            if ((forbiddenDistFloor != randomFloor || forbiddenDistDist != randomDistance) && randomPossibilty == 2)
            {


                Instantiate(saw, new Vector3(pos - 15f + (3.83f * randomDistance), -4.4f + (randomFloor * 5), 0), Quaternion.identity);

                forbiddenDistDist = randomDistance;
                forbiddenDistFloor = randomFloor;
            }
            else
            {

            }
        }


        // Random Heart Maker

        for (int i = 2; i < Counter; i++)
        {
            int randomHeartPossibility = Random.Range(1, 10);
            randomFloor = Random.Range(0, 3);
            randomDistance = Random.Range(1, 8);
            if (randomHeartPossibility == 2)
            {
                if (forbiddenDistFloor != randomFloor || forbiddenDistDist != randomDistance)
                {


                    Instantiate(heart, new Vector3(pos - 15f + (3.83f * randomDistance), -4.4f + (randomFloor * 5), 0), Quaternion.identity);

                    forbiddenDistDist = randomDistance;
                    forbiddenDistFloor = randomFloor;
                }
                else
                {
                    i--;
                }
            }
          
        }


    }
}
