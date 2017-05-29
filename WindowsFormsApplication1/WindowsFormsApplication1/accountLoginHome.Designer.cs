namespace WindowsFormsApplication1
{
    partial class accountLoginHome
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1148, 377);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Red;
            this.EXIT.Location = new System.Drawing.Point(471, 422);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(214, 56);
            this.EXIT.TabIndex = 1;
            this.EXIT.Text = "Return to Logon Screen";
            this.EXIT.UseVisualStyleBackColor = false;
            // 
            // accountLoginHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 490);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.listView1);
            this.Name = "accountLoginHome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.accountLoginHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button EXIT;
    }
}