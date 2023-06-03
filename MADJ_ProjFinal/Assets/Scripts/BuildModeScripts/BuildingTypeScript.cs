using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBuildingType", menuName = "BuildingType")]
public class BuildingTypeScript : ScriptableObject
{
    public string BuildingName;
    public int[] Cost;

    public void Test()
    {
        Debug.Log("oki");
    }
}
