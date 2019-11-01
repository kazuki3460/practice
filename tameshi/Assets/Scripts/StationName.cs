using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationName : MonoBehaviour
{
    public Text Station;
    public InputField inputfield;
    // Start is called before the first frame update
    void Start()
    {
        Station.text = inputfield.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
