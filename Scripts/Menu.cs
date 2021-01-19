using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Menu : MonoBehaviour
{
    public GameObject easy, normal, hard;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void setDifficult(float x)
    {
        PlayerPrefs.SetFloat("diff", x); 
    }
    public void buttonhandler(GameObject selected)
    {
        
        easy.GetComponent<TextMeshProUGUI>().color = new Color32(183, 75, 72, 255);
        normal.GetComponent<TextMeshProUGUI>().color = new Color32(183, 75, 72, 255);
        hard.GetComponent<TextMeshProUGUI>().color = new Color32(183, 75, 72, 255);
        selected.GetComponent<TextMeshProUGUI>().color = new Color32(82, 255 , 76, 255);

    }
}
