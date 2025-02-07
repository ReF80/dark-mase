using UnityEngine;

public class SettingsButtons : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;

    public void CloseSettings()
    {
        panelSettings.SetActive(false);
    }
}
