namespace SfSim.UI.Controls
{
	partial class SimCaseListItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.simCasePanel = new SfSim.UI.Controls.SimCasePanel();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(684, 3);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 1;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(684, 47);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// simCasePanel
			// 
			this.simCasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.simCasePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.simCasePanel.IsSelected = false;
			this.simCasePanel.Location = new System.Drawing.Point(3, 3);
			this.simCasePanel.Name = "simCasePanel";
			this.simCasePanel.Size = new System.Drawing.Size(675, 67);
			this.simCasePanel.TabIndex = 0;
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(685, 25);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(27, 23);
			this.btnUp.TabIndex = 3;
			this.btnUp.Text = "/\\";
			this.btnUp.UseVisualStyleBackColor = true;
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(732, 25);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(27, 23);
			this.btnDown.TabIndex = 4;
			this.btnDown.Text = "\\/";
			this.btnDown.UseVisualStyleBackColor = true;
			// 
			// SimCaseListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.simCasePanel);
			this.Name = "SimCaseListItem";
			this.Size = new System.Drawing.Size(765, 73);
			this.ResumeLayout(false);

		}

		#endregion

		private SimCasePanel simCasePanel;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
	}
}
