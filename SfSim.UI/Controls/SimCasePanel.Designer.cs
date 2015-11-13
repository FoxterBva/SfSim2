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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTalents = new System.Windows.Forms.Label();
			this.lblSymbols = new System.Windows.Forms.Label();
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
			this.lblSimName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSimName.Location = new System.Drawing.Point(62, 3);
			this.lblSimName.Name = "lblSimName";
			this.lblSimName.Size = new System.Drawing.Size(59, 13);
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
			this.lblMinDps.Location = new System.Drawing.Point(518, 4);
			this.lblMinDps.Name = "lblMinDps";
			this.lblMinDps.Size = new System.Drawing.Size(43, 13);
			this.lblMinDps.TabIndex = 3;
			this.lblMinDps.Text = "MinDps";
			// 
			// lblMaxDps
			// 
			this.lblMaxDps.AutoSize = true;
			this.lblMaxDps.Location = new System.Drawing.Point(518, 21);
			this.lblMaxDps.Name = "lblMaxDps";
			this.lblMaxDps.Size = new System.Drawing.Size(46, 13);
			this.lblMaxDps.TabIndex = 4;
			this.lblMaxDps.Text = "MaxDps";
			// 
			// lblAvrgDps
			// 
			this.lblAvrgDps.AutoSize = true;
			this.lblAvrgDps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAvrgDps.Location = new System.Drawing.Point(593, 4);
			this.lblAvrgDps.Name = "lblAvrgDps";
			this.lblAvrgDps.Size = new System.Drawing.Size(69, 17);
			this.lblAvrgDps.TabIndex = 5;
			this.lblAvrgDps.Text = "AvrgDps";
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(596, 39);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Symbols";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Talents";
			// 
			// lblTalents
			// 
			this.lblTalents.AutoSize = true;
			this.lblTalents.Location = new System.Drawing.Point(52, 33);
			this.lblTalents.Name = "lblTalents";
			this.lblTalents.Size = new System.Drawing.Size(13, 13);
			this.lblTalents.TabIndex = 9;
			this.lblTalents.Text = "--";
			// 
			// lblSymbols
			// 
			this.lblSymbols.AutoSize = true;
			this.lblSymbols.Location = new System.Drawing.Point(52, 49);
			this.lblSymbols.Name = "lblSymbols";
			this.lblSymbols.Size = new System.Drawing.Size(13, 13);
			this.lblSymbols.TabIndex = 10;
			this.lblSymbols.Text = "--";
			// 
			// SimCasePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.lblSymbols);
			this.Controls.Add(this.lblTalents);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTalents;
		private System.Windows.Forms.Label lblSymbols;
	}
}
