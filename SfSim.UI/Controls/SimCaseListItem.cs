using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SfSim.UI.Controls
{
	public partial class SimCaseListItem : UserControl
	{
		public SimCaseListItem()
		{
			InitializeComponent();
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (OnCopy != null)
			{
				var simCase = SimCasePanel.GetValues();
				simCase.Name += " copy";
				OnCopy(this, new SimCaseEventArgs(simCase));
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (OnDelete != null)
				OnDelete(this, new EventArgs());
		}

		public SimCasePanel SimCasePanel { get { return simCasePanel; } }

		public event SimCaseEventHandler OnCopy;
		public event EventHandler OnDelete;
	}
}
