namespace SfSim.UI
{
	partial class fSfSim2
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
			this.flpSimulations = new System.Windows.Forms.FlowLayoutPanel();
			this.btnStartSimulation = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// flpSimulations
			// 
			this.flpSimulations.AutoScroll = true;
			this.flpSimulations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpSimulations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpSimulations.Location = new System.Drawing.Point(12, 33);
			this.flpSimulations.Name = "flpSimulations";
			this.flpSimulations.Size = new System.Drawing.Size(708, 340);
			this.flpSimulations.TabIndex = 0;
			this.flpSimulations.WrapContents = false;
			// 
			// btnStartSimulation
			// 
			this.btnStartSimulation.Location = new System.Drawing.Point(645, 379);
			this.btnStartSimulation.Name = "btnStartSimulation";
			this.btnStartSimulation.Size = new System.Drawing.Size(75, 23);
			this.btnStartSimulation.TabIndex = 1;
			this.btnStartSimulation.Text = "Start";
			this.btnStartSimulation.UseVisualStyleBackColor = true;
			this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
			// 
			// fSfSim2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1364, 480);
			this.Controls.Add(this.btnStartSimulation);
			this.Controls.Add(this.flpSimulations);
			this.Name = "fSfSim2";
			this.Text = "SfSim2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpSimulations;
		private System.Windows.Forms.Button btnStartSimulation;
	}
}

