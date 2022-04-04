using System;
using UnityEngine;

public class MonobehaviourCallbacks
{
    public Action Awake;

    public Action Start;

    public Action Update;
    public Action Reset;
    public Action FixedUpdate;
    public Action LateUpdate;
    public Action OnEnable;
    public Action OnDisable;
    public Action OnDestroy;
    public Action OnGUI;
    public Action<int> OnAnimatorIK;
    public Action OnAnimatorMove;
    public Action<bool> OnApplicationFocus;
    public Action<bool> OnApplicationPause;
    public Action OnApplicationQuit;
    public Action<float[], int> OnAudioFilterRead;
    public Action OnBecameInvisible;
    public Action OnBecameVisible;
    public Action OnBeforeTransformParentChanged;
    public Action OnCanvasGroupChanged;
    public Action OnCanvasHierarchyChanged;
    public Action<Collision> OnCollisionEnter;
    public Action<Collision2D> OnCollisionEnter2D;
    public Action<Collision> OnCollisionExit;
    public Action<Collision2D> OnCollisionExit2D;
    public Action<Collision> OnCollisionStay;
    public Action<Collision2D> OnCollisionStay2D;
    public Action OnConnectedToServer;
    public Action<ControllerColliderHit> OnControllerColliderHit;
    public Action OnDidApplyAnimationProperties;
    public Action OnDrawGizmos;
    public Action OnDrawGizmosSelected;
    public Action<float> OnJointBreak;
    public Action<Joint2D> OnJointBreak2D;
    public Action OnMouseDown;
    public Action OnMouseDrag;
    public Action OnMouseEnter;
    public Action OnMouseExit;
    public Action OnMouseOver;
    public Action OnMouseUp;
    public Action OnMouseUpAsButton;
    public Action<GameObject> OnParticleCollision;
    public Action OnParticleSystemStopped;
    public Action OnParticleTrigger;
    public Action OnParticleUpdateJobScheduled;
    public Action OnPostRender;
    public Action OnPreCull;
    public Action OnPreRender;
    public Action OnRectTransformDimensionsChange;
    public Action<RenderTexture, RenderTexture> OnRenderImage;
    public Action OnRenderObject;
    public Action OnServerInitialized;
    public Action OnTransformChildrenChanged;
    public Action OnTransformParentChanged;
    public Action<Collider> OnTriggerEnter;
    public Action<Collider2D> OnTriggerEnter2D;
    public Action<Collider> OnTriggerExit;
    public Action<Collider2D> OnTriggerExit2D;
    
    public Action<Collider> OnTriggerStay;
    public Action<Collider2D> OnTriggerStay2D;
    public Action OnValidate;
    public Action OnWillRenderObject;
}

