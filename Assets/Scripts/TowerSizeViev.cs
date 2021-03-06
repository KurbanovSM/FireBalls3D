using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TowerSizeViev : MonoBehaviour
{
    [SerializeField] private TMP_Text _sizeViev;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.SizeUpdate += OnSizeUpdated;
    }

    private void OnDisable()
    {
        _tower.SizeUpdate -= OnSizeUpdated;
    }

    private void OnSizeUpdated(int size)
    {
        _sizeViev.text = size.ToString();
    }
}
