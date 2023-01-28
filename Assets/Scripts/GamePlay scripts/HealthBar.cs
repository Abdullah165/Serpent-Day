using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    [SerializeField] Slider slider;

    public static float jumpValue;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            slider.value += 0.3f;
            jumpValue = slider.value;
        }
        else
        {
            slider.value = 0f;
        }
    }
}
