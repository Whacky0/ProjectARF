using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using Mapbox.Unity.Utilities;


public class MarkerMartin : MonoBehaviour
{
	[SerializeField]
	AbstractMap _map;

	List<string> _locationStrings = new List<string>();
	List<Vector2d> _locations = new List<Vector2d>();

	float _spawnScale = 1;


	[SerializeField]
	GameObject Martin;

	List<GameObject> _spawnedObjects = new List<GameObject>();



	private void Awake()
	{
		_locationStrings.Add("-34.5704507, -58.4176425");//Martin

	}

	void Start()
	{
		for (int i = 0; i < _locationStrings.Count; i++)
		{
			var locationString = _locationStrings[i];
			_locations.Add(Conversions.StringToLatLon(locationString));
			var instance = Instantiate(Martin);
			instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
			instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			_spawnedObjects.Add(instance);
		}

	}

	private void Update()
	{
		int count = _spawnedObjects.Count;
		if (_map.Zoom <= 12)
		{
			_spawnScale = 1;
			for (int i = 0; i < count; i++)
			{
				var spawnedObject = _spawnedObjects[i];
				var location = _locations[i];
				spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
				spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			}
		}
		else
		{
			_spawnScale = 2.5f;
			for (int i = 0; i < count; i++)
			{
				var spawnedObject = _spawnedObjects[i];
				var location = _locations[i];
				spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
				spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			}
		}
	}
}