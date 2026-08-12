using UnityEngine;

public class Cake : MonoBehaviour
{

    GameObject cakePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("the script is running mate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        Debug.Log("you smacked da cake");
        Destroy(gameObject);
    }
}
