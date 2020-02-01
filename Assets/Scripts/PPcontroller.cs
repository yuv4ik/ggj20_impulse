using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPcontroller : MonoBehaviour
{
    Vignette _vignetteLayer;
    
    float _step;

    PostProcessVolume _postProcessVolume;

    void Awake()
    {
        _postProcessVolume = GetComponent<PostProcessVolume>();
        _postProcessVolume.profile.TryGetSettings(out _vignetteLayer);
        _vignetteLayer.intensity.overrideState = true;
    }

    void Update()
    {
        _step += 0.01f;
        _vignetteLayer.intensity.value = Mathf.PingPong(Mathf.Sin(_step * 0.5f), .5f);
        Debug.Log(_vignetteLayer.intensity);
    }
}
