/*
    This file is part of the PdfEncryptor.UI, providing a user-friendly
    interface to encrypting pdfs, utilizing the iTextSharp PDF library.
    Copyright (c) 2018 Mark Harrison.
    Contact via https://github.com/harrisonmeister/PdfEncryptor/issues

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program. If not, see <http://www.gnu.org/licenses/>

    This library makes use of the iTextSharp PDF library.
    See http://itextpdf.com/terms-of-use/ for their license information.
 */

using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.exceptions;
using iTextSharp.text.pdf;
using System.Drawing;

namespace PdfEncryptor.UI
{
    public partial class PdfEncryptorUI : Form
    {
        public PdfEncryptorUI()
        {
            InitializeComponent();
        }

        private void button_output_folder_Click(object sender, EventArgs e)
        {
            DialogResult result = output_folder_browser_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = output_folder_browser_dialog.SelectedPath;

                if (!string.IsNullOrWhiteSpace(inputpdf_path.Text) && File.Exists(inputpdf_path.Text))
                {
                    var inputNoExt = Path.GetFileNameWithoutExtension(inputpdf_path.Text);
                    var output = Path.Combine(path, inputNoExt + ".pdf");
                    if (output.Equals(inputpdf_path.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Log($"Input filename cannot be same as output filename. Automatically changing..");
                        output = Path.Combine(path, inputNoExt + $"-protected.pdf");
                    }
                    outputpdf_path.Text = output;
                }
                else
                {
                    outputpdf_path.Text = Path.Combine(path, $"PdfEncryptor-{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.pdf");
                    Log($"Output filename auto-generated", false);
                }
            }
        }

        private void button_inputpdf_file_Click(object sender, EventArgs e)
        {
            DialogResult result = input_file_open_dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputpdf_path.Text = input_file_open_dialog.FileName;
                if (string.IsNullOrWhiteSpace(outputpdf_path.Text))
                {
                    var inputNoExt = Path.GetFileNameWithoutExtension(inputpdf_path.Text);
                    var output = Path.Combine(Path.GetDirectoryName(inputpdf_path.Text), inputNoExt + "-protected.pdf");
                    outputpdf_path.Text = output;
                    Log($"Output filename auto-generated from input filename", false);
                }
            }
        }

        private void PdfEncryptorUI_Load(object sender, EventArgs e)
        {
            // Re-load settings from Config
            var appSettings = System.Configuration.ConfigurationManager.AppSettings;

            var allowEdit = appSettings["AllowEdit"];
            if (!string.IsNullOrWhiteSpace(allowEdit))
            {
                var parse = bool.TryParse(allowEdit, out var result);
                pdf_option_edit.Checked = parse && result;
            }

            var allowCopy = appSettings["AllowCopy"];
            if (!string.IsNullOrWhiteSpace(allowCopy))
            {
                var parse = bool.TryParse(allowCopy, out var result);
                pdf_option_copy.Checked = parse && result;
            }

            var allowFillIn = appSettings["AllowFillIn"];
            if (!string.IsNullOrWhiteSpace(allowFillIn))
            {
                var parse = bool.TryParse(allowFillIn, out var result);
                pdf_option_fillin.Checked = parse && result;
            }

            var allowAssembly = appSettings["AllowAssembly"];
            if (!string.IsNullOrWhiteSpace(allowAssembly))
            {
                var parse = bool.TryParse(allowAssembly, out var result);
                pdf_option_assembly.Checked = parse && result;
            }

            var allowAnnotation = appSettings["AllowAnnotations"];
            if (!string.IsNullOrWhiteSpace(allowAnnotation))
            {
                var parse = bool.TryParse(allowAnnotation, out var result);
                pdf_option_modify_annotations.Checked = parse && result;
            }

            var aes256 = appSettings["Encryption_AES256"];
            if (!string.IsNullOrWhiteSpace(aes256))
            {
                var parse = bool.TryParse(aes256, out var result);
                aes_encryption_level_256.Checked = parse && result;
            }

            var input = appSettings["input_file"];
            if (!string.IsNullOrWhiteSpace(input))
            {
                inputpdf_path.Text = input;
            }

            var outputFolder = appSettings["input_file"];
            if (!string.IsNullOrWhiteSpace(input))
            {
                inputpdf_path.Text = input;
            }
        }

        private void button_pdf_go_Click(object sender, EventArgs e)
        {
            PdfReader pdfReader = null;

            if (string.IsNullOrWhiteSpace(inputpdf_path.Text))
            {
                Log($"input filename is empty", true);
                return;
            }

            if (string.IsNullOrWhiteSpace(outputpdf_path.Text))
            {
                Log($"output filename is empty", true);
                return;
            }

            if (!outputpdf_path.Text.EndsWith("pdf", StringComparison.InvariantCultureIgnoreCase))
            {
                Log($"output filename doesnt end in \".pdf\"", true);
                return;
            }

            if (outputpdf_path.Text.Equals(inputpdf_path.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                Log($"Input filename cannot be same as output filename", true);
                return;
            }

            if (!File.Exists(inputpdf_path.Text))
            {
                Log($"input file cant be found", true);
                return;
            }

            if (File.Exists(outputpdf_path.Text))
            {
                Log($"output filename already exists, contents will be overwritten", false);
            }

            var file = Path.GetFileName(inputpdf_path.Text);

            try
            {
                pdfReader = new PdfReader(inputpdf_path.Text);
            }
            catch (BadPasswordException)
            {
                Log($"File: {file} already encrypted, skipping protection", false);
                return;
            }

            if (string.IsNullOrWhiteSpace(pdf_password.Text))
            {
                Log($"No password chosen!", true);
                return;
            }

            try
            {
                int permissions = PdfWriter.AllowDegradedPrinting | PdfWriter.AllowPrinting | PdfWriter.AllowScreenReaders;

                if (pdf_option_edit.Checked)
                {
                    permissions = permissions | PdfWriter.AllowModifyContents;
                }

                if (pdf_option_copy.Checked)
                {
                    permissions = permissions | PdfWriter.AllowCopy;
                }

                if (pdf_option_fillin.Checked)
                {
                    permissions = permissions | PdfWriter.AllowFillIn;
                }

                if (pdf_option_modify_annotations.Checked)
                {
                    permissions = permissions | PdfWriter.AllowModifyAnnotations;
                }

                if (pdf_option_assembly.Checked)
                {
                    permissions = permissions | PdfWriter.AllowAssembly;
                }

                int encryption = PdfWriter.ENCRYPTION_AES_128;

                if (aes_encryption_level_256.Checked)
                {
                    encryption = PdfWriter.ENCRYPTION_AES_256;
                }

                // Encrypt
                using (Stream output = new FileStream(outputpdf_path.Text, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    iTextSharp.text.pdf.PdfEncryptor.Encrypt(pdfReader, output, encryption, pdf_password.Text, null, permissions);
                }
                Log($"Password protected: {inputpdf_path.Text} to file: {outputpdf_path.Text}");
            }
            catch (Exception ex)
            {
                Log($"Error generating file: {Path.GetFileName(outputpdf_path.Text)} - {ex.Message}", true);
            }
        }

        private void Log(string message, bool isError = false)
        {
            var lvi = new ListViewItem();
            var subItem = new ListViewItem.ListViewSubItem();

            if (isError)
            {
                lvi.ForeColor = Color.PaleVioletRed;
                subItem.ForeColor = Color.PaleVioletRed;
            }

            lvi.Text = DateTime.Now.ToString("HH:mm:ss.fff");
            subItem.Text = message;

            lvi.SubItems.Add(subItem);
            lvi.ToolTipText = message;

            log_window.Items.Insert(0, lvi);
        }
    }
}
