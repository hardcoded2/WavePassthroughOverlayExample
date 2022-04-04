    public class UnityLifeCycleEventsLogged : UnityLifeCycleEventsAdapter
    {
        private LogAllMonoBehaviourCallbacks LogCallbacks;
        protected new void Awake()
        {
            Callbacks = new MonobehaviourCallbacks();
            LogCallbacks = new LogAllMonoBehaviourCallbacks(Callbacks);
        }
    }
