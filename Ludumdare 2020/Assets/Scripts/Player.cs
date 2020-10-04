using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private bool[] _artifacts = new bool[5];
    [SerializeField] private Vector2 _initialPosition;
    [SerializeField] private List<string> _aquiredKeys;
    

    private int _arctifactsAquired = 0;

    public void AddArtifact()
    {
        _artifacts[_arctifactsAquired] = true;
        _arctifactsAquired++;
        CheckEndGame();
    }

    public void AddKey(string keyID)
    {
        _aquiredKeys.Add(keyID);
    }


    public bool HaveKey(string keyID)
    {
        return _aquiredKeys.Contains(keyID);
    }

    private void CheckEndGame()
    {
        if (_arctifactsAquired >= _artifacts.Length)
        {
            FindObjectOfType<LevelManager>().EndGame();
        }
    }

    public void BackToTheFuture()
    {
        this.transform.position = _initialPosition;
    }
}
