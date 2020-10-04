using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Artifact[] _artifacts;
    [SerializeField] private int _spawnedArtifact = 0;
    [SerializeField] private float _timeTillReset = 180f;
    private float _timeCount = 0;
    
    //cached reference
    private Player _player;

    void Awake()
    {
        _player = FindObjectOfType<Player>();
    }
    void Start()
    {
        foreach (Artifact artifact in _artifacts)
        {
            artifact.gameObject.SetActive(false);
        }
        _artifacts[_spawnedArtifact].gameObject.SetActive(true);
    }

    void Update()
    {
        if (_timeCount > _timeTillReset)
        {
            _player.BackToTheFuture();
        }

        _timeCount += Time.deltaTime;
    }
    public void SpawnNextArctifact()
    {
        _spawnedArtifact++;
        if(_spawnedArtifact < _artifacts.Length)
            _artifacts[_spawnedArtifact].gameObject.SetActive(true);
    }

    public void EndGame()
    {
        print("Acabou Porra");
    }

    public float GetTime()
    {
        return _timeCount;
    }
}
