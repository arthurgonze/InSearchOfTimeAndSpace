using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text _timeText;
    private LevelManager _levelManager;
    void Awake()
    {
        _timeText = GetComponent<Text>();
        _levelManager = FindObjectOfType<LevelManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime();
    }

    public void DisplayTime()
    {
        _timeText.text = _levelManager.GetTime().ToString();
        print(_levelManager.GetTime().ToString());
    }
}
