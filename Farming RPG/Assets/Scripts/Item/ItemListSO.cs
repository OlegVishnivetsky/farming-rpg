using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Item/Item List", fileName = "New ItemList")]
public class ItemListSO : ScriptableObject
{
    [SerializeField] private List<ItemDetails> itemDetails;

    public List<ItemDetails> GetItemDetails() 
    { 
        return itemDetails; 
    }
}