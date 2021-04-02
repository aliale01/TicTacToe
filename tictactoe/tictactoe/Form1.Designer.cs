namespace tictactoe
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.computerModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userVsUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.T1 = new System.Windows.Forms.Button();
			this.T2 = new System.Windows.Forms.Button();
			this.T3 = new System.Windows.Forms.Button();
			this.M1 = new System.Windows.Forms.Button();
			this.M2 = new System.Windows.Forms.Button();
			this.M3 = new System.Windows.Forms.Button();
			this.L1 = new System.Windows.Forms.Button();
			this.L2 = new System.Windows.Forms.Button();
			this.L3 = new System.Windows.Forms.Button();
			this.userVsPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.computerModeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(22, 7, 0, 7);
			this.menuStrip1.Size = new System.Drawing.Size(329, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitAltF4ToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.newGameToolStripMenuItem.Text = "New Game";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// exitAltF4ToolStripMenuItem
			// 
			this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
			this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.exitAltF4ToolStripMenuItem.Text = "Exit (Alt+F4)";
			this.exitAltF4ToolStripMenuItem.Click += new System.EventHandler(this.exitAltF4ToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// computerModeToolStripMenuItem
			// 
			this.computerModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userVsUserToolStripMenuItem,
            this.userVsPCToolStripMenuItem});
			this.computerModeToolStripMenuItem.Name = "computerModeToolStripMenuItem";
			this.computerModeToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
			this.computerModeToolStripMenuItem.Text = "Mode";
			// 
			// userVsUserToolStripMenuItem
			// 
			this.userVsUserToolStripMenuItem.Name = "userVsUserToolStripMenuItem";
			this.userVsUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.userVsUserToolStripMenuItem.Text = "User vs User ";
			this.userVsUserToolStripMenuItem.Click += new System.EventHandler(this.mode_user_vs_user);
			// 
			// T1
			// 
			this.T1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.T1.Location = new System.Drawing.Point(28, 80);
			this.T1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.T1.Name = "T1";
			this.T1.Size = new System.Drawing.Size(75, 75);
			this.T1.TabIndex = 1;
			this.T1.UseVisualStyleBackColor = true;
			this.T1.Click += new System.EventHandler(this.button_click);
			this.T1.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.T1.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// T2
			// 
			this.T2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.T2.Location = new System.Drawing.Point(125, 80);
			this.T2.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.T2.Name = "T2";
			this.T2.Size = new System.Drawing.Size(75, 75);
			this.T2.TabIndex = 2;
			this.T2.UseVisualStyleBackColor = true;
			this.T2.Click += new System.EventHandler(this.button_click);
			this.T2.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.T2.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// T3
			// 
			this.T3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.T3.Location = new System.Drawing.Point(222, 80);
			this.T3.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.T3.Name = "T3";
			this.T3.Size = new System.Drawing.Size(75, 75);
			this.T3.TabIndex = 3;
			this.T3.UseVisualStyleBackColor = true;
			this.T3.Click += new System.EventHandler(this.button_click);
			this.T3.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.T3.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// M1
			// 
			this.M1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.M1.Location = new System.Drawing.Point(28, 173);
			this.M1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.M1.Name = "M1";
			this.M1.Size = new System.Drawing.Size(75, 75);
			this.M1.TabIndex = 4;
			this.M1.UseVisualStyleBackColor = true;
			this.M1.Click += new System.EventHandler(this.button_click);
			this.M1.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.M1.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// M2
			// 
			this.M2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.M2.Location = new System.Drawing.Point(125, 173);
			this.M2.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.M2.Name = "M2";
			this.M2.Size = new System.Drawing.Size(75, 75);
			this.M2.TabIndex = 5;
			this.M2.UseVisualStyleBackColor = true;
			this.M2.Click += new System.EventHandler(this.button_click);
			this.M2.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.M2.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// M3
			// 
			this.M3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.M3.Location = new System.Drawing.Point(222, 173);
			this.M3.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.M3.Name = "M3";
			this.M3.Size = new System.Drawing.Size(75, 75);
			this.M3.TabIndex = 6;
			this.M3.UseVisualStyleBackColor = true;
			this.M3.Click += new System.EventHandler(this.button_click);
			this.M3.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.M3.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// L1
			// 
			this.L1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.L1.Location = new System.Drawing.Point(28, 260);
			this.L1.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(75, 75);
			this.L1.TabIndex = 7;
			this.L1.UseVisualStyleBackColor = true;
			this.L1.Click += new System.EventHandler(this.button_click);
			this.L1.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.L1.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// L2
			// 
			this.L2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.L2.Location = new System.Drawing.Point(125, 260);
			this.L2.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(75, 75);
			this.L2.TabIndex = 8;
			this.L2.UseVisualStyleBackColor = true;
			this.L2.Click += new System.EventHandler(this.button_click);
			this.L2.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.L2.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// L3
			// 
			this.L3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.L3.Location = new System.Drawing.Point(222, 260);
			this.L3.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(75, 75);
			this.L3.TabIndex = 9;
			this.L3.UseVisualStyleBackColor = true;
			this.L3.Click += new System.EventHandler(this.button_click);
			this.L3.MouseEnter += new System.EventHandler(this.mouse_enter);
			this.L3.MouseLeave += new System.EventHandler(this.mouse_leave);
			// 
			// userVsPCToolStripMenuItem
			// 
			this.userVsPCToolStripMenuItem.Name = "userVsPCToolStripMenuItem";
			this.userVsPCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.userVsPCToolStripMenuItem.Text = "User vs PC";
			this.userVsPCToolStripMenuItem.Click += new System.EventHandler(this.mode_user_vs_pc);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 362);
			this.Controls.Add(this.L3);
			this.Controls.Add(this.L2);
			this.Controls.Add(this.L1);
			this.Controls.Add(this.M3);
			this.Controls.Add(this.M2);
			this.Controls.Add(this.M1);
			this.Controls.Add(this.T3);
			this.Controls.Add(this.T2);
			this.Controls.Add(this.T1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tic Tac Toe by AniMount";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitAltF4ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button T1;
		private System.Windows.Forms.Button T2;
		private System.Windows.Forms.Button T3;
		private System.Windows.Forms.Button M1;
		private System.Windows.Forms.Button M2;
		private System.Windows.Forms.Button M3;
		private System.Windows.Forms.Button L1;
		private System.Windows.Forms.Button L2;
		private System.Windows.Forms.Button L3;
		private System.Windows.Forms.ToolStripMenuItem computerModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userVsUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userVsPCToolStripMenuItem;
	}
}

