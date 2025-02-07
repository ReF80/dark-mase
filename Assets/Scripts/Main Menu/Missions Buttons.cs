using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionsButtons : MonoBehaviour
{

    [SerializeField] private GameObject panelMissions;
    
    public void PlayLevel1Btn()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void PlayLevel2Btn()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void PlayLevel3Btn()
    {
        SceneManager.LoadScene("Level3");
    }
    
    public void PlayLevel4Btn()
    {
        SceneManager.LoadScene("Level4");
    }

    public void CloseMissions()
    {
        panelMissions.SetActive(false);
    }
}
