using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    public Text TScore;
    public Text GScore;
    public Text HighScore;
    public int HighScore1;

    public static ScoreManager sm;

    private void Awake()
    {
        sm = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadPlayer();
    }
    public void AddScore()
    {
        Score++;
        TScore.text = Score.ToString();
        GScore.text = Score.ToString();

        if (Score>HighScore1)
        {
            HighScore1 = Score;
            HighScore.text = HighScore1.ToString();
            HighScoreforSave a = new HighScoreforSave(HighScore1);
            SaveLoadManager.saveData(a);
        }
    }
    public void LoadPlayer()
    {
        HighScoreforSave data = SaveLoadManager.LoadData();
        HighScore1 = data.j;
        HighScore.text = HighScore1.ToString();
    }
    
}
