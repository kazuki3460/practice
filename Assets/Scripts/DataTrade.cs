using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTrade : MonoBehaviour
{
    public static string StartStation; //長田共有用
    public static string GoalStation; //長田共有用
    public Text StartStationName;
    public Text GoalStationName;

    public static int StartTime; //今井共有用
    public static int GoalTime; //今井共有用

    public static float Fare; //大森共有用

    public string ThisStart; //竹内が触れる
    public string ThisGoal; //竹内が触れる

    // Start is called before the first frame update
    void Start()
    {
        if (ThisStart != "")
        {
            StartStation = ThisStart;
        }
        if (StartStationName)
        {
            StartStationName.text = StartStation;
        }
        if (ThisGoal != "")
        {
            GoalStation = ThisGoal;

        }
        if (GoalStationName)
        {
            GoalStationName.text = GoalStation;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
