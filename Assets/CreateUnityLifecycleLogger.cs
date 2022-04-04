using UnityEngine;

public class CreateUnityLifecycleLogger
{
    [RuntimeInitializeOnLoadMethod]
    static void Init()
    {
        Debug.Log("Before creating life cycle adapter");
        GameObject go = new GameObject("LifecycleAdapter",typeof(UnityLifeCycleEventsLogged));
        Object.DontDestroyOnLoad(go);
        Debug.Log("Created life cycle adapter");
    }
}