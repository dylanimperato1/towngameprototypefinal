using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCode : MonoBehaviour
{
    public float elapsedTime = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        for (int i = 0; i < PublicVars.Instance.playerResources.Length; i++)
        {
            
            if ((PublicVars.Instance.playerResources[i] >= PublicVars.Instance.resourceCap) || (PublicVars.Instance.playerResources[i] <= 0)) {
                //PublicVars.Instance.fail = i;
                //print(PublicVars.Instance.fail);
                //print(i);
                SceneManager.LoadScene("GameOver");
            } 

            if(PublicVars.Instance.playerResources[4] >= 300){
                int minutes = Mathf.FloorToInt(elapsedTime / 60F);
                int seconds = Mathf.FloorToInt(elapsedTime % 60F);
                PublicVars.Instance.time1 = minutes;
                PublicVars.Instance.time2 = seconds;
                print(seconds);
                SceneManager.LoadScene("Win");
            }

        }
    }
}
