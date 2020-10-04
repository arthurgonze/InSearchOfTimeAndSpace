using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Interact"))
            {
                PickArtifact(col);
            }
        }
    }

    private void PickArtifact(Collision2D col)
    {
        col.gameObject.GetComponent<Player>().AddArtifact();
        col.gameObject.GetComponent<Player>().BackToTheFuture();
        FindObjectOfType<LevelManager>().SpawnNextArctifact();
        Destroy(this.gameObject);
    }
}
