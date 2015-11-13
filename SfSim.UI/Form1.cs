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
				new SimulationCase() { Name = "Sim 3", IterationCount = 10 }
			};

			foreach (var simCase in simCases)
			{
				CreateSimCaseListItem(simCase);
			}
		}

		void simPanelItem_OnDelete(object sender, EventArgs e)
		{
			flpSimulations.Controls.Remove(sender as SimCaseListItem);
		}

		void simPanelItem_OnCopy(object sender, SimCaseEventArgs e)
		{
			CreateSimCaseListItem(e.SimCase);
		}

		void CreateSimCaseListItem(SimulationCase simCase)
		{
			var simPanelItem = new SimCaseListItem();
			simPanelItem.SimCasePanel.SetValues(simCase);
			simPanelItem.OnCopy += new SimCaseEventHandler(simPanelItem_OnCopy);
			simPanelItem.OnDelete += new EventHandler(simPanelItem_OnDelete);
			flpSimulations.Controls.Add(simPanelItem);
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
			panel.RefreshSimResult(new SimulationResult() { AvrgDps = 32754.34, MaxDps = 39541.61, MinDps = 25198.92 });
		}

		#endregion

		private void btnStartSimulation_Click(object sender, EventArgs e)
		{
			// Clear progress
			foreach (var simListItem in flpSimulations.Controls)
			{
				if (simListItem is SimCaseListItem)
				{
					(simListItem as SimCaseListItem).SimCasePanel.ResetDisplayedResult();
				}
			}

			// Start processing
			foreach (var simListItem in flpSimulations.Controls)
			{
				if (simListItem is SimCaseListItem)
				{
					if ((simListItem as SimCaseListItem).SimCasePanel.IsSelected)
					{ 
						// Starts simulation
						TestSimulation((simListItem as SimCaseListItem).SimCasePanel);
					}
				}
			}

			MessageBox.Show("Completed!");
		}

		private void btnAddSimCase_Click(object sender, EventArgs e)
		{
			CreateSimCaseListItem(new SimulationCase());
		}
	}
}