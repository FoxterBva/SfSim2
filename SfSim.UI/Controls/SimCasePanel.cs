using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SfSim.Model.Classes;

namespace SfSim.UI.Controls
{
	public partial class SimCasePanel : UserControl
	{
		SimulationCase simCase;

		public SimCasePanel()
		{
			InitializeComponent();
		}

		public void SetValues(SimulationCase simCase)
		{
			this.simCase = simCase;

			lblSimName.Text = simCase.Name;
			lblTalents.Text = simCase.TalentsStr;
			lblSymbols.Text = simCase.SymbolsStr;

			SetColor();
		}

		public SimulationCase GetValues()
		{
			return simCase;
		}

		public void RefreshProgress(double percent)
		{
			lblStatus.Text = percent + "%";
			lblStatus.Refresh();
		}

		public void RefreshSimResult(SimulationResult res)
		{
			lblMinDps.Text = res.MinDps.ToString();
			lblMaxDps.Text = res.MaxDps.ToString();
			lblAvrgDps.Text = res.AvrgDps.ToString();

			lblMinDps.Refresh();
			lblMaxDps.Refresh();
			lblAvrgDps.Refresh();
		}

		public void ResetDisplayedResult()
		{
			lblStatus.Text = "status";
			lblMinDps.Text = "MinDps";
			lblMaxDps.Text = "MaxDps";
			lblAvrgDps.Text = "AvrgDps";

			lblStatus.Refresh();
			lblMinDps.Refresh();
			lblMaxDps.Refresh();
			lblAvrgDps.Refresh();
		}

		private void cbIsSelected_CheckedChanged(object sender, EventArgs e)
		{
			SetColor();
		}

		void SetColor()
		{
			if (IsSelected)
				this.BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
			else
				this.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
		}

		public bool IsSelected
		{
			get { return cbIsSelected.Checked; }
			set { cbIsSelected.Checked = value; }
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var editForm = new SimCaseDetailsForm();
			editForm.SetValues(simCase);
			editForm.Submitted += new SimCaseEventHandler(editForm_Submitted);
			editForm.ShowDialog();
		}

		void editForm_Submitted(object sender, SimCaseEventArgs e)
		{
			SetValues(e.SimCase);
		}
	}
}
