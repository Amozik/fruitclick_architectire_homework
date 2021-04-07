using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Interfaces;
using UnityEngine;

public class AppleView : CollectableView
{
    private ICollectableViewModel _appleViewModel;

    public void Initialize(ICollectableViewModel appleViewModel)
    {
        _appleViewModel = appleViewModel;
    }

    public override void Collect(int points)
    {
        _appleViewModel.AddScore(points);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            _appleViewModel.SubtractLive();
            Destroy(gameObject);
        }
    }
}
