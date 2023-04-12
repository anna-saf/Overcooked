using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateIconsSingleUI : MonoBehaviour
{
    [SerializeField] private Image icon;

    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO)
    {
        icon.sprite = kitchenObjectSO.sprite;
    }
}
