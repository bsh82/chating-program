﻿namespace ChatClient

{

    partial class Form1

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtChatMsg = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "대화명";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 27);
            this.txtName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(337, 28);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(157, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "입장";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtChatMsg
            // 
            this.txtChatMsg.Location = new System.Drawing.Point(32, 89);
            this.txtChatMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChatMsg.Multiline = true;
            this.txtChatMsg.Name = "txtChatMsg";
            this.txtChatMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatMsg.Size = new System.Drawing.Size(460, 243);
            this.txtChatMsg.TabIndex = 3;
            this.txtChatMsg.TextChanged += new System.EventHandler(this.txtChatMsg_TextChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(35, 356);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(458, 27);
            this.txtMsg.TabIndex = 4;
            this.txtMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMsg_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 407);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtChatMsg);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private Label label1;

        private TextBox txtName;

        private Button btnConnect;

        private TextBox txtChatMsg;

        private TextBox txtMsg;

    }

}

