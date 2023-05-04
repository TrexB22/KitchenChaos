using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour, IKitchenObjectParent
{

    [SerializeField] private KitchenObjectsSO kichenObjectSO;

    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;



    public void Interact(Player player) {
        if (kitchenObject == null) {
            Transform kitchenObjectTransform = Instantiate(kichenObjectSO.prefab, counterTopPoint);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(this);
        } else {
            kitchenObject.SetKitchenObjectParent(player);
        }
        
    }

    public Transform GetKitchenObjectFollowTransform() {
        return counterTopPoint;
    }

    public KitchenObject GetKitchenObject() { 
        return kitchenObject;
    }

    public void SetKitchenObject(KitchenObject kitchenObject) { 
        this.kitchenObject = kitchenObject;
    }

    public void ClearKitchenObject() {
        kitchenObject = null;
    }

    public bool HasKitchenObject() {
        return (kitchenObject != null);
    }

} // class