using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceProcess;

namespace ServiceManager
{
	public partial class Form1 : Form
	{
		private List<service> lists = new List<service>();

		public Form1()
		{
			InitializeComponent();
			ListServices(GetServices());
		}

		private List<service> GetServices()
		{
			ServiceController[] services = System.ServiceProcess.ServiceController.GetServices();
			checkedListBoxServices.Items.Clear();
			for (int i = 0; i < services.Length; i++)
			{
				service s = new service();

				checkedListBoxServices.Items.Add(services[i].ServiceName + " - " + services[i].DisplayName
					+ " = " + services[i].ServiceType 
					+ " - " + services[i].Status);

				s.ServiceName = services[i].ServiceName;
				s.DisplayName = services[i].DisplayName;
				s.ServiceType = services[i].ServiceType.ToString() ;
				s.Status = services[i].Status.ToString() ;

				lists.Add(s);
			}

			return lists;
		}

		private void ListServices(List<service> lists)
		{
			checkedListBoxServices.Items.Clear();
			var newlists = lists.OrderBy(s => s.DisplayName);

			foreach (service list in newlists)
			{
				checkedListBoxServices.Items.Add(list.DisplayName + "    [" + list.ServiceName
					+ " = " + list.ServiceType
					+ " - " + list.Status +"]");
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{

		}
	}
}
