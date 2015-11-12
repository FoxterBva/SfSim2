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
		}

		SimulationCase GetValues()
		{
			var res = new SimulationCase();

			res.Name = tbSimName.Text;

			return res;
		}

		public event SimCaseEditEventHandler Submitted;

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Submitted != null)
				Submitted(this, new SimCaseEditFormEventArgs(GetValues()));

			this.Close();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

	public delegate void SimCaseEditEventHandler(object sender, SimCaseEditFormEventArgs e);

	public class SimCaseEditFormEventArgs : EventArgs
	{
		public SimCaseEditFormEventArgs(SimulationCase simCase) 
			: base()
		{
			SimCase = simCase;
		}

		public SimulationCase SimCase { get; set; }
	}
}
