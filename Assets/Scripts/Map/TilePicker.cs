﻿namespace DLS.LD39.Map
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using UnityEngine;

    [RequireComponent(typeof(TileMap))]
    public class TilePicker : MonoBehaviour
    {
        private TileMap _map;

        private void Start()
        {
            _map = GetComponent<TileMap>();
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                var hit = Physics2D.Raycast(ray, Vector2.zero);
                if (hit.collider != null)
                {
                    int x, y;
                    if (_map.GetTileCoords(hit.point, out x, out y))
                    {
                        _map.SetTileAt(x, y);

                    }
                }
            }
            
        }
    }
}
