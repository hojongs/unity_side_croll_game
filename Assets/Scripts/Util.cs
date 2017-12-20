using UnityEngine;

public class Util
{
    public enum POS_TYPE { X,Y,Z }

    public static Vector3 vector3(Vector3 v, POS_TYPE type, int value)
    {
        var temp = v;

        switch (type)
        {
            case POS_TYPE.X:
                temp.x = value;
                break;
            case POS_TYPE.Y:
                temp.y = value;
                break;
            case POS_TYPE.Z:
                temp.z = value;
                break;
        }

        return temp;
    }
}