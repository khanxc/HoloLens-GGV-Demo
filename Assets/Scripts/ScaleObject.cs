using UnityEngine;
using System.Collections;

public class ScaleObject : MonoBehaviour {


    public GameObject go;

    private const float DefaultSizeFactor = 0.009f;

    [Tooltip("Size multiplier to use when scaling the object up and down.")]
    public float SizeFactor = DefaultSizeFactor;



    public void onScaleBigger()
    {
        if (go.transform.localScale.x < 0.027f)
        {
            this.go.transform.localScale = new Vector3(this.go.transform.localScale.x * 2, this.go.transform.localScale.y * 2, this.go.transform.localScale.z * 2);
        }
    }

    public void onScaleSmaller()
    {
        if (go.transform.localScale.x > 0.009f)
        {
            this.go.transform.localScale = new Vector3(this.go.transform.localScale.x / 2, this.go.transform.localScale.y / 2, this.go.transform.localScale.z / 2);
        } else { this.go.transform.localScale = new Vector3(0.009f, 0.009f, 0.009f); }
    }
}
