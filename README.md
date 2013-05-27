Vector3 Extensions
===============================

Installation
------------

Copy the VectorExtensions directory to your Assets/Plugins folder.  
Make the plugins folder if it doesn't exist.

Synopsis
--------

Contains a variety of Vector3 extension methods.

ToGuiCoordinateSystem
---------------------
```
var cameraScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
guiPoint = cameraScreenPoint.ToGuiCoordinateSystem();
GUI.Label(new Rect(guiPoint.x, guiPoint.y, width, height), label);
```

The problem with Camera.WorldToScreenPoint is that the coordinate system returned
cannot be used directly in GUI methods because the y-coordinate is flipped. This 
inverts the Y.

Mask
---------------------

```
var a = new Vector3(1, 2, 3)
var mask = new Vector3(1, 0, 1)
a.Mask(mask)
# new Vector3(1, 0, 3)
```

Use to mask off certain properties in the vector.  Useful for working with 
normals when aligned to a grid.

Abs
---
```
var a = new Vector3(-1, -2, 4)
a.Abs()
# new Vector3(1, 2, 4)
```

Returns the absolute value of the vector.

Inverse
-------
```
var a = new Vector3(4, 5, 8)
a.Inverse();
# new Vector3(0.25f, 0.2f, 0.125f);
```

Returns the inverse of the vector.


Note from the author
--------------------

Contact me if you've got any questions, bugs or contract work to throw my way.

Cheers,

Mike

mikelovesrobots@gmail.com

@mikelovesrobots on Twitter
