using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class TimerController : MonoBehaviour
{
    [SerializeField]
    float _maxTime;

    Slider _slider;

    bool _isRunning = true;

    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxTime;
        _slider.minValue = 0;
        _slider.value = 1;
    }

    void Update()
    {
        if (!_isRunning) return;

        var timePassed = _maxTime - Time.timeSinceLevelLoad;

        if(timePassed <= 0)
        {
            SceneManager.LoadScene(2);
            return;
        }

        _slider.value = timePassed;
    }

    public void Stop() => _isRunning = false;
}
