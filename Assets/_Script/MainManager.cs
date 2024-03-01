using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TextMeshProUGUI name;
    public static MainManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        name.text = UserControl.Instance.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}
