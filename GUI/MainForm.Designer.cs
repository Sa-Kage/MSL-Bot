/*
 * Created by SharpDevelop.
 * Author: Sa'Kagé
 * Date: 05.02.2018
 * Time: 21:54
 */
namespace MSL_Bot.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label logLabel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button exportLogBtn;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.logLabel = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.exportLogBtn = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 29);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel3.Controls.Add(this.startButton);
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Location = new System.Drawing.Point(32, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(221, 29);
			this.panel3.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(130, 3);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(88, 23);
			this.startButton.TabIndex = 1;
			this.startButton.Text = "Skript starten";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Golem farmen",
			"Mons fangen",
			"Gems farmen"});
			this.comboBox1.Location = new System.Drawing.Point(3, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			//this.comboBox1.SelectedIndex = 0;	always discarded by designer
			this.comboBox1.SelectedIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.logLabel);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 29);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 29);
			this.panel2.TabIndex = 1;
			// 
			// logLabel
			// 
			this.logLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logLabel.Location = new System.Drawing.Point(0, 0);
			this.logLabel.Name = "logLabel";
			this.logLabel.Size = new System.Drawing.Size(186, 29);
			this.logLabel.TabIndex = 1;
			this.logLabel.Text = "Log";
			this.logLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.exportLogBtn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(186, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(98, 29);
			this.panel4.TabIndex = 0;
			// 
			// exportLogBtn
			// 
			this.exportLogBtn.Location = new System.Drawing.Point(3, 3);
			this.exportLogBtn.Name = "exportLogBtn";
			this.exportLogBtn.Size = new System.Drawing.Size(92, 23);
			this.exportLogBtn.TabIndex = 0;
			this.exportLogBtn.Text = "Log speichern";
			this.exportLogBtn.UseVisualStyleBackColor = true;
			this.exportLogBtn.Click += new System.EventHandler(this.ExportLogBtnClick);
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 58);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(284, 273);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 331);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MSL-Bot";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
