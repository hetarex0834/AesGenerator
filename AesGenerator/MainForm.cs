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
        /// 鍵生成ボタン
        /// </summary>
        private void BtnGenKey_Click(object sender, EventArgs e)
        {
            // 初期化ベクトル
            txtIv.Text = GenerateAes(ivSize);
            // 暗号鍵
            txtKey.Text = GenerateAes(keySize);
        }

        /// <summary>
        /// 暗号化ボタン
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            var iv = Encoding.UTF8.GetBytes(txtIv.Text);
            var key = Encoding.UTF8.GetBytes(txtKey.Text);

            // 暗号化
            txtCipher.Text = Encrypt(txtPlain.Text, iv, key);
        }

        /// <summary>
        /// 復号化ボタン
        /// </summary>
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            var iv = Encoding.UTF8.GetBytes(txtIv.Text);
            var key = Encoding.UTF8.GetBytes(txtKey.Text);

            // 復号化
            txtDecrypted.Text = Decrypt(txtCipher.Text, iv, key);
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
        private static string Encrypt(string plain, byte[] iv, byte[] key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // ブロックサイズ
            aes.KeySize = 256; // 鍵長
            aes.Mode = CipherMode.CBC; // 暗号利用モード
            aes.Padding = PaddingMode.PKCS7; // パディング
            aes.IV = iv; // 初期化ベクトル
            aes.Key = key; // 暗号鍵

            // 暗号化
            var byteText = Encoding.UTF8.GetBytes(plain);
            var cipher = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            return Convert.ToBase64String(cipher);
        }

        /// <summary>
        /// 暗号文をAES-256で復号化
        /// </summary>
        /// <param name="cipher">暗号文</param>
        /// <param name="iv">初期化ベクトル</param>
        /// <param name="key">復号鍵</param>
        /// <returns>復号した平文</returns>
        private static string Decrypt(string cipher, byte[] iv, byte[] key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // ブロックサイズ
            aes.KeySize = 256; // 鍵長
            aes.Mode = CipherMode.CBC; // 暗号利用モード
            aes.Padding = PaddingMode.PKCS7; // パディング
            aes.IV = iv; // 初期化ベクトル
            aes.Key = key; // 復号鍵

            // 復号化
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream(Convert.FromBase64String(cipher));
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            using var sr = new StreamReader(cs);
            var plain = sr.ReadToEnd();

            return plain;
        }
    }
}