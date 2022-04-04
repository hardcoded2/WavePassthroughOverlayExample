using UnityEngine;

public class LogAllMonoBehaviourCallbacks
{
    private MonobehaviourCallbacks Callbacks;

    public LogAllMonoBehaviourCallbacks(MonobehaviourCallbacks monobehaviourCallbacks)
    {
        Callbacks = monobehaviourCallbacks;
        monobehaviourCallbacks.Start += () => Debug.Log($"{nameof(monobehaviourCallbacks.Start)}");
        monobehaviourCallbacks.Update += () => Debug.Log($"{nameof(monobehaviourCallbacks.Update)}");
        
        monobehaviourCallbacks.Reset += () => Debug.Log($"{nameof(monobehaviourCallbacks.Reset)}");
        monobehaviourCallbacks.FixedUpdate += () => Debug.Log($"{nameof(monobehaviourCallbacks.FixedUpdate)}");
        monobehaviourCallbacks.LateUpdate += () => Debug.Log($"{nameof(monobehaviourCallbacks.LateUpdate)}");
        monobehaviourCallbacks.OnEnable += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnEnable)}");
        monobehaviourCallbacks.OnDisable += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnDisable)}");
        monobehaviourCallbacks.OnDestroy += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnDestroy)}");
        monobehaviourCallbacks.OnGUI += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnGUI)}");
        monobehaviourCallbacks.OnAnimatorIK += (int layerIndex) => Debug.Log($"{nameof(monobehaviourCallbacks.OnAnimatorIK)} {layerIndex}");
        
        monobehaviourCallbacks.OnAnimatorMove += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnAnimatorMove)}");
        monobehaviourCallbacks.OnApplicationFocus += (bool hasFocus) => Debug.Log($"{nameof(monobehaviourCallbacks.OnApplicationFocus)} {hasFocus}");
        monobehaviourCallbacks.OnApplicationPause += (bool pauseStatus) => Debug.Log($"{nameof(monobehaviourCallbacks.OnApplicationPause)} {pauseStatus}");
        monobehaviourCallbacks.OnApplicationQuit += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnApplicationQuit)}");
        monobehaviourCallbacks.OnAudioFilterRead += (float[] data,int channels) => Debug.Log($"{nameof(monobehaviourCallbacks.OnAudioFilterRead)}");
        monobehaviourCallbacks.OnBecameInvisible += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnBecameInvisible)}");
        monobehaviourCallbacks.OnBecameVisible += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnBecameVisible)}");
        monobehaviourCallbacks.OnBeforeTransformParentChanged += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnBeforeTransformParentChanged)}");
        monobehaviourCallbacks.OnCanvasGroupChanged += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnCanvasGroupChanged)}");
        monobehaviourCallbacks.OnCanvasHierarchyChanged += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnCanvasHierarchyChanged)}");
        monobehaviourCallbacks.OnCollisionEnter += (Collision other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionEnter)}");
        monobehaviourCallbacks.OnCollisionEnter2D += (Collision2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionEnter2D)}");
        monobehaviourCallbacks.OnCollisionExit += (Collision other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionExit)}");
        monobehaviourCallbacks.OnCollisionExit2D += (Collision2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionExit2D)}");
        monobehaviourCallbacks.OnCollisionStay += (Collision other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionStay)}");
        monobehaviourCallbacks.OnCollisionStay2D += (Collision2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnCollisionStay2D)}");
        monobehaviourCallbacks.OnConnectedToServer += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnConnectedToServer)}");
        monobehaviourCallbacks.OnControllerColliderHit += (ControllerColliderHit hit) => Debug.Log($"{nameof(monobehaviourCallbacks.OnControllerColliderHit)}");
        monobehaviourCallbacks.OnDidApplyAnimationProperties += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnDidApplyAnimationProperties)}");
        monobehaviourCallbacks.OnDrawGizmos += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnDrawGizmos)}");
        monobehaviourCallbacks.OnDrawGizmosSelected += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnDrawGizmosSelected)}");
        monobehaviourCallbacks.OnJointBreak += (float breakForce) => Debug.Log($"{nameof(monobehaviourCallbacks.OnJointBreak)}");
        monobehaviourCallbacks.OnJointBreak2D += (Joint2D brokenJoint) => Debug.Log($"{nameof(monobehaviourCallbacks.OnJointBreak2D)}");
        monobehaviourCallbacks.OnMouseDown += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseDown)}");
        monobehaviourCallbacks.OnMouseDrag += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseDrag)}");
        monobehaviourCallbacks.OnMouseEnter += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseEnter)}");
        monobehaviourCallbacks.OnMouseExit += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseExit)}");
        monobehaviourCallbacks.OnMouseOver += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseOver)}");
        monobehaviourCallbacks.OnMouseUp += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseUp)}");
        monobehaviourCallbacks.OnMouseUpAsButton += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnMouseUpAsButton)}");
        monobehaviourCallbacks.OnParticleCollision += (GameObject other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnParticleCollision)}");
        monobehaviourCallbacks.OnParticleSystemStopped += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnParticleSystemStopped)}");
        monobehaviourCallbacks.OnParticleTrigger += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnParticleTrigger)}");
        monobehaviourCallbacks.OnParticleUpdateJobScheduled += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnParticleUpdateJobScheduled)}");
        monobehaviourCallbacks.OnPostRender += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnPostRender)}");
        monobehaviourCallbacks.OnPreCull += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnPreCull)}");
        monobehaviourCallbacks.OnPreRender += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnPreRender)}");
        monobehaviourCallbacks.OnRectTransformDimensionsChange += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnRectTransformDimensionsChange)}");
        monobehaviourCallbacks.OnRenderImage += (RenderTexture src,RenderTexture dest) => Debug.Log($"{nameof(monobehaviourCallbacks.OnRenderImage)}");
        monobehaviourCallbacks.OnRenderObject += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnRenderObject)}");
        monobehaviourCallbacks.OnServerInitialized += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnServerInitialized)}");
        monobehaviourCallbacks.OnTransformChildrenChanged += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnTransformChildrenChanged)}");
        monobehaviourCallbacks.OnTransformParentChanged += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnTransformParentChanged)}");
        monobehaviourCallbacks.OnTriggerEnter += (Collider other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerEnter)}");
        monobehaviourCallbacks.OnTriggerEnter2D += (Collider2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerEnter2D)}");
        monobehaviourCallbacks.OnTriggerExit += (Collider other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerExit)}");
        monobehaviourCallbacks.OnTriggerExit2D += (Collider2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerExit2D)}");
        monobehaviourCallbacks.OnTriggerStay += (Collider other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerStay)}");
        monobehaviourCallbacks.OnTriggerStay2D += (Collider2D other) => Debug.Log($"{nameof(monobehaviourCallbacks.OnTriggerStay2D)}");
        monobehaviourCallbacks.OnValidate += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnValidate)}");
        monobehaviourCallbacks.OnWillRenderObject += () => Debug.Log($"{nameof(monobehaviourCallbacks.OnWillRenderObject)}");
    }
}