using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserControl : MonoBehaviour
{
    public static UserControl Instance;
    public string PlayerName;
    public string CurrentPlayerName;
    // Start is called before the first frame update
    private void Awake()    
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadPlayerData();
    }

     [System.Serializable]
    class SaveData
    {
        public string Name;
    }

    public void SavePlayerData()
    {
        SaveData saveData = new SaveData();
        saveData.Name = UserControl.Instance.PlayerName;
        string json = JsonUtility.ToJson(saveData);
        //File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        File.WriteAllText("D:/savefile.json", json);
    }

    public void LoadPlayerData()
    {
        //string path = Application.persistentDataPath + "/savefile.json";
        string path = "D:/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData loadData = JsonUtility.FromJson<SaveData>(json);
            UserControl.Instance.PlayerName = loadData.Name;
        }
        
    }
}
