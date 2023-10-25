using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private AssetReferenceGameObject _playground;

    void Start()
    {
        GameBusSystem.CallPlaygroundLoading();
        _playground.InstantiateAsync().Completed += OnPlaygroundLoaded;
    }

    private void OnPlaygroundLoaded(AsyncOperationHandle<GameObject> handle)
    {
        GameBusSystem.CallPlaygroundLoaded();
    }
}
