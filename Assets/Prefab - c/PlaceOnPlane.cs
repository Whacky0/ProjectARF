using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace UnityEngine.XR.ARFoundation.Samples
{
    /// <summary>
    /// Listens for touch events and performs an AR raycast from the screen touch point.
    /// AR raycasts will only hit detected trackables like feature points and planes.
    ///
    /// If a raycast hits a trackable, the <see cref="placedPrefab"/> is instantiated
    /// and moved to the hit position.
    /// </summary>
    [RequireComponent(typeof(ARRaycastManager))]
    public class PlaceOnPlane : MonoBehaviour
    {

        [SerializeField]
        [Tooltip("Instantiates this prefab on a plane at the touch location.")]
        GameObject m_PlacedPrefab;
@ -33,9 +34,15 @@ namespace UnityEngine.XR.ARFoundation.Samples
        /// </summary>
        public GameObject spawnedObject { get; private set; }

        ARPlaneManager planeManager;
        ARPointCloudManager cloudManager;


        void Awake()
        {
            m_RaycastManager = GetComponent<ARRaycastManager>();
            planeManager = this.GetComponent<ARPlaneManager>();
            cloudManager = this.GetComponent<ARPointCloudManager>();
        }

        bool TryGetTouchPosition(out Vector2 touchPosition)
@ -50,6 +57,7 @@ namespace UnityEngine.XR.ARFoundation.Samples
            return false;
        }

    [System.Obsolete]
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
@ -64,16 + 72,20 @@
                if (spawnedObject == null)
        {
            spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, hitPose.rotation);
            planeManager.detectionMode = PlaneDetectionMode.None;
            cloudManager.enabled = false;
        }
        else
        {
            spawnedObject.transform.position = hitPose.position;
            planeManager.detectionMode = PlaneDetectionMode.Horizontal;
            cloudManager.enabled = true;
        }
    }
}

static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

ARRaycastManager m_RaycastManager;
    }
}