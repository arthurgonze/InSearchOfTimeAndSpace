using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

namespace MyNamespace
{
    
}
public class Door : MonoBehaviour
{
    [SerializeField] private Key _key;

    private bool rotated = false;


    void Start()
    {
        SpawnKey();
    }

    private void SpawnKey()
    {
        if (_key)
        {
            Key k = Instantiate(_key, this.transform.localPosition, Quaternion.identity, this.transform);
            k.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            k.transform.localPosition = new Vector3(0f, 0f, -1f);
            foreach (Collider2D collider in k.GetComponents<Collider2D>())
            {
                collider.enabled = false;
            }
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (_key == null)
                {
                    OpenDoor();
                }
                else if (col.gameObject.GetComponent<Player>().HaveKey(_key.GetKeyID()))
                {
                    OpenDoor();
                }
            }
        }
    }

    private void OpenDoor()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        if (!rotated)
        {
            this.transform.Rotate(new Vector3(0, 1, 0), 60);
            rotated = true;
        }
    }
}
