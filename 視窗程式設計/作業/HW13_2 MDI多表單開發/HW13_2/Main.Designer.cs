namespace HW13_2
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.遊戲種類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.猜拳遊戲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.掀牌比大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.遊戲種類ToolStripMenuItem,
            this.結束ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 遊戲種類ToolStripMenuItem
            // 
            this.遊戲種類ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.猜拳遊戲ToolStripMenuItem,
            this.掀牌比大小ToolStripMenuItem});
            this.遊戲種類ToolStripMenuItem.Name = "遊戲種類ToolStripMenuItem";
            this.遊戲種類ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.遊戲種類ToolStripMenuItem.Text = "遊戲種類";
            // 
            // 猜拳遊戲ToolStripMenuItem
            // 
            this.猜拳遊戲ToolStripMenuItem.Name = "猜拳遊戲ToolStripMenuItem";
            this.猜拳遊戲ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.猜拳遊戲ToolStripMenuItem.Text = "猜拳遊戲";
            this.猜拳遊戲ToolStripMenuItem.Click += new System.EventHandler(this.猜拳遊戲ToolStripMenuItem_Click);
            // 
            // 掀牌比大小ToolStripMenuItem
            // 
            this.掀牌比大小ToolStripMenuItem.Name = "掀牌比大小ToolStripMenuItem";
            this.掀牌比大小ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.掀牌比大小ToolStripMenuItem.Text = "掀牌比大小";
            this.掀牌比大小ToolStripMenuItem.Click += new System.EventHandler(this.掀牌比大小ToolStripMenuItem_Click);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.結束ToolStripMenuItem.Text = "結束";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 遊戲種類ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 猜拳遊戲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 掀牌比大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

