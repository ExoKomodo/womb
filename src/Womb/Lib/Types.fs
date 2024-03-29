module Womb.Lib.Types

type IVector1 = int
type IVector2 = int * int
type IVector3 = int * int * int
type IVector4 = int * int * int * int

type UVector1 = uint
type UVector2 = uint * uint
type UVector3 = uint * uint * uint
type UVector4 = uint * uint * uint * uint

type Vector1 = single
type Vector2 = single * single
type Vector3 = single * single * single
type Vector4 = single * single * single * single

type Transform =
  { Scale: Vector3;
    Rotation: Vector3; 
    Translation: Vector3; }

    static member Default() =
      { Scale = Vector3(1.0f, 1.0f, 1.0f)
        Rotation = Vector3(0f, 0f, 0f) 
        Translation = Vector3(0f, 0f, 0f) }
