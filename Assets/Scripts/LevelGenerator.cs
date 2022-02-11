using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public GameObject FirstPlatformPrefab;
    int platformsCount = 10; // количество платформ на уровне
    private float _distanceBetweenPlatform = 6f;
    public Transform CylinderRoot;
    public float ExtraCylinderScale = 1f;
    public Game Game;

    private void Awake()
    {
        int levelIndex = Game.LevelIndex;
        System.Random random = new System.Random(levelIndex);
      

        for (int i = 0; i < platformsCount; i++)
        {
            int prefabIndex = random.Next(0, PlatformPrefabs.Length);
            GameObject platformPrefab = i == 0 ? FirstPlatformPrefab : PlatformPrefabs[prefabIndex]; // первый префаб фиксированный 
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.localPosition = CalculatePlatformPosition(i);
            if (i > 0)
                platform.transform.localRotation = Quaternion.Euler(0, random.Next(0, 360), 0);
        }

        CylinderRoot.localScale = new Vector3(1, 35, 1);
    }

    private Vector3 CalculatePlatformPosition(int platformIndex)
    {
        return new Vector3(0, -_distanceBetweenPlatform * platformIndex, 0);
    }
}
