using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    private Vector3 rotateAmount = new Vector3(0, 0, 20);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(this.rotateAmount);
    }
}
