
namespace ConfigNetwork
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox AddresEthernet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox DNS1;
		private System.Windows.Forms.TextBox DNS2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox OldIP;
		private System.Windows.Forms.TextBox Gateway;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.AddresEthernet = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DNS1 = new System.Windows.Forms.TextBox();
			this.DNS2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.OldIP = new System.Windows.Forms.TextBox();
			this.Gateway = new System.Windows.Forms.TextBox();
			this.NumberARM = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NewIP = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.Mask = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Новый адрес сети";
			// 
			// AddresEthernet
			// 
			this.AddresEthernet.Location = new System.Drawing.Point(194, 42);
			this.AddresEthernet.Name = "AddresEthernet";
			this.AddresEthernet.Size = new System.Drawing.Size(204, 22);
			this.AddresEthernet.TabIndex = 1;
			this.AddresEthernet.Text = "192.168.0.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "DNS 1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "DNS 2";
			// 
			// DNS1
			// 
			this.DNS1.Location = new System.Drawing.Point(194, 169);
			this.DNS1.Name = "DNS1";
			this.DNS1.Size = new System.Drawing.Size(204, 22);
			this.DNS1.TabIndex = 6;
			this.DNS1.Text = "8.8.8.8";
			// 
			// DNS2
			// 
			this.DNS2.Location = new System.Drawing.Point(194, 197);
			this.DNS2.Name = "DNS2";
			this.DNS2.Size = new System.Drawing.Size(204, 22);
			this.DNS2.TabIndex = 7;
			this.DNS2.Text = "8.8.0.0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(14, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 29);
			this.button1.TabIndex = 10;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Текущий IP";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(11, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "Шлюз";
			// 
			// OldIP
			// 
			this.OldIP.Enabled = false;
			this.OldIP.Location = new System.Drawing.Point(194, 225);
			this.OldIP.Name = "OldIP";
			this.OldIP.Size = new System.Drawing.Size(204, 22);
			this.OldIP.TabIndex = 13;
			// 
			// Gateway
			// 
			this.Gateway.Location = new System.Drawing.Point(194, 106);
			this.Gateway.Name = "Gateway";
			this.Gateway.Size = new System.Drawing.Size(204, 22);
			this.Gateway.TabIndex = 14;
			// 
			// NumberARM
			// 
			this.NumberARM.Location = new System.Drawing.Point(194, 73);
			this.NumberARM.Name = "NumberARM";
			this.NumberARM.Size = new System.Drawing.Size(204, 22);
			this.NumberARM.TabIndex = 17;
			this.NumberARM.Text = "1";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(11, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(174, 23);
			this.label7.TabIndex = 18;
			this.label7.Text = "Начальный номер АРМ";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(14, 256);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Новый IP";
			// 
			// NewIP
			// 
			this.NewIP.Location = new System.Drawing.Point(194, 253);
			this.NewIP.Name = "NewIP";
			this.NewIP.Size = new System.Drawing.Size(204, 22);
			this.NewIP.TabIndex = 22;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(228, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(170, 29);
			this.button2.TabIndex = 23;
			this.button2.Text = "Удалить настройки";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(12, 135);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(152, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "Маска";
			// 
			// Mask
			// 
			this.Mask.Location = new System.Drawing.Point(194, 138);
			this.Mask.Name = "Mask";
			this.Mask.Size = new System.Drawing.Size(204, 22);
			this.Mask.TabIndex = 25;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(228, 292);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(170, 29);
			this.button3.TabIndex = 28;
			this.button3.Text = "Сохранить настройки";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.помощьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(410, 28);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// помощьToolStripMenuItem
			// 
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
			this.помощьToolStripMenuItem.Text = "О программе";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 384);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Mask);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.NewIP);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.NumberARM);
			this.Controls.Add(this.Gateway);
			this.Controls.Add(this.OldIP);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DNS2);
			this.Controls.Add(this.DNS1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddresEthernet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(428, 431);
			this.MinimumSize = new System.Drawing.Size(428, 431);
			this.Name = "MainForm";
			this.Text = "ConfigNetwork";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox Mask;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox NewIP;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox NumberARM;
	}
}
