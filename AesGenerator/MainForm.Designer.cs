namespace AesGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlain = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.lblIv = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.txtIv = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(244, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AES-Generator";
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlain.Location = new System.Drawing.Point(286, 83);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(207, 45);
            this.lblPlain.TabIndex = 0;
            this.lblPlain.Text = "テキストを入力";
            // 
            // txtPlain
            // 
            this.txtPlain.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlain.Location = new System.Drawing.Point(114, 131);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(550, 45);
            this.txtPlain.TabIndex = 1;
            // 
            // lblIv
            // 
            this.lblIv.AutoSize = true;
            this.lblIv.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIv.Location = new System.Drawing.Point(280, 179);
            this.lblIv.Name = "lblIv";
            this.lblIv.Size = new System.Drawing.Size(218, 45);
            this.lblIv.TabIndex = 0;
            this.lblIv.Text = "初期化ベクトル";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKey.Location = new System.Drawing.Point(331, 275);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(116, 45);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "暗号鍵";
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCipher.Location = new System.Drawing.Point(331, 371);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(116, 45);
            this.lblCipher.TabIndex = 0;
            this.lblCipher.Text = "暗号文";
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDecrypted.Location = new System.Drawing.Point(274, 467);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(231, 45);
            this.lblDecrypted.TabIndex = 0;
            this.lblDecrypted.Text = "復号したテキスト";
            // 
            // txtIv
            // 
            this.txtIv.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIv.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtIv.Location = new System.Drawing.Point(114, 227);
            this.txtIv.Name = "txtIv";
            this.txtIv.Size = new System.Drawing.Size(550, 45);
            this.txtIv.TabIndex = 2;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKey.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtKey.Location = new System.Drawing.Point(114, 323);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(550, 45);
            this.txtKey.TabIndex = 3;
            // 
            // txtCipher
            // 
            this.txtCipher.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCipher.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCipher.Location = new System.Drawing.Point(114, 419);
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(550, 45);
            this.txtCipher.TabIndex = 4;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDecrypted.Location = new System.Drawing.Point(114, 515);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(550, 45);
            this.txtDecrypted.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncrypt.Location = new System.Drawing.Point(394, 612);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(120, 70);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "暗号化";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDecrypt.Location = new System.Drawing.Point(520, 612);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(120, 70);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "復号化";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // btnGenKey
            // 
            this.btnGenKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenKey.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenKey.Location = new System.Drawing.Point(268, 612);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(120, 70);
            this.btnGenKey.TabIndex = 6;
            this.btnGenKey.Text = "鍵生成";
            this.btnGenKey.UseVisualStyleBackColor = true;
            this.btnGenKey.Click += new System.EventHandler(this.BtnGenKey_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(646, 612);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 70);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "消去";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 694);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtIv);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblIv);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 750);
            this.MinimumSize = new System.Drawing.Size(800, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES-Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblPlain;
        private TextBox txtPlain;
        private Label lblIv;
        private Label lblKey;
        private Label lblCipher;
        private Label lblDecrypted;
        private TextBox txtIv;
        private TextBox txtKey;
        private TextBox txtCipher;
        private TextBox txtDecrypted;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnGenKey;
        private Button btnClear;
    }
}