// ***********************************************************************
// Assembly         : EncryptDecryptSample
// Author           : Craig Wiley
// Created          : 06-16-2018
//
// Last Modified By : m_c_w
// Last Modified On : 06-16-2018
// ***********************************************************************
// <copyright file="frmEDSample.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Windows.Forms;

namespace EncryptDecryptSample
{
    /// <summary>
    /// Class frmEDSample.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmEDSample : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmEDSample"/> class.
        /// </summary>
        public frmEDSample()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmEDSample control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmEDSample_Load(object sender, EventArgs e)
        {
            txt_PassPhrase.Select();
        }

        /// <summary>
        /// Handles the Click event of the btn_Encrypt_It control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Encrypt_It_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_PassPhrase.Text))
            {
                if (!string.IsNullOrEmpty(txt_String_to_Encrypt.Text))
                {
                    txt_Encrypted_String.Text = clsEDS.EncryptString(txt_String_to_Encrypt.Text, txt_PassPhrase.Text);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_Decrypt_It control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Decrypt_It_Click(object sender, EventArgs e)
        {
            string sStrDecrypted = clsEDS.DecryptString(txt_Encrypted_String.Text, txt_PassPhrase.Text);
            txt_Str_Decrypted.Text = clsEDS.DecryptString(txt_Encrypted_String.Text, txt_PassPhrase.Text);

            if (txt_String_to_Encrypt.Text == txt_Str_Decrypted.Text)
            {
                lbl_Match_Status.Text = "They Match";
                lbl_Match_Status.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                lbl_Match_Status.Text = "They DON'T Match";
                lbl_Match_Status.ForeColor = System.Drawing.Color.Red;
            }

        }

        /// <summary>
        /// Handles the Click event of the btn_Clear_Form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Clear_Form_Click(object sender, EventArgs e)
        {
            txt_PassPhrase.Text = "";
            txt_String_to_Encrypt.Text = "";
            txt_Encrypted_String.Text = "";
            txt_Str_Decrypted.Text = "";
            lbl_Match_Status.Text = "The Result";
            lbl_Match_Status.ForeColor = System.Drawing.Color.LightGray;
        }
    }
}
