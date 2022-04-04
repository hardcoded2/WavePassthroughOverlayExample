using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://docs.unity3d.com/Manual/ExecutionOrder.html
public class UnityLifeCycleEventsAdapter : MonoBehaviour
{
    public MonobehaviourCallbacks Callbacks;
    
    protected void Awake()
    {
        if(Callbacks == null)
            Callbacks = new MonobehaviourCallbacks();

        Callbacks?.Awake();
    }
    private void Start()
    {
        Callbacks?.Start();
    }
    private void Update()
    {
        Callbacks?.Update();
    }
    
    private void Reset()
    {
        Callbacks?.Reset();
    }

    private void FixedUpdate()
    {
        Callbacks?.FixedUpdate();
    }

    private void LateUpdate()
    {
        Callbacks?.LateUpdate();
    }

    private void OnEnable()
    {
        Callbacks?.OnEnable();
    }

    private void OnDisable()
    {
        Callbacks?.OnDisable();
    }

    private void OnDestroy()
    {
        Callbacks?.OnDestroy();
    }

    private void OnGUI()
    {
        Callbacks?.OnGUI();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        Callbacks?.OnAnimatorIK(layerIndex);
    }

    private void OnAnimatorMove()
    {
        Callbacks?.OnAnimatorMove();
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Callbacks?.OnApplicationFocus(hasFocus);
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        Callbacks?.OnApplicationPause(pauseStatus);
    }

    private void OnApplicationQuit()
    {
        Callbacks?.OnApplicationQuit();
    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        Callbacks?.OnAudioFilterRead(data,channels);
    }

    private void OnBecameInvisible()
    {
        Callbacks?.OnBecameInvisible();
    }

    private void OnBecameVisible()
    {
        Callbacks?.OnBecameVisible();
    }

    private void OnBeforeTransformParentChanged()
    {
        Callbacks?.OnBeforeTransformParentChanged();
    }

    private void OnCanvasGroupChanged()
    {
        Callbacks?.OnCanvasGroupChanged();
    }

    private void OnCanvasHierarchyChanged()
    {
        Callbacks?.OnCanvasHierarchyChanged();
    }

    private void OnCollisionEnter(Collision other)
    {
        Callbacks?.OnCollisionEnter(other);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Callbacks?.OnCollisionEnter2D(other);
    }

    private void OnCollisionExit(Collision other)
    {
        Callbacks?.OnCollisionExit(other);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Callbacks?.OnCollisionExit2D(other);
    }

    private void OnCollisionStay(Collision other)
    {
        Callbacks?.OnCollisionStay(other);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Callbacks?.OnCollisionStay2D(other);
    }

    private void OnConnectedToServer()
    {
        Callbacks?.OnConnectedToServer();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Callbacks?.OnControllerColliderHit(hit);
    }

    private void OnDidApplyAnimationProperties()
    {
        Callbacks?.OnDidApplyAnimationProperties();
    }

    private void OnDrawGizmos()
    {
        Callbacks?.OnDrawGizmos();
    }

    private void OnDrawGizmosSelected()
    {
        Callbacks?.OnDrawGizmosSelected();
    }

    private void OnJointBreak(float breakForce)
    {
        Callbacks?.OnJointBreak(breakForce);
    }

    private void OnJointBreak2D(Joint2D brokenJoint)
    {
        Callbacks?.OnJointBreak2D(brokenJoint);
    }

    private void OnMouseDown()
    {
        Callbacks?.OnMouseDown();
    }

    private void OnMouseDrag()
    {
        Callbacks?.OnMouseDrag();
    }

    private void OnMouseEnter()
    {
        Callbacks?.OnMouseEnter();
    }

    private void OnMouseExit()
    {
        Callbacks?.OnMouseExit();
    }

    private void OnMouseOver()
    {
        Callbacks?.OnMouseOver();
    }

    private void OnMouseUp()
    {
        Callbacks?.OnMouseUp();
    }

    private void OnMouseUpAsButton()
    {
        Callbacks?.OnMouseUpAsButton();
    }

    private void OnParticleCollision(GameObject other)
    {
        Callbacks?.OnParticleCollision(other);
    }

    private void OnParticleSystemStopped()
    {
        Callbacks?.OnParticleSystemStopped();
    }

    private void OnParticleTrigger()
    {
        Callbacks?.OnParticleTrigger();
    }

    private void OnParticleUpdateJobScheduled()
    {
        Callbacks?.OnParticleUpdateJobScheduled();
    }

    private void OnPostRender()
    {
        Callbacks?.OnPostRender();
    }

    private void OnPreCull()
    {
        Callbacks?.OnPreCull();
    }

    private void OnPreRender()
    {
        Callbacks?.OnPreRender();
    }

    private void OnRectTransformDimensionsChange()
    {
        Callbacks?.OnRectTransformDimensionsChange();
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Callbacks?.OnRenderImage(src,dest);
    }

    private void OnRenderObject()
    {
        Callbacks?.OnRenderObject();
    }

    private void OnServerInitialized()
    {
        Callbacks?.OnServerInitialized();
    }

    private void OnTransformChildrenChanged()
    {
        Callbacks?.OnTransformChildrenChanged();
    }

    private void OnTransformParentChanged()
    {
        Callbacks?.OnTransformParentChanged();
    }

    private void OnTriggerEnter(Collider other)
    {
        Callbacks?.OnTriggerEnter(other);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Callbacks?.OnTriggerEnter2D(other);
    }

    private void OnTriggerExit(Collider other)
    {
        Callbacks?.OnTriggerExit(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Callbacks?.OnTriggerExit2D(other);
    }

    private void OnTriggerStay(Collider other)
    {
        Callbacks?.OnTriggerStay(other);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Callbacks?.OnTriggerStay2D(other);
    }

    private void OnValidate()
    {
        Callbacks?.OnValidate();
    }

    private void OnWillRenderObject()
    {
        Callbacks?.OnWillRenderObject();
    }

}