using UnityEngine;

namespace NRSUNG
{
    public class NonStaticAPI_EX : MonoBehaviour
    {
        SphereCollider myCollider;
        private void Start()
        {
            print("攝影機深度 : " + Camera.main.depth);
            myCollider = GetComponent<SphereCollider>();
            print("球體碰撞器半徑 : " + myCollider.radius);
        }
    }
}

