using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class PerformanceMgr : MonoBehaviour
{
    private LightShadows shadowType = LightShadows.None;

    private void Awake()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            switch (Device.generation)
            {
                case DeviceGeneration.iPhone5S:
                    shadowType = LightShadows.Hard;
                    break;
                case DeviceGeneration.iPhone6:
                    shadowType = LightShadows.Soft;
                    break;
                case DeviceGeneration.iPhone6Plus:
                    shadowType = LightShadows.Soft;
                    break;
                default:
                    shadowType = LightShadows.None;
                    break;
            }

            GameObject.Find("Directional Light").GetComponent<Light>().shadows = shadowType;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
