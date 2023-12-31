using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBuildings : MonoBehaviour
{
    public Button house, quarry, bank, farm, baracks, dam, warehouse;
    // Start is called before the first frame update
    void Start()
    {
        house.onClick.AddListener(buyHouse);
        quarry.onClick.AddListener(buyQuarry);
        bank.onClick.AddListener(buyBank);
        farm.onClick.AddListener(buyFarm);
        baracks.onClick.AddListener(buyBaracks);
        dam.onClick.AddListener(buyDam);
        warehouse.onClick.AddListener(buyStorage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //population, stone, bank, food, army, water
    //     0       1      2     3     4    5
    public void buyHouse(){
        PublicVars.Instance.buildingCounts[0] += 1;
        PublicVars.Instance.playerResources[1] -= 3;
        PublicVars.Instance.playerResources[2] -= 3;
        PublicVars.Instance.playerResources[0] -= 1;
    }
    public void buyQuarry(){
        PublicVars.Instance.buildingCounts[1] += 1;
        PublicVars.Instance.playerResources[1] -= 5;
        PublicVars.Instance.playerResources[2] -= 3;
        PublicVars.Instance.playerResources[0] -= 1;
    }
    public void buyBank(){
        PublicVars.Instance.buildingCounts[2] += 1;
        PublicVars.Instance.playerResources[1] -= 3;
        PublicVars.Instance.playerResources[2] -= 3;
        PublicVars.Instance.playerResources[0] -= 1;
    }
    public void buyFarm(){
        PublicVars.Instance.buildingCounts[3] += 1;
        PublicVars.Instance.playerResources[1] -= 3;
        PublicVars.Instance.playerResources[2] -= 3; 
        PublicVars.Instance.playerResources[0] -= 1;
    }
    public void buyBaracks(){
        PublicVars.Instance.buildingCounts[4] += 1;
        PublicVars.Instance.playerResources[1] -= 3;
        PublicVars.Instance.playerResources[2] -= 3; 
        PublicVars.Instance.playerResources[0] -= 1;       
    }
    public void buyDam(){
        PublicVars.Instance.buildingCounts[5] += 1;
        PublicVars.Instance.playerResources[1] -= 3;
        PublicVars.Instance.playerResources[2] -= 3;  
        PublicVars.Instance.playerResources[0] -= 1;      
    }
    public void buyStorage(){
        PublicVars.Instance.resourceCap += 100;
        PublicVars.Instance.playerResources[0] -= 30;
        PublicVars.Instance.playerResources[1] -= 30;
        PublicVars.Instance.playerResources[2] -= 30;
        PublicVars.Instance.playerResources[3] -= 30;
        PublicVars.Instance.playerResources[4] -= 30;
        PublicVars.Instance.playerResources[5] -= 30;
    }
}
