using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorData 
{
    public Vector2 hotspot = Vector2.zero;
    public Texture2D Texture = null;

    public void UpdateCursorData(Vector2 newHotspot, Texture2D newtexture)
    {
        hotspot = newHotspot;   
        Texture = newtexture;
    }

}
