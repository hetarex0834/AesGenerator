using System.Security.Cryptography;
using System.Text;

namespace AesGenerator
{
    /// <summary>
    /// AES-256�Í���������������A�v��
    /// </summary>
    public partial class MainForm : Form
    {
        // �o�C�g�T�C�Y
        private static readonly int ivSize = 12; // �������x�N�g��
        private static readonly int keySize = 24; // �Í���

        public MainForm() => InitializeComponent();

        /// <summary>
        /// �Í����{�^��
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            // �������x�N�g��
            txtIv.Text = GenerateAes(ivSize);
            // �Í���
            txtKey.Text = GenerateAes(keySize);
            // �Í���
            txtCipher.Text = Encrypt(txtPlain.Text, txtIv.Text, txtKey.Text);
        }

        /// <summary>
        /// �������{�^��
        /// </summary>
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// AES�̎�������
        /// </summary>
        /// <param name="size">�o�C�g�T�C�Y</param>
        /// <returns>Base64�`���̕�����</returns>
        private static string GenerateAes(int size)
        {
            // ��������
            using var rng = RandomNumberGenerator.Create();
            var bytes = new byte[size];
            rng.GetBytes(bytes);

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// ������AES-256�ňÍ���
        /// </summary>
        /// <param name="plain">����</param>
        /// <param name="iv">�������x�N�g��</param>
        /// <param name="key">�Í���</param>
        /// <returns>�Í���</returns>
        private static string Encrypt(string plain, string iv, string key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // �u���b�N�T�C�Y
            aes.KeySize = 256; // ����
            aes.Mode = CipherMode.CBC; // �Í����p���[�h
            aes.Padding = PaddingMode.PKCS7; // �p�f�B���O
            aes.IV = Encoding.UTF8.GetBytes(iv); // �������x�N�g��
            aes.Key = Encoding.UTF8.GetBytes(key); // �Í���

            // �o�C�g�z��
            var byteText = Encoding.UTF8.GetBytes(plain);
            // �Í���
            var encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            return Convert.ToBase64String(encryptText);
        }
    }
}