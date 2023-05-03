using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectsSO kichenObjectSO;

    [SerializeField] private Transform counterTopPoint;

    public void Interact() {
        Debug.Log("Interacted!");
        Transform kitchenObjectTransform = Instantiate(kichenObjectSO.prefab, counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;
        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }

} // class