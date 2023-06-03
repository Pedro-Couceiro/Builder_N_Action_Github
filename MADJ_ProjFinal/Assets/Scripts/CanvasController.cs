using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _goldText;
    [SerializeField] private TextMeshProUGUI _gemsText;
    [SerializeField] private TextMeshProUGUI _techText;
    [SerializeField] private TextMeshProUGUI _pNameText;

    [SerializeField] private GameObject _goUIMoney;
    [SerializeField] private GameObject _goldParent;

    private void Awake()
    {
        GameManager.Instance.save.goldChangedEvent += GoldUpdated;
    }

    private void OnDestroy()
    {
        GameManager.Instance.save.goldChangedEvent -= GoldUpdated;
    }

    private void Start()
    {
        UpdateUI();
    }

    private void GoldUpdated(int gold, int incgold)
    {
        _goldText.text = GameManager.Instance.save.Gold.ToString();
        GameObject o = Instantiate(_goUIMoney);
        o.GetComponent<TextMeshProUGUI>().text = incgold.ToString();
        o.transform.SetParent(_goldParent.transform);
        Destroy(o, 1f);
    }

    public void UpdateUI()
    {
        _goldText.text = GameManager.Instance.save.Gold.ToString();
        _gemsText.text = GameManager.Instance.save.Gems.ToString();
        _techText.text = GameManager.Instance.save.Tech.ToString();

        _pNameText.text = GameManager.Instance.save.PlayerName;
    }

}
