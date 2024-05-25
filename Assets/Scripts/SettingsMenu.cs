using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private string[] EnemyType = { "Armed", "Unarmed" };
    private string[] MusicType = { "Harmony", "EDM" };

    private int EnemyChoice, MusicChoice = 0;

    public TMP_Text EnemyEdit;
    public TMP_Text MusicEdit;
    public void ChangeMusic(int offset)
    {
        MusicChoice = (MusicChoice + offset) % 2;
        RefreshSettings();
    }

    public void ChangeEnemy(int offset)
    {
        EnemyChoice = (EnemyChoice + offset) % 2;
        RefreshSettings();
    }
    void RefreshSettings()
    {
        if (EnemyEdit != null)
        {
            EnemyEdit.text = EnemyType[EnemyChoice];
        }
        if (MusicEdit != null)
        {
            MusicEdit.text = MusicType[MusicChoice];
        }
    }
    void Start()
    {
        RefreshSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
