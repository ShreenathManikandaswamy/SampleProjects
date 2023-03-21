using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LoadAddressable : MonoBehaviour
{
    [SerializeField]
    private string key;
    private AsyncOperationHandle<GameObject> opHandle;

    public IEnumerator Start()
    {
        opHandle = Addressables.LoadAssetAsync<GameObject>(key);
        yield return opHandle;

        if (opHandle.Status == AsyncOperationStatus.Succeeded)
        {
            GameObject obj = opHandle.Result;
            Instantiate(obj, transform);
        }
    }

    void OnDestroy()
    {
        Addressables.Release(opHandle);
    }
}
