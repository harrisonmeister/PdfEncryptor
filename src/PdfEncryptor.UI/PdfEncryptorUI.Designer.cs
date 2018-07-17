namespace PdfEncryptor.UI
{
    partial class PdfEncryptorUI
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
            this.pdf_option_print = new System.Windows.Forms.CheckBox();
            this.inputpdf_path = new System.Windows.Forms.TextBox();
            this.label_inputpdf = new System.Windows.Forms.Label();
            this.label_outputpdf = new System.Windows.Forms.Label();
            this.outputpdf_path = new System.Windows.Forms.TextBox();
            this.output_folder_browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_output_folder = new System.Windows.Forms.Button();
            this.button_inputpdf_file = new System.Windows.Forms.Button();
            this.input_file_open_dialog = new System.Windows.Forms.OpenFileDialog();
            this.pdf_option_edit = new System.Windows.Forms.CheckBox();
            this.label_log_window = new System.Windows.Forms.Label();
            this.pdf_password = new System.Windows.Forms.TextBox();
            this.label_pdf_password = new System.Windows.Forms.Label();
            this.aes_encryption_level_128 = new System.Windows.Forms.RadioButton();
            this.aes_encryption_level_256 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pdf_option_assembly = new System.Windows.Forms.CheckBox();
            this.pdf_option_modify_annotations = new System.Windows.Forms.CheckBox();
            this.pdf_option_fillin = new System.Windows.Forms.CheckBox();
            this.pdf_option_copy = new System.Windows.Forms.CheckBox();
            this.encryption_options = new System.Windows.Forms.GroupBox();
            this.button_pdf_go = new System.Windows.Forms.Button();
            this.log_window = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.encryption_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdf_option_print
            // 
            this.pdf_option_print.AutoSize = true;
            this.pdf_option_print.Checked = true;
            this.pdf_option_print.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdf_option_print.Enabled = false;
            this.pdf_option_print.Location = new System.Drawing.Point(6, 19);
            this.pdf_option_print.Name = "pdf_option_print";
            this.pdf_option_print.Size = new System.Drawing.Size(74, 17);
            this.pdf_option_print.TabIndex = 0;
            this.pdf_option_print.Text = "Allow print";
            this.pdf_option_print.UseVisualStyleBackColor = true;
            // 
            // inputpdf_path
            // 
            this.inputpdf_path.Location = new System.Drawing.Point(12, 33);
            this.inputpdf_path.Name = "inputpdf_path";
            this.inputpdf_path.Size = new System.Drawing.Size(294, 20);
            this.inputpdf_path.TabIndex = 1;
            // 
            // label_inputpdf
            // 
            this.label_inputpdf.AutoSize = true;
            this.label_inputpdf.Location = new System.Drawing.Point(9, 17);
            this.label_inputpdf.Name = "label_inputpdf";
            this.label_inputpdf.Size = new System.Drawing.Size(95, 13);
            this.label_inputpdf.TabIndex = 2;
            this.label_inputpdf.Text = "Input PDF file path";
            // 
            // label_outputpdf
            // 
            this.label_outputpdf.AutoSize = true;
            this.label_outputpdf.Location = new System.Drawing.Point(9, 56);
            this.label_outputpdf.Name = "label_outputpdf";
            this.label_outputpdf.Size = new System.Drawing.Size(103, 13);
            this.label_outputpdf.TabIndex = 4;
            this.label_outputpdf.Text = "Output PDF file path";
            // 
            // outputpdf_path
            // 
            this.outputpdf_path.Location = new System.Drawing.Point(12, 75);
            this.outputpdf_path.Name = "outputpdf_path";
            this.outputpdf_path.Size = new System.Drawing.Size(294, 20);
            this.outputpdf_path.TabIndex = 3;
            // 
            // button_output_folder
            // 
            this.button_output_folder.Location = new System.Drawing.Point(313, 75);
            this.button_output_folder.Name = "button_output_folder";
            this.button_output_folder.Size = new System.Drawing.Size(29, 20);
            this.button_output_folder.TabIndex = 5;
            this.button_output_folder.Text = "...";
            this.button_output_folder.UseVisualStyleBackColor = true;
            this.button_output_folder.Click += new System.EventHandler(this.button_output_folder_Click);
            // 
            // button_inputpdf_file
            // 
            this.button_inputpdf_file.Location = new System.Drawing.Point(313, 33);
            this.button_inputpdf_file.Name = "button_inputpdf_file";
            this.button_inputpdf_file.Size = new System.Drawing.Size(29, 20);
            this.button_inputpdf_file.TabIndex = 6;
            this.button_inputpdf_file.Text = "...";
            this.button_inputpdf_file.UseVisualStyleBackColor = true;
            this.button_inputpdf_file.Click += new System.EventHandler(this.button_inputpdf_file_Click);
            // 
            // input_file_open_dialog
            // 
            this.input_file_open_dialog.DefaultExt = "pdf";
            this.input_file_open_dialog.Filter = "PDF files|*.pdf|All files|*.*";
            // 
            // pdf_option_edit
            // 
            this.pdf_option_edit.AutoSize = true;
            this.pdf_option_edit.Location = new System.Drawing.Point(6, 42);
            this.pdf_option_edit.Name = "pdf_option_edit";
            this.pdf_option_edit.Size = new System.Drawing.Size(71, 17);
            this.pdf_option_edit.TabIndex = 7;
            this.pdf_option_edit.Text = "Allow edit";
            this.pdf_option_edit.UseVisualStyleBackColor = true;
            // 
            // label_log_window
            // 
            this.label_log_window.AutoSize = true;
            this.label_log_window.Location = new System.Drawing.Point(12, 192);
            this.label_log_window.Name = "label_log_window";
            this.label_log_window.Size = new System.Drawing.Size(39, 13);
            this.label_log_window.TabIndex = 9;
            this.label_log_window.Text = "Output";
            // 
            // pdf_password
            // 
            this.pdf_password.Location = new System.Drawing.Point(12, 115);
            this.pdf_password.Name = "pdf_password";
            this.pdf_password.Size = new System.Drawing.Size(294, 20);
            this.pdf_password.TabIndex = 10;
            this.pdf_password.UseSystemPasswordChar = true;
            // 
            // label_pdf_password
            // 
            this.label_pdf_password.AutoSize = true;
            this.label_pdf_password.Location = new System.Drawing.Point(9, 99);
            this.label_pdf_password.Name = "label_pdf_password";
            this.label_pdf_password.Size = new System.Drawing.Size(77, 13);
            this.label_pdf_password.TabIndex = 11;
            this.label_pdf_password.Text = "PDF Password";
            // 
            // aes_encryption_level_128
            // 
            this.aes_encryption_level_128.AutoSize = true;
            this.aes_encryption_level_128.Location = new System.Drawing.Point(15, 20);
            this.aes_encryption_level_128.Name = "aes_encryption_level_128";
            this.aes_encryption_level_128.Size = new System.Drawing.Size(81, 17);
            this.aes_encryption_level_128.TabIndex = 12;
            this.aes_encryption_level_128.Text = "AES 128 bit";
            this.aes_encryption_level_128.UseVisualStyleBackColor = true;
            // 
            // aes_encryption_level_256
            // 
            this.aes_encryption_level_256.AutoSize = true;
            this.aes_encryption_level_256.Checked = true;
            this.aes_encryption_level_256.Location = new System.Drawing.Point(15, 43);
            this.aes_encryption_level_256.Name = "aes_encryption_level_256";
            this.aes_encryption_level_256.Size = new System.Drawing.Size(81, 17);
            this.aes_encryption_level_256.TabIndex = 13;
            this.aes_encryption_level_256.TabStop = true;
            this.aes_encryption_level_256.Text = "AES 256 bit";
            this.aes_encryption_level_256.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pdf_option_assembly);
            this.groupBox1.Controls.Add(this.pdf_option_modify_annotations);
            this.groupBox1.Controls.Add(this.pdf_option_fillin);
            this.groupBox1.Controls.Add(this.pdf_option_copy);
            this.groupBox1.Controls.Add(this.pdf_option_print);
            this.groupBox1.Controls.Add(this.pdf_option_edit);
            this.groupBox1.Location = new System.Drawing.Point(363, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 95);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PDF Options";
            // 
            // pdf_option_assembly
            // 
            this.pdf_option_assembly.AutoSize = true;
            this.pdf_option_assembly.Location = new System.Drawing.Point(86, 42);
            this.pdf_option_assembly.Name = "pdf_option_assembly";
            this.pdf_option_assembly.Size = new System.Drawing.Size(97, 17);
            this.pdf_option_assembly.TabIndex = 20;
            this.pdf_option_assembly.Text = "Allow assembly";
            this.pdf_option_assembly.UseVisualStyleBackColor = true;
            // 
            // pdf_option_modify_annotations
            // 
            this.pdf_option_modify_annotations.AutoSize = true;
            this.pdf_option_modify_annotations.Location = new System.Drawing.Point(86, 65);
            this.pdf_option_modify_annotations.Name = "pdf_option_modify_annotations";
            this.pdf_option_modify_annotations.Size = new System.Drawing.Size(109, 17);
            this.pdf_option_modify_annotations.TabIndex = 19;
            this.pdf_option_modify_annotations.Text = "Allow annotations";
            this.pdf_option_modify_annotations.UseVisualStyleBackColor = true;
            // 
            // pdf_option_fillin
            // 
            this.pdf_option_fillin.AutoSize = true;
            this.pdf_option_fillin.Location = new System.Drawing.Point(86, 19);
            this.pdf_option_fillin.Name = "pdf_option_fillin";
            this.pdf_option_fillin.Size = new System.Drawing.Size(74, 17);
            this.pdf_option_fillin.TabIndex = 9;
            this.pdf_option_fillin.Text = "Allow fill-in";
            this.pdf_option_fillin.UseVisualStyleBackColor = true;
            // 
            // pdf_option_copy
            // 
            this.pdf_option_copy.AutoSize = true;
            this.pdf_option_copy.Location = new System.Drawing.Point(6, 65);
            this.pdf_option_copy.Name = "pdf_option_copy";
            this.pdf_option_copy.Size = new System.Drawing.Size(77, 17);
            this.pdf_option_copy.TabIndex = 8;
            this.pdf_option_copy.Text = "Allow copy";
            this.pdf_option_copy.UseVisualStyleBackColor = true;
            // 
            // encryption_options
            // 
            this.encryption_options.Controls.Add(this.aes_encryption_level_128);
            this.encryption_options.Controls.Add(this.aes_encryption_level_256);
            this.encryption_options.Location = new System.Drawing.Point(363, 118);
            this.encryption_options.Name = "encryption_options";
            this.encryption_options.Size = new System.Drawing.Size(101, 76);
            this.encryption_options.TabIndex = 17;
            this.encryption_options.TabStop = false;
            this.encryption_options.Text = "Encryption ";
            // 
            // button_pdf_go
            // 
            this.button_pdf_go.Location = new System.Drawing.Point(470, 157);
            this.button_pdf_go.Name = "button_pdf_go";
            this.button_pdf_go.Size = new System.Drawing.Size(88, 37);
            this.button_pdf_go.TabIndex = 18;
            this.button_pdf_go.Text = "Protect PDF";
            this.button_pdf_go.UseVisualStyleBackColor = true;
            this.button_pdf_go.Click += new System.EventHandler(this.button_pdf_go_Click);
            // 
            // log_window
            // 
            this.log_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.log_window.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Message});
            this.log_window.Location = new System.Drawing.Point(15, 217);
            this.log_window.Name = "log_window";
            this.log_window.Size = new System.Drawing.Size(559, 221);
            this.log_window.TabIndex = 19;
            this.log_window.UseCompatibleStateImageBehavior = false;
            this.log_window.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 80;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 471;
            // 
            // PdfEncryptorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.log_window);
            this.Controls.Add(this.button_pdf_go);
            this.Controls.Add(this.encryption_options);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_pdf_password);
            this.Controls.Add(this.pdf_password);
            this.Controls.Add(this.label_log_window);
            this.Controls.Add(this.button_inputpdf_file);
            this.Controls.Add(this.button_output_folder);
            this.Controls.Add(this.label_outputpdf);
            this.Controls.Add(this.outputpdf_path);
            this.Controls.Add(this.label_inputpdf);
            this.Controls.Add(this.inputpdf_path);
            this.Name = "PdfEncryptorUI";
            this.Text = "Pdf Encryptor";
            this.Load += new System.EventHandler(this.PdfEncryptorUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.encryption_options.ResumeLayout(false);
            this.encryption_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pdf_option_print;
        private System.Windows.Forms.TextBox inputpdf_path;
        private System.Windows.Forms.Label label_inputpdf;
        private System.Windows.Forms.Label label_outputpdf;
        private System.Windows.Forms.TextBox outputpdf_path;
        private System.Windows.Forms.FolderBrowserDialog output_folder_browser_dialog;
        private System.Windows.Forms.Button button_output_folder;
        private System.Windows.Forms.Button button_inputpdf_file;
        private System.Windows.Forms.OpenFileDialog input_file_open_dialog;
        private System.Windows.Forms.CheckBox pdf_option_edit;
        private System.Windows.Forms.Label label_log_window;
        private System.Windows.Forms.TextBox pdf_password;
        private System.Windows.Forms.Label label_pdf_password;
        private System.Windows.Forms.RadioButton aes_encryption_level_128;
        private System.Windows.Forms.RadioButton aes_encryption_level_256;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox encryption_options;
        private System.Windows.Forms.Button button_pdf_go;
        private System.Windows.Forms.CheckBox pdf_option_copy;
        private System.Windows.Forms.CheckBox pdf_option_fillin;
        private System.Windows.Forms.CheckBox pdf_option_modify_annotations;
        private System.Windows.Forms.CheckBox pdf_option_assembly;
        private System.Windows.Forms.ListView log_window;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Message;
    }
}

