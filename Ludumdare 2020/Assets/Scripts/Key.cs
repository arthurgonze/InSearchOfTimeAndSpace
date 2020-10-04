using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private string _keyID;
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Interact"))
            {
                PickKey(col);
            }
        }
    }

    private void PickKey(Collision2D col)
    {
        col.gameObject.GetComponent<Player>().AddKey(_keyID);
        
        Destroy(this.gameObject);
    }

    public string GetKeyID()
    {
        return _keyID;
    }
}
