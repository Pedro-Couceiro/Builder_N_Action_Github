using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveData save;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance!= this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        save = new SaveData(playerName: "JustALilGuy");
    }
}
