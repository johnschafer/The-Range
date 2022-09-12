using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRCustomGrabInteractable : XRGrabInteractable
{
    [SerializeField] private Animator animator;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);
        animator.SetTrigger("Fire");
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
    }
}
