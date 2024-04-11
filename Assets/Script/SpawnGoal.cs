using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoal : MonoBehaviour
{
    public GameObject objectToSpawn; // Prefab của object cần spawn

    private void Start()
    {
        SpawnObject();
    }

    private void SpawnObject()
    {
        // Lấy kích thước của camera trong game
        Camera mainCamera = Camera.main;
        float cameraHeight = mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        // Tạo vị trí ngẫu nhiên trong phạm vi của camera
        Vector3 randomPosition = new Vector3(Random.Range(-cameraWidth, cameraWidth), Random.Range(-cameraHeight, cameraHeight), 0f);

        // Spawn object tại vị trí ngẫu nhiên
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}
