using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int Id;
    public ItemType Type;
    public string Description;
    public string LongDescription;
    public Sprite Sprite;
    public short UsingGridRadius;
    public float UsingRadius;
    public bool isStartingItem;
    public bool canBePickedUp;
    public bool canBeDropped;
    public bool canBeEaten;
    public bool canBeCarried;
}