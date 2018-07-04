namespace EncryptDecryptSample
{
    partial class frmEDSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_String_to_Encrypt = new System.Windows.Forms.Label();
            this.txt_String_to_Encrypt = new System.Windows.Forms.TextBox();
            this.lbl_Passcode = new System.Windows.Forms.Label();
            this.txt_PassPhrase = new System.Windows.Forms.TextBox();
            this.btn_Encrypt_It = new System.Windows.Forms.Button();
            this.btn_Decrypt_It = new System.Windows.Forms.Button();
            this.txt_Encrypted_String = new System.Windows.Forms.TextBox();
            this.lbl_Encrypted_String = new System.Windows.Forms.Label();
            this.txt_Str_Decrypted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Match_Status = new System.Windows.Forms.Label();
            this.btn_Clear_Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_String_to_Encrypt
            // 
            this.lbl_String_to_Encrypt.AutoSize = true;
            this.lbl_String_to_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_String_to_Encrypt.Location = new System.Drawing.Point(39, 106);
            this.lbl_String_to_Encrypt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_String_to_Encrypt.Name = "lbl_String_to_Encrypt";
            this.lbl_String_to_Encrypt.Size = new System.Drawing.Size(139, 20);
            this.lbl_String_to_Encrypt.TabIndex = 2;
            this.lbl_String_to_Encrypt.Text = "String to Encrypt:";
            // 
            // txt_String_to_Encrypt
            // 
            this.txt_String_to_Encrypt.Location = new System.Drawing.Point(185, 103);
            this.txt_String_to_Encrypt.Name = "txt_String_to_Encrypt";
            this.txt_String_to_Encrypt.Size = new System.Drawing.Size(637, 26);
            this.txt_String_to_Encrypt.TabIndex = 3;
            // 
            // lbl_Passcode
            // 
            this.lbl_Passcode.AutoSize = true;
            this.lbl_Passcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passcode.Location = new System.Drawing.Point(39, 59);
            this.lbl_Passcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Passcode.Name = "lbl_Passcode";
            this.lbl_Passcode.Size = new System.Drawing.Size(105, 20);
            this.lbl_Passcode.TabIndex = 0;
            this.lbl_Passcode.Text = "PassPhrase:";
            // 
            // txt_PassPhrase
            // 
            this.txt_PassPhrase.Location = new System.Drawing.Point(185, 56);
            this.txt_PassPhrase.Name = "txt_PassPhrase";
            this.txt_PassPhrase.Size = new System.Drawing.Size(433, 26);
            this.txt_PassPhrase.TabIndex = 1;
            // 
            // btn_Encrypt_It
            // 
            this.btn_Encrypt_It.Location = new System.Drawing.Point(672, 135);
            this.btn_Encrypt_It.Name = "btn_Encrypt_It";
            this.btn_Encrypt_It.Size = new System.Drawing.Size(150, 27);
            this.btn_Encrypt_It.TabIndex = 4;
            this.btn_Encrypt_It.Text = "Encrypt It";
            this.btn_Encrypt_It.UseVisualStyleBackColor = true;
            this.btn_Encrypt_It.Click += new System.EventHandler(this.btn_Encrypt_It_Click);
            // 
            // btn_Decrypt_It
            // 
            this.btn_Decrypt_It.Location = new System.Drawing.Point(672, 215);
            this.btn_Decrypt_It.Name = "btn_Decrypt_It";
            this.btn_Decrypt_It.Size = new System.Drawing.Size(150, 27);
            this.btn_Decrypt_It.TabIndex = 7;
            this.btn_Decrypt_It.Text = "Decrypt It";
            this.btn_Decrypt_It.UseVisualStyleBackColor = true;
            this.btn_Decrypt_It.Click += new System.EventHandler(this.btn_Decrypt_It_Click);
            // 
            // txt_Encrypted_String
            // 
            this.txt_Encrypted_String.Location = new System.Drawing.Point(185, 183);
            this.txt_Encrypted_String.Name = "txt_Encrypted_String";
            this.txt_Encrypted_String.Size = new System.Drawing.Size(637, 26);
            this.txt_Encrypted_String.TabIndex = 6;
            // 
            // lbl_Encrypted_String
            // 
            this.lbl_Encrypted_String.AutoSize = true;
            this.lbl_Encrypted_String.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Encrypted_String.Location = new System.Drawing.Point(39, 186);
            this.lbl_Encrypted_String.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Encrypted_String.Name = "lbl_Encrypted_String";
            this.lbl_Encrypted_String.Size = new System.Drawing.Size(138, 20);
            this.lbl_Encrypted_String.TabIndex = 5;
            this.lbl_Encrypted_String.Text = "Encrypted String:";
            // 
            // txt_Str_Decrypted
            // 
            this.txt_Str_Decrypted.Location = new System.Drawing.Point(185, 264);
            this.txt_Str_Decrypted.Name = "txt_Str_Decrypted";
            this.txt_Str_Decrypted.Size = new System.Drawing.Size(637, 26);
            this.txt_Str_Decrypted.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decrypted String:";
            // 
            // lbl_Match_Status
            // 
            this.lbl_Match_Status.AutoSize = true;
            this.lbl_Match_Status.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Match_Status.Location = new System.Drawing.Point(185, 297);
            this.lbl_Match_Status.Name = "lbl_Match_Status";
            this.lbl_Match_Status.Size = new System.Drawing.Size(90, 20);
            this.lbl_Match_Status.TabIndex = 10;
            this.lbl_Match_Status.Text = "The Result";
            // 
            // btn_Clear_Form
            // 
            this.btn_Clear_Form.Location = new System.Drawing.Point(672, 21);
            this.btn_Clear_Form.Name = "btn_Clear_Form";
            this.btn_Clear_Form.Size = new System.Drawing.Size(150, 26);
            this.btn_Clear_Form.TabIndex = 11;
            this.btn_Clear_Form.Text = "Clear Form";
            this.btn_Clear_Form.UseVisualStyleBackColor = true;
            this.btn_Clear_Form.Click += new System.EventHandler(this.btn_Clear_Form_Click);
            // 
            // frmEDSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 358);
            this.Controls.Add(this.btn_Clear_Form);
            this.Controls.Add(this.lbl_Match_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Str_Decrypted);
            this.Controls.Add(this.btn_Decrypt_It);
            this.Controls.Add(this.txt_Encrypted_String);
            this.Controls.Add(this.lbl_Encrypted_String);
            this.Controls.Add(this.btn_Encrypt_It);
            this.Controls.Add(this.txt_PassPhrase);
            this.Controls.Add(this.lbl_Passcode);
            this.Controls.Add(this.txt_String_to_Encrypt);
            this.Controls.Add(this.lbl_String_to_Encrypt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEDSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption and Decryption Sample";
            this.Load += new System.EventHandler(this.frmEDSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_String_to_Encrypt;
        private System.Windows.Forms.TextBox txt_String_to_Encrypt;
        private System.Windows.Forms.Label lbl_Passcode;
        private System.Windows.Forms.TextBox txt_PassPhrase;
        private System.Windows.Forms.Button btn_Encrypt_It;
        private System.Windows.Forms.Button btn_Decrypt_It;
        private System.Windows.Forms.TextBox txt_Encrypted_String;
        private System.Windows.Forms.Label lbl_Encrypted_String;
        private System.Windows.Forms.TextBox txt_Str_Decrypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Match_Status;
        private System.Windows.Forms.Button btn_Clear_Form;
    }
}

