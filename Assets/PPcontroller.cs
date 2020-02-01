using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class PPcontroller : MonoBehaviour
{
    Vignette vignetteLayer = null;
    public FloatParameter intensity;
    public float i;

    void Start()
    {
        PostProcessVolume volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out vignetteLayer);

        
    }

    // Update is called once per frame
    void Update()
    {
              intensity = new FloatParameter { value = Mathf.Clamp01(Mathf.Sin(i) * 0.5f)};
              i = i + 0.01f;
              vignetteLayer.intensity = intensity;
              Debug.Log(vignetteLayer.intensity);

    }
}
