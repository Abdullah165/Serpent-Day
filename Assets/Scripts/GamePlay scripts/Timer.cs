using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float timeForOneRound;
    [SerializeField] Text timer;


    private void Start()
    {
        timeForOneRound = 90;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeForOneRound > 0)
        {
            timeForOneRound -= Time.deltaTime;
        }
        else
        {
            timeForOneRound = 0;
        }

        DisplayTime(timeForOneRound);
    }

    public void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeForOneRound / 60);
        float seconds = Mathf.FloorToInt(timeForOneRound % 60);
        timer.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
