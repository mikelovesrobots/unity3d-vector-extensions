using UnityEngine;
using System.Collections;

public static class VectorExtensions {
    public static Vector3 ToGuiCoordinateSystem(this Vector3 a) {
        var copy = a;
        copy.y = Screen.height - copy.y;
        return copy;
    }
    
    public static Vector3 Mask(this Vector3 a, Vector3 mask) {
        return new Vector3(a.x * mask.x, a.y * mask.y, a.z * mask.z);
    }

    public static Vector3 Abs(this Vector3 a) {
        return new Vector3(Mathf.Abs(a.x), Mathf.Abs(a.y), Mathf.Abs(a.z));
    }

    public static Vector3 Inverse(this Vector3 a) {
        return new Vector3(1/a.x, 1/a.y, 1/a.z);
    }
}
