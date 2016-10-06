using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyItemManager : MonoBehaviour {
    public static int keyitem;

    Text text;

    // Use this for initialization
    void Start()
    {

        text = GetComponent<Text>();

        keyitem = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (keyitem <= 0)
            keyitem = 0;

        text.text = " " + keyitem + "/1";

    }

    public static void AddItem(int foundItem)
    {
        keyitem += foundItem;
    }


    public static void Reset()
    {
        keyitem = 0;
    }
}
