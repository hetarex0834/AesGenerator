using System.Security.Cryptography;
using System.Text;

namespace AesGenerator
{
    /// <summary>
    /// AES-256暗号を自動生成するアプリ
    /// </summary>
    public partial class MainForm : Form
    {
        // バイトサイズ
        private static readonly int ivSize = 12; // 初期化ベクトル
        private static readonly int keySize = 24; // 暗号鍵

        public MainForm() => InitializeComponent();

        /// <summary>
        /// 暗号化ボタン
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            // 初期化ベクトル
            txtIv.Text = GenerateAes(ivSize);
            // 暗号鍵
            txtKey.Text = GenerateAes(keySize);
            // 暗号化
            txtCipher.Text = Encrypt(txtPlain.Text, txtIv.Text, txtKey.Text);
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
        /// <param name="size">バイトサイズ</param>
        /// <returns>Base64形式の文字列</returns>
        private static string GenerateAes(int size)
        {
            // 乱数生成
            using var rng = RandomNumberGenerator.Create();
            var bytes = new byte[size];
            rng.GetBytes(bytes);

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// 平文をAES-256で暗号化
        /// </summary>
        /// <param name="plain">平文</param>
        /// <param name="iv">初期化ベクトル</param>
        /// <param name="key">暗号鍵</param>
        /// <returns>暗号文</returns>
        private static string Encrypt(string plain, string iv, string key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // ブロックサイズ
            aes.KeySize = 256; // 鍵長
            aes.Mode = CipherMode.CBC; // 暗号利用モード
            aes.Padding = PaddingMode.PKCS7; // パディング
            aes.IV = Encoding.UTF8.GetBytes(iv); // 初期化ベクトル
            aes.Key = Encoding.UTF8.GetBytes(key); // 暗号鍵

            // バイト配列化
            var byteText = Encoding.UTF8.GetBytes(plain);
            // 暗号化
            var encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            return Convert.ToBase64String(encryptText);
        }
    }
}