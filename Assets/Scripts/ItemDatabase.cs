using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static Item[] Items { get; private set; }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]private static void Initialise() => Items = Resources.LoadAll<Item>("Items/");
}
