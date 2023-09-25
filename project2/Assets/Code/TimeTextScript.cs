using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeTextScript : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Win")
        {
            timeText.text = string.Format("Time: " + "{0:0}:{1:00}", PublicVars.Instance.time1, PublicVars.Instance.time2);
        }

        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            //if (PublicVars.Instance.fail != -1)
            //{
            //    string[] resources = { "population", "stone", "money", "food", "army", "water" };

            //    timeText.text = string.Format("Failed with", resources[PublicVars.Instance.fail]);
            //}
            //else
            //{
            //    timeText.text = string.Format("Failed with");
            //}
        }
    }
}
