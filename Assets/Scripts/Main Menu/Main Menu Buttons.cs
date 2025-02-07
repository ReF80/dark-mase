using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject panelMissions;

    public void PlayButton()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void MissionsButton()
    {
        panelMissions.SetActive(true);
    }

    public void SettingsButton()
    {
        panelSettings.SetActive(true);
    }

    public void MessagesButton()
    {
        
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
