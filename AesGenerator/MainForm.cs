using System.Security.Cryptography;

namespace AesGenerator
{
    /// <summary>
    /// AES-256暗号鍵を自動生成するアプリ
    /// </summary>
    public partial class MainForm : Form
    {
        // 初期化ベクトル
        private static readonly int iv = 12;
        // 暗号鍵
        private static readonly int key = 24;

        public MainForm() => InitializeComponent();

        /// <summary>
        /// 暗号化ボタン
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            // 初期化ベクトル
            txtIv.Text = GenerateAes(iv);
            // 暗号鍵
            txtKey.Text = GenerateAes(key);
        }

        /// <summary>
        /// 復号化ボタン
        /// </summary>
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// AESの自動生成
        /// </summary>
        /// <param name="size">サイズ</param>
        /// <returns></returns>
        private static string GenerateAes(int size)
        {
            var buf = new byte[size];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(buf);

            return Convert.ToBase64String(buf);
        }
    }
}