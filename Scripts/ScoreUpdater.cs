using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreUpdater : MonoBehaviour
{
    // Start is called before the first frame update

    private TextMeshProUGUI tm;
    private int score;
    private GameObject GameManager;
    private GM gm;
    public bool isScore;
    void Start()
    {
        tm = gameObject.GetComponent<TextMeshProUGUI>();
        GameManager = GameObject.Find("GameManager");
        gm = GameManager.GetComponent<GM>();

    }
        // Update is called once per frame
        void Update()
    {
        if (isScore)
        {
            tm.text = gm.score.ToString();
        }

        else
        {
            tm.text = gm.hp.ToString();
        }
        
    }
}
