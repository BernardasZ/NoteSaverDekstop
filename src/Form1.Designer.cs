namespace NoteSaver
{
	partial class Form1
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_next = new System.Windows.Forms.Button();
			this.button_previous = new System.Windows.Forms.Button();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.AcceptsTab = true;
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.EnableAutoDragDrop = true;
			this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.richTextBox1.Location = new System.Drawing.Point(71, 29);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(864, 507);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			this.richTextBox1.WordWrap = false;
			this.richTextBox1.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
			this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(0, 513);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
			this.splitContainer1.Panel2.Controls.Add(this.button_previous);
			this.splitContainer1.Panel2.Controls.Add(this.button_next);
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
			this.splitContainer1.Size = new System.Drawing.Size(1152, 536);
			this.splitContainer1.SplitterDistance = 210;
			this.splitContainer1.TabIndex = 3;
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.treeView1.ItemHeight = 20;
			this.treeView1.Location = new System.Drawing.Point(4, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(203, 504);
			this.treeView1.TabIndex = 3;
			this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
			this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
			this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
			this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(71, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(702, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// button_next
			// 
			this.button_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_next.Location = new System.Drawing.Point(860, 3);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(75, 20);
			this.button_next.TabIndex = 3;
			this.button_next.Text = "Next";
			this.button_next.UseVisualStyleBackColor = true;
			// 
			// button_previous
			// 
			this.button_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_previous.Location = new System.Drawing.Point(779, 3);
			this.button_previous.Name = "button_previous";
			this.button_previous.Size = new System.Drawing.Size(75, 20);
			this.button_previous.TabIndex = 4;
			this.button_previous.Text = "Previous";
			this.button_previous.UseVisualStyleBackColor = true;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Enabled = false;
			this.richTextBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox2.Location = new System.Drawing.Point(3, 29);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox2.Size = new System.Drawing.Size(69, 507);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 560);
			this.Controls.Add(this.splitContainer1);
			this.MinimumSize = new System.Drawing.Size(900, 400);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_previous;
		private System.Windows.Forms.Button button_next;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}

