using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PuzzleInput : MonoBehaviour {
    public AspectBase selectedAspect;
    public Tilemap aspectMap;

    private Camera cam;

    private void Start() {
        cam = Camera.main;
    }

    private void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int tilePos = Vector3Int.FloorToInt(mousePos);
            if (!aspectMap.GetTile(tilePos)) {
                //aspectMap.SetTile(tilePos, selectedAspect.tile);
                aspectMap.SetTile(Vector3Int.one, selectedAspect.tile);
            }
        }
    }
}
