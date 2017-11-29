using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class PostProcessManager : MonoBehaviour
{
    //remember to drag and drop your scriptable object into this field in the inspector...
    public PostProcessingProfile ppProfile;

    public Color aColor = new Vector4(0.5F, 1, 0.5F, 1);
    public Color bColor = new Vector4(0F, 0F, 0F, 1);
    public Color cColor = new Vector4(0F, 0F, 0F, 1);

    //public static bool blueVignette = false;

    void Start()
    {
        SpeedPowerup.speeding = false;
    }

    void Update()
    {
        if (Movement.isBlueActive == true)
        {
            ppProfile.vignette.enabled = true;
            //Debug.Log("It´s blue time");
            ChangeVignetteColorAtRuntime(1);
        }
        else if (SpeedPowerup.speeding == true)
        {
            ppProfile.vignette.enabled = true;
            ChangeVignetteColorAtRuntime(2);
        }
        else
        {
            //Debug.Log("RegularTime");
            ppProfile.vignette.enabled = false;
        }

    }

    /*void ChangeBloomAtRuntime()
    {
        ppProfile.bloom.enabled = true;

        //copy current bloom settings from the profile into a temporary variable
        BloomModel.Settings bloomSettings = ppProfile.bloom.settings;

        

        //change the intensity in the temporary settings variable
        bloomSettings.bloom.intensity = 1;

        //set the bloom settings in the actual profile to the temp settings with the changed value
        ppProfile.bloom.settings = bloomSettings;
    }*/

    void ChangeVignetteColorAtRuntime(int type)
    {


        VignetteModel.Settings vignetteSettings = ppProfile.vignette.settings;
        if (type == 1)
        {
            vignetteSettings.color = aColor;
        }
        else if (type == 2)
        {
            vignetteSettings.color = bColor;
        }
        else if (type == 3)
        {
            vignetteSettings.color = cColor;
        }


        ppProfile.vignette.settings = vignetteSettings;

    }
}
