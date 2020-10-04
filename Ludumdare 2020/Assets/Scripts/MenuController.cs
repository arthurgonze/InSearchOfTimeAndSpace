using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Canvas _mainMenu;

    [SerializeField] private Canvas _instructions;

    [SerializeField] private Canvas _credits;


    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        _mainMenu.enabled = true;
        _instructions.enabled = false;
        _credits.enabled = false;
    }

    public void InstructionsMenu()
    {
        _mainMenu.enabled = false;
        _instructions.enabled = true;
        _credits.enabled = false;
    }

    public void CreditsMenu()
    {
        _mainMenu.enabled = false;
        _instructions.enabled = false;
        _credits.enabled = true;
    }
}
