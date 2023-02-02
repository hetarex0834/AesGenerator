using System.Security.Cryptography;

namespace AesGenerator
{
    /// <summary>
    /// AES-256�Í�����������������A�v��
    /// </summary>
    public partial class MainForm : Form
    {
        // �������x�N�g��
        private static readonly int iv = 12;
        // �Í���
        private static readonly int key = 24;

        public MainForm() => InitializeComponent();

        /// <summary>
        /// �Í����{�^��
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            // �������x�N�g��
            txtIv.Text = GenerateAes(iv);
            // �Í���
            txtKey.Text = GenerateAes(key);
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
        /// <param name="size">�T�C�Y</param>
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