using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SfSim.Model.Classes;

namespace SfSim.UI
{
	public partial class SimCaseDetailsForm : Form
	{
		public SimCaseDetailsForm()
		{
			InitializeComponent();
		}

		public void SetValues(SimulationCase simCase)
		{
			tbSimName.Text = simCase.Name;
			tbIterations.Value = simCase.IterationCount;
			tbMaxHp.Value = simCase.TargetMaxHp;

			tbMight.Value = simCase.SourceStats.Might;
			tbStam.Value = simCase.SourceStats.Stamina;
			tbStr.Value = simCase.SourceStats.Str;
			tbBrave.Value = simCase.SourceStats.Brave;
			tbLuck.Value = simCase.SourceStats.Luck;
			tbSpirit.Value = simCase.SourceStats.Spirit;

			rtbSymbols.Text = simCase.SymbolsStr;
			rtbTalents.Text = simCase.TalentsStr;
		}

		SimulationCase GetValues()
		{
			var res = new SimulationCase();

			res.Name = tbSimName.Text;
			res.IterationCount = Convert.ToInt32(tbIterations.Value);
			res.TargetMaxHp = Convert.ToInt32(tbMaxHp.Value);

			res.SourceStats.Might = Convert.ToInt32(tbMight.Value);
			res.SourceStats.Stamina = Convert.ToInt32(tbStam.Value);
			res.SourceStats.Str = Convert.ToInt32(tbStr.Value);
			res.SourceStats.Brave = Convert.ToInt32(tbBrave.Value);
			res.SourceStats.Luck = Convert.ToInt32(tbLuck.Value);
			res.SourceStats.Spirit = Convert.ToInt32(tbSpirit.Value);

			res.SymbolsStr = rtbSymbols.Text;
			res.TalentsStr = rtbTalents.Text;

			return res;
		}

		public event SimCaseEventHandler Submitted;

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Submitted != null)
				Submitted(this, new SimCaseEventArgs(GetValues()));

			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

	public delegate void SimCaseEventHandler(object sender, SimCaseEventArgs e);

	public class SimCaseEventArgs : EventArgs
	{
		public SimCaseEventArgs(SimulationCase simCase) 
			: base()
		{
			SimCase = simCase;
		}

		public SimulationCase SimCase { get; set; }
	}
}
