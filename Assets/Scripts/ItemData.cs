using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData",menuName = "Workshop/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
}
