using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float elapsedTime = 0.0f;

    public float elapsedTime2 = 0.0f;

    public TextMeshProUGUI timerText;

    public TextMeshProUGUI capText;
    public TextMeshProUGUI foodText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI armyText;
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI waterText;

    
    public int GetFood()
    {
        return PublicVars.Instance.playerResources[3];
    }

    public int GetMoney()
    {
        return PublicVars.Instance.playerResources[2];
    }

    public int GetPopulation()
    {
        return PublicVars.Instance.playerResources[0];
    }

    public int GetArmy()
    {
        return PublicVars.Instance.playerResources[4];
    }

    public int GetStone()
    {
        return PublicVars.Instance.playerResources[1];
    }

    public int getWater()
    {
        return PublicVars.Instance.playerResources[5];
    }

    public void setFood(int newFood)
    {
        PublicVars.Instance.buildingCounts[0] = newFood;
    }

    public void setMoney(int newMoney)
    {
        PublicVars.Instance.playerResources[3] = newMoney;
    }

    public void setPopulation(int newPopulation)
    {
        PublicVars.Instance.playerResources[2] = newPopulation;
    }

    public void setArmy(int newArmy)
    {
        PublicVars.Instance.playerResources[4] = newArmy;
    }

    public void setStone(int newStone)
    {
        PublicVars.Instance.playerResources[1] = newStone;
    }

    public void getWater(int newWater)
    {
        PublicVars.Instance.playerResources[5] = newWater;
    }



    // Start is called before the first frame update
    void Start()
    {
        UpdateResourceDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime += Time.deltaTime;
        elapsedTime2 += Time.deltaTime;

        UpdateTimeDisplay();

        if (elapsedTime2 >= 5.0f)
        {
            FiveSecondMark();
            elapsedTime2 -= 5.0f;
        }
        UpdateResourceDisplay();
    }

    void UpdateTimeDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60F);
        int seconds = Mathf.FloorToInt(elapsedTime % 60F);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    //population, stone, bank, food, army, water
    //0             1       2    3     4    5
    void UpdateResourceDisplay()
    {
        capText.text = "Max: " + PublicVars.Instance.resourceCap;
        foodText.text = "Food: " + PublicVars.Instance.playerResources[3] + " (" + ((4 * PublicVars.Instance.buildingCounts[3]) + (-2 * PublicVars.Instance.buildingCounts[5])) + ")";
        moneyText.text = "Money: " + PublicVars.Instance.playerResources[2] + " (" + ((4 * PublicVars.Instance.buildingCounts[2]) + (4 * PublicVars.Instance.buildingCounts[0])) + ")";
        populationText.text = "Population: " + PublicVars.Instance.playerResources[0] + " (" + ((4 * PublicVars.Instance.buildingCounts[0]) + (-2 * PublicVars.Instance.buildingCounts[2]) + (-2 * PublicVars.Instance.buildingCounts[5]) + (-2 * PublicVars.Instance.buildingCounts[3])) + ")";
        armyText.text = "Army: " + PublicVars.Instance.playerResources[4] + " (" + ((4 * PublicVars.Instance.buildingCounts[4]) + (2 * PublicVars.Instance.buildingCounts[2]) + (-4 * PublicVars.Instance.buildingCounts[0])) + ")";
        stoneText.text = "Stone: " + PublicVars.Instance.playerResources[1] + " (" + ((6 * PublicVars.Instance.buildingCounts[1])) + ")";
        waterText.text = "Water: " + PublicVars.Instance.playerResources[5] + " (" + ((4 * PublicVars.Instance.buildingCounts[5]) + (-2 * PublicVars.Instance.buildingCounts[1])) + ")";
    }

    void UpdateResources()
    {
        PublicVars.Instance.playerResources[3] += (4 * PublicVars.Instance.buildingCounts[3]) + (-2 * PublicVars.Instance.buildingCounts[5]);
        PublicVars.Instance.playerResources[2] += (4 * PublicVars.Instance.buildingCounts[2]) + (4 * PublicVars.Instance.buildingCounts[0]);
        PublicVars.Instance.playerResources[0] += (4 * PublicVars.Instance.buildingCounts[0]) + (-2 * PublicVars.Instance.buildingCounts[2]) + (-2 * PublicVars.Instance.buildingCounts[5]) + (-2 * PublicVars.Instance.buildingCounts[3]);
        PublicVars.Instance.playerResources[4] += (4 * PublicVars.Instance.buildingCounts[4]) + (2 * PublicVars.Instance.buildingCounts[2]) + (-4 * PublicVars.Instance.buildingCounts[0]);
        PublicVars.Instance.playerResources[1] += (6 * PublicVars.Instance.buildingCounts[1]);
        PublicVars.Instance.playerResources[5] += (4 * PublicVars.Instance.buildingCounts[5]) + (-2 * PublicVars.Instance.buildingCounts[1]);
    }

    void FiveSecondMark()
    {
        UpdateResources();
        Debug.Log("5 seconds have passed");
    }
}
