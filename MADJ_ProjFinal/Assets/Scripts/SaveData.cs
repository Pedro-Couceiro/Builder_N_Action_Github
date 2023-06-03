using System;

[System.Serializable]
public class SaveData 
{
    public int Gold;
    public int Gems;
    public int Tech;

    public Action<int> goldChangedEvent;

    public string PlayerName { get; private set; }

    public SaveData(string playerName)
    {
        Gold = 1000;
        Gems = 1000;
        Tech = 1000;
        this.PlayerName = playerName;
    }

    public void AddGold(int value)
    {
        Gold += value;
        goldChangedEvent?.Invoke(value);
    }

    public void LoadData()
    {
        //Ler da Base de Dados
    }

    public void SaveGame()
    {
        //Gravar na Base de Dados
    }
}
