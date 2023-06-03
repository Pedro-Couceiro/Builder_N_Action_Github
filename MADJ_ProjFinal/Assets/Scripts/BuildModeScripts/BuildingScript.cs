using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    private float _timer;
    [SerializeField] private float _secondsGiveGold = 1f;
    [SerializeField] private int _goldPerSec = 1;


    private void Awake()
    {
        _timer = 0f;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if(_timer >= _secondsGiveGold)
        {
            _timer -= _secondsGiveGold;
            GameManager.Instance.save.AddGold(_goldPerSec);
        }
    }

    public void AddGold()
    {
        GameManager.Instance.save.AddGold(100);
    }
}
