using UnityEngine;

namespace NRSUNG
{
    /// <summary>
    /// C# 非靜態屬性與方法練習 2022.06.20
    /// </summary>
    public class NonStaticAPI_EX : MonoBehaviour
    {
        // 1.定義欄位,資料類型為類別
        // 2.Unity 屬性面板必須確定該欄位不是空值(None)
        // 3.使用非靜態API
        [SerializeField] private GameObject cube;
        [SerializeField] private GameObject sphere;
        [SerializeField] private GameObject capsule;

        [SerializeField] private SphereCollider sphere_collider;
        [SerializeField] private Camera cam;
        [SerializeField] private Rigidbody rig;
        //private Rigidbody rig;

        private void Awake()
        {
            //ani = GetComponent<Animator>();
            //rig = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            print("攝影機深度 : " + Camera.main.depth);
            //myCollider = GetComponent<SphereCollider>();
            //print("球體碰撞器半徑 : " + myCollider.radius);
            print("球體碰撞器半徑 : " + sphere_collider.radius);
            cam.backgroundColor = Color.green;
            capsule.transform.localScale = new Vector3(3, 2, 1);
        }

        private void Update()
        {
            cube.transform.LookAt(sphere.transform.position);
            sphere.transform.Rotate(0, 3, 0);
            rig.AddForce(new Vector3(0, 350, 0));
        }

        private void FixedUpdate()
        {
            //rig.AddForce(new Vector3(0, 30000, 0));
            //rig.AddForce(new Vector2(0, 350));,0
            //rig.AddForce(new Vector3(0, 3, 0));
            
        }
    }
}

