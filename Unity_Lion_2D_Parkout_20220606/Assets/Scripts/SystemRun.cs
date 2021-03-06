using UnityEngine;

namespace NRSUNG
{
    // C# 從藍圖變成實體物件
    // 1. 場景上的遊戲物件 Game Object 灰色線條方塊
    // 2. 將此腳本掛在該物件變成元件

    /// 
    /// 跑步系統
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料 : 保存系統需要的資料

        // 欄位 Field : 保存資料
        // 語法 : 
        // 修飾詞 欄位資料類型 欄位自訂名稱 (指定 預設);

        // 修飾詞
        // 公開 : 顯示在面板上 , 允許其他類別存取 public
        // 私人 : 不顯示在面板上 , 不允許其他類別存取 private (封裝)

        // [] Attritube 屬性 . 額外功能
        // Serialize Field 序列化欄位:將私人欄位顯示
        // Header 標題:可以使用中文
        // Tooltip 提示:可以使用中文
        // Range 範圍:僅限於數值類型資料 int, float, byte, long

        [SerializeField, Header("跑步速度"), Tooltip("這是角色的跑步速度"), Range(0, 100)]
        private float speedRun = 15.5f;
        [SerializeField, Header("跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 功能 : 實作該系統的複雜方法
        // 方法 Method
        // 語法
        // 修飾詞 傳回資料類型 方法名稱(參數) { 程式 }
        private void Run()
        {
            print("跑步中 ~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }
        #endregion

        #region 事件 : 程式入口
        // 喚醒事件 : 開始事件前執行一次 , 取得元件等等
        private void Awake()
        {
            // ani 指定 忍者龜身上的 Animator
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        // 開始事件 : 撥放遊戲時執行一次
        // 初始化設定 . 例如 :
        private void Start()
        {
            //print("哈囉 . 沃德 :D");
        }

        // 更新事件 : 每秒執行約60次 60 Frame per second
        private void Update()
        {
            //print("<color=yellow>更新事件執行中~</color>");
            Run();
        }

        // 此元件被勾選時,執行一次
        private void OnEnable()
        {
            
        }

        // 此元件被取消時,執行一次
        private void OnDisable()
        {
            // 剛體加速度歸零
            rig.velocity = Vector2.zero;
        }
        #endregion

    }

    

}

