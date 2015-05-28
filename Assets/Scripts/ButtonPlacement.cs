using UnityEngine;
using System.Collections;

public class ButtonPlacement : MonoBehaviour {

    public Vector2 mPivot;
    public float mRelativeSizeComparedToXAxis;

    Vector2 mPosition;


	// Use this for initialization
	void Start () {
        float distanceFromCamera;
        distanceFromCamera = (transform.position - Camera.main.transform.position).z;

        mPosition.x = Camera.main.ViewportToWorldPoint(new Vector3(mPivot.x, mPivot.y, distanceFromCamera)).x;
        mPosition.y = Camera.main.ViewportToWorldPoint(new Vector3(mPivot.x, mPivot.y, distanceFromCamera)).y;

        
        transform.position = new Vector3(mPosition.x,
                                         mPosition.y,
                                         transform.position.z);
		
	}

}
