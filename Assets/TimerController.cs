using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class TimerController : MonoBehaviour
{
    [SerializeField]
    float _maxTime;

    Slider _slider;

    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxTime;
        _slider.minValue = 0;
        _slider.value = 1;
    }

    void Update()
    {
        var timePassed = _maxTime - Time.time;

        if(timePassed <= 0)
        {
            SceneManager.LoadScene(0);
            return;
        }

        _slider.value = timePassed;
    }
}
