namespace SfSim.UI.Controls
{
	partial class SimCasePanel
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
			this.cbIsSelected = new System.Windows.Forms.CheckBox();
			this.lblSimName = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblMinDps = new System.Windows.Forms.Label();
			this.lblMaxDps = new System.Windows.Forms.Label();
			this.lblAvrgDps = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbIsSelected
			// 
			this.cbIsSelected.AutoSize = true;
			this.cbIsSelected.Location = new System.Drawing.Point(3, 3);
			this.cbIsSelected.Name = "cbIsSelected";
			this.cbIsSelected.Size = new System.Drawing.Size(15, 14);
			this.cbIsSelected.TabIndex = 0;
			this.cbIsSelected.UseVisualStyleBackColor = true;
			this.cbIsSelected.CheckedChanged += new System.EventHandler(this.cbIsSelected_CheckedChanged);
			// 
			// lblSimName
			// 
			this.lblSimName.AutoSize = true;
			this.lblSimName.Location = new System.Drawing.Point(62, 3);
			this.lblSimName.Name = "lblSimName";
			this.lblSimName.Size = new System.Drawing.Size(52, 13);
			this.lblSimName.TabIndex = 1;
			this.lblSimName.Text = "SimName";
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(19, 3);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "Status";
			// 
			// lblMinDps
			// 
			this.lblMinDps.AutoSize = true;
			this.lblMinDps.Location = new System.Drawing.Point(598, 4);
			this.lblMinDps.Name = "lblMinDps";
			this.lblMinDps.Size = new System.Drawing.Size(43, 13);
			this.lblMinDps.TabIndex = 3;
			this.lblMinDps.Text = "MinDps";
			// 
			// lblMaxDps
			// 
			this.lblMaxDps.AutoSize = true;
			this.lblMaxDps.Location = new System.Drawing.Point(598, 22);
			this.lblMaxDps.Name = "lblMaxDps";
			this.lblMaxDps.Size = new System.Drawing.Size(46, 13);
			this.lblMaxDps.TabIndex = 4;
			this.lblMaxDps.Text = "MaxDps";
			// 
			// lblAvrgDps
			// 
			this.lblAvrgDps.AutoSize = true;
			this.lblAvrgDps.Location = new System.Drawing.Point(598, 41);
			this.lblAvrgDps.Name = "lblAvrgDps";
			this.lblAvrgDps.Size = new System.Drawing.Size(48, 13);
			this.lblAvrgDps.TabIndex = 5;
			this.lblAvrgDps.Text = "AvrgDps";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(484, 41);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// SimCasePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lblAvrgDps);
			this.Controls.Add(this.lblMaxDps);
			this.Controls.Add(this.lblMinDps);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblSimName);
			this.Controls.Add(this.cbIsSelected);
			this.Name = "SimCasePanel";
			this.Size = new System.Drawing.Size(675, 67);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbIsSelected;
		private System.Windows.Forms.Label lblSimName;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label lblMinDps;
		private System.Windows.Forms.Label lblMaxDps;
		private System.Windows.Forms.Label lblAvrgDps;
		private System.Windows.Forms.Button btnEdit;
	}
}
