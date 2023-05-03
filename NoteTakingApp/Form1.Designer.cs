namespace NoteTakingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            BTNsave = new Button();
            BTNclear = new Button();
            BTNopen = new Button();
            label1 = new Label();
            btnsaveit = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(140, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(451, 614);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BTNsave
            // 
            BTNsave.Location = new Point(7, 12);
            BTNsave.Name = "BTNsave";
            BTNsave.Size = new Size(75, 23);
            BTNsave.TabIndex = 1;
            BTNsave.Text = "New Save";
            BTNsave.UseVisualStyleBackColor = true;
            BTNsave.Click += button1_Click;
            // 
            // BTNclear
            // 
            BTNclear.Location = new Point(7, 41);
            BTNclear.Name = "BTNclear";
            BTNclear.Size = new Size(75, 23);
            BTNclear.TabIndex = 2;
            BTNclear.Text = "Clear";
            BTNclear.UseVisualStyleBackColor = true;
            BTNclear.Click += BTNclear_Click;
            // 
            // BTNopen
            // 
            BTNopen.Location = new Point(7, 70);
            BTNopen.Name = "BTNopen";
            BTNopen.Size = new Size(75, 23);
            BTNopen.TabIndex = 3;
            BTNopen.Text = "Open File";
            BTNopen.UseVisualStyleBackColor = true;
            BTNopen.Click += BTNopen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, -20);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 4;
            // 
            // btnsaveit
            // 
            btnsaveit.Location = new Point(7, 99);
            btnsaveit.Name = "btnsaveit";
            btnsaveit.Size = new Size(118, 24);
            btnsaveit.TabIndex = 5;
            btnsaveit.Text = "Save to current file";
            btnsaveit.UseVisualStyleBackColor = true;
            btnsaveit.Visible = false;
            btnsaveit.Click += btnsaveit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(618, 714);
            Controls.Add(btnsaveit);
            Controls.Add(label1);
            Controls.Add(BTNopen);
            Controls.Add(BTNclear);
            Controls.Add(BTNsave);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "text file editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BTNsave;
        private Button BTNclear;
        private Button BTNopen;
        private Label label1;
        private Button btnsaveit;
    }
}