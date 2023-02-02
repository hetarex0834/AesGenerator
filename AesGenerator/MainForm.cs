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
        private static readonly int ivSize = 16; // �������x�N�g��
        private static readonly int keySize = 32; // �Í���

        public MainForm() => InitializeComponent();

        /// <summary>
        /// �������{�^��
        /// </summary>
        private void BtnGenKey_Click(object sender, EventArgs e)
        {
            // �������x�N�g��
            txtIv.Text = GenerateAes(12);
            // �Í���
            txtKey.Text = GenerateAes(24);
        }

        /// <summary>
        /// �Í����{�^��
        /// </summary>
        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // �������x�N�g��
                var iv = Encoding.UTF8.GetBytes(txtIv.Text);
                // �Í���
                var key = Encoding.UTF8.GetBytes(txtKey.Text);

                // �������`�F�b�N
                if (iv.Length != ivSize) throw new ArgumentException("�������x�N�g�����������ݒ肳��Ă��܂���B");
                if (key.Length != keySize) throw new ArgumentException("�Í������������ݒ肳��Ă��܂���B");

                // �Í���
                txtCipher.Text = Encrypt(txtPlain.Text, iv, key);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "�Í����G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("�Í����Ɏ��s���܂����B", "�Í����G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �������{�^��
        /// </summary>
        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // �������x�N�g��
                var iv = Encoding.UTF8.GetBytes(txtIv.Text);
                // �Í���
                var key = Encoding.UTF8.GetBytes(txtKey.Text);

                // �������`�F�b�N
                if (iv.Length != ivSize) throw new ArgumentException("�������x�N�g�����������ݒ肳��Ă��܂���B");
                if (key.Length != keySize) throw new ArgumentException("�Í������������ݒ肳��Ă��܂���B");

                // ������
                txtDecrypted.Text = Decrypt(txtCipher.Text, iv, key);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "�������G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("�������Ɏ��s���܂����B", "�������G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// �����{�^��
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtPlain.Text = string.Empty;
            txtIv.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtCipher.Text = string.Empty;
            txtDecrypted.Text = string.Empty;
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
        private static string Encrypt(string plain, byte[] iv, byte[] key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // �u���b�N�T�C�Y
            aes.KeySize = 256; // ����
            aes.Mode = CipherMode.CBC; // �Í����p���[�h
            aes.Padding = PaddingMode.PKCS7; // �p�f�B���O
            aes.IV = iv; // �������x�N�g��
            aes.Key = key; // �Í���

            // �Í���
            var byteText = Encoding.UTF8.GetBytes(plain);
            var cipher = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

            return Convert.ToBase64String(cipher);
        }

        /// <summary>
        /// �Í�����AES-256�ŕ�����
        /// </summary>
        /// <param name="cipher">�Í���</param>
        /// <param name="iv">�������x�N�g��</param>
        /// <param name="key">�Í���</param>
        /// <returns>������������</returns>
        private static string Decrypt(string cipher, byte[] iv, byte[] key)
        {
            // AES
            using var aes = Aes.Create();
            aes.BlockSize = 128; // �u���b�N�T�C�Y
            aes.KeySize = 256; // ����
            aes.Mode = CipherMode.CBC; // �Í����p���[�h
            aes.Padding = PaddingMode.PKCS7; // �p�f�B���O
            aes.IV = iv; // �������x�N�g��
            aes.Key = key; // �Í���

            // ������
            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using var ms = new MemoryStream(Convert.FromBase64String(cipher));
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            using var sr = new StreamReader(cs);
            var plain = sr.ReadToEnd();

            return plain;
        }
    }
}