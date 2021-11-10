namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Utils;
	using Mapbox.Unity.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.Utilities;
	using System.Collections.Generic;

	public class SpawnOnMap : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		[Geocode]
		string[] _locationStrings;
		Vector2d[] _locations;

		[SerializeField]
		float _spawnScale = 100f;

		[SerializeField]
		 GameObject _markerPrefab;

		
		public GameObject [] _spawnedObjects= new GameObject[3];

		void Start()
		{
			_locations = new Vector2d[_locationStrings.Length];
			for (int i = 0; i < _locationStrings.Length; i++)
			{
				var locationString = _locationStrings[i];
				_locations[i] = Conversions.StringToLatLon(locationString);
				var instance = Instantiate(_spawnedObjects[i]);
				instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
				instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
			}
		}

		private void Update()
		{
			int count = _spawnedObjects.Length;
            if (_map.Zoom <= 8) {
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
				_spawnScale = 5;
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
}