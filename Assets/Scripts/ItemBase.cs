using UnityEngine;

public class ItemBase : MonoBehaviour,IInteractable
{
    public ItemData data;
    public void Interact()
    {
        // Implement interaction logic here
        Debug.Log("Interacting with : " + data.name);
        InventoryManager.instance.AddItem(data);
        Destroy(gameObject);
    }
}