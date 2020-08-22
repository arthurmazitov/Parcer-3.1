namespace prcr
{
    partial class PrefsForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(364, 279);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.node_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выбрать все";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(382, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 30);
            this.button5.TabIndex = 6;
            this.button5.Text = "Очистить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(382, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "Выбрать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrefsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrefsForm";
            this.Text = "Дополнительные параметры";
            this.Load += new System.EventHandler(this.treeView1_AfterSelect);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}