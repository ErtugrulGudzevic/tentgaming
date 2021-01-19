using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GM : MonoBehaviour
{
    // Start is called before the first frame update
    public int score=0,hp=2;
    public GameObject EndGamePanel;
    public GameObject Dimension2;
    public bool powerOn = false;
    public int coinCounter = 0;
    public int counter = 10;
    void Start()
    {
        Time.timeScale = 1;
        hp = 2;
        Dimension2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hp < 1)
        {
            EndGamePanel.SetActive(true);
            Time.timeScale = 0.03f;
        }
        if (score == counter)
        {
            Dimension2.SetActive(true);
        }
        if (score == counter+10)
        {
            Dimension2.SetActive(false);
            counter += 20;
        }
        
        if (coinCounter < score - 5)
        {
            powerOn = false;
        }
    }
    public void ScoreAdder (int point)
    {

        score += point;

    }
    public void HpAdder(int point)
    {

        hp += point;

    }
    public void hitOnEnemy()
    {
        hp--;
    }
    public void getPower()
    {
        powerOn = true;
        coinCounter = score;
    }
    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");

    }
    public void GoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menü");

    }
}
