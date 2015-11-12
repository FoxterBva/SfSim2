using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SfSim.Model.Classes;
using SfSim.UI.Controls;

namespace SfSim.UI
{
	public partial class fSfSim2 : Form
	{
		List<SimulationCase> simCases;

		public fSfSim2()
		{
			InitializeComponent();
			StartTest();
		}

		#region TEST/Debug

		void StartTest()
		{
			flpSimulations.Controls.Clear();

			simCases = new List<SimulationCase>() { 
				new SimulationCase() { Name = "Sim 1", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 2", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 3", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 4", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 5", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 6", IterationCount = 10 },
				new SimulationCase() { Name = "Sim 7", IterationCount = 10 }
			};

			foreach (var simCase in simCases)
			{
				var simPanel = new SimCasePanel();
				simPanel.SetValues(simCase);
				simPanel.Width = flpSimulations.Width - 25;
				flpSimulations.Controls.Add(simPanel);
			}
		}

		void TestSimulation(SimCasePanel panel)
		{
			int maxIterations = 30000;
			double percentDelta = 1;
			double prevPercent = 0;

			for (int i = 0; i < maxIterations; i++)
			{
				for (int j = 0; j < 50000; j++)
				{
					int a = i + j;
				}

				if (i * 100 / maxIterations - prevPercent > percentDelta)
				{
					prevPercent = i * 100 / maxIterations;

					panel.RefreshProgress(prevPercent);
				}
			}
			panel.RefreshProgress(100);
		}

		#endregion

		private void btnStartSimulation_Click(object sender, EventArgs e)
		{
			foreach (var simPanel in flpSimulations.Controls)
			{
				if (simPanel is SimCasePanel)
				{
					(simPanel as SimCasePanel).RefreshProgress(0);
				}
			}

			foreach (var simPanel in flpSimulations.Controls)
			{
				if (simPanel is SimCasePanel)
				{
					if ((simPanel as SimCasePanel).IsSelected)
					{ 
						// Starts simulation
						TestSimulation(simPanel as SimCasePanel);
					}
				}
			}

			MessageBox.Show("Completed!");
		}
	}
}