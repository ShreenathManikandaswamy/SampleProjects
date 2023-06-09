using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Runtime.InteropServices;

public class NativeEmbeddIos : MonoBehaviour
{
#if UNITY_IOS
    [DllImport("__Internal")]
    private static extern void NativeiOSCode_runNativeCode(string input);
#endif

    private void Start()
    {
        RunNativeCode("running ios code from Unity");
    }

    private void RunNativeCode(string input)
    {
#if UNITY_IOS
        NativeiOSCode_runNativeCode(input);
#else
        Debug.Log("Not in ios Platform);
#endif
    }
}
