using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UIElements;
using Wave.Native;
using Wave.Essence;

namespace Wave.Essence.Samples.PassThroughOverlayExample
{
	public class PassThroughOverlayExample : MonoBehaviour
	{
		private static string LOG_TAG = "PassThroughOverlayTest";

		void Start()
		{
			Toggle(true);
		}

		// Update is called once per frame
		void Update()
		{
			if (WXRDevice.ButtonPress(WVR_DeviceType.WVR_DeviceType_Controller_Right, WVR_InputId.WVR_InputId_Alias1_Trigger))
			{
				Toggle(true);
			}

			if (WXRDevice.ButtonPress(WVR_DeviceType.WVR_DeviceType_Controller_Left,
				WVR_InputId.WVR_InputId_Alias1_Trigger))
			{
				Toggle(false);
			}
		}

		private void Toggle(bool show)
		{
			Log.i(LOG_TAG, "PassThroughOverlay start: " + show);

			void ToggleUnderlay()
			{
				var result = Interop.WVR_ShowPassthroughUnderlay(show);
				if (result != WVR_Result.WVR_Success)
				{
					Debug.LogError($"Error when setting overlay when setting it to {show} value was {result}");
				}
			}
			void ToggleOverlay()
			{
				if (Interop.WVR_ShowPassthroughOverlay(show))
				{
					Debug.LogError($"Error when setting overlay when setting it to {show}");
				}
			}
			ToggleUnderlay();
			//ToggleOverlay();
		}

		private void OnApplicationPause()
		{
			Toggle(false);
			Log.i(LOG_TAG, "ShowPassThroughOverlay Pause: ");
		}

		private void OnApplicationQuit()
		{
			Toggle(false);
			Log.i(LOG_TAG, "ShowPassThroughOverlay Quit: " );
		}
	}
}
