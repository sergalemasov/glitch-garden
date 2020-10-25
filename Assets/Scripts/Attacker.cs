using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)]
    [SerializeField]
    private float walkSpeed = 1f;
    // Start is called before the first frame update 

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(walkSpeed * Time.deltaTime * Vector2.left);
    }
}
