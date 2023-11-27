using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullScreenLogic : MonoBehaviour
{
    public Toggle toggle;

    public TMP_Dropdown dropdownResolutions;
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        if (Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }

        ResolutionCheck();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FullScreenActivate(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
    }

    public void ResolutionCheck()
    {
        resolutions= Screen.resolutions;
        dropdownResolutions.ClearOptions(); 
        List<string>options = new List<string>();
        int currentResolution=0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option= resolutions[i].width+ " x " +resolutions[i].height;
            options.Add(option);

            if (Screen.fullScreen && resolutions[i].width== Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolution = i;
            }
        }

        dropdownResolutions.AddOptions(options);
        dropdownResolutions.value = currentResolution;
        dropdownResolutions.RefreshShownValue();

        dropdownResolutions.value = PlayerPrefs.GetInt("resolutionValue", 0);

    }

    public void ResolutionChange(int resolutionIndex)
    {
        PlayerPrefs.SetInt("resolutionValue", dropdownResolutions.value);

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
