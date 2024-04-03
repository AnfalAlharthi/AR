using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageCreator : MonoBehaviour
{
    [SerializeField] private GameObject imageCreater;
    [SerializeField] private Vector3 imageOffset;

    private GameObject butterfly;

    private ARTrackedImageManager arTracker;


    private void OnEnable() { 


arTracker = gameObject.GetComponent<ARTrackedImageManager>();  
        // Start is called before the first frame update
        // We assign it to this variable arTracker


arTracker.trackedImagesChanged +=OnImageChabged;

}

    private void OnImageChabged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)

        {
            butterfly = Instantiate(imageCreater,image.transform);
            butterfly.transform.position += imageOffset;

        }
    }
}
