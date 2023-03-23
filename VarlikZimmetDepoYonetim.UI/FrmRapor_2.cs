using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DAL.ReportDAL;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmRapor_2 : Form
	{
		private TeamAssignmentReportDAL teamAssignmentReportDal;
		private TeamDAL teamDal = new TeamDAL();
		private CompanyDAL companyDal = new CompanyDAL();

		public FrmRapor_2()
		{
			InitializeComponent();
		}

		void FormLoad()
		{
			cmbCompany.Items.AddRange(companyDal.Select().ToArray());
			cmbTeams.Items.AddRange(teamDal.Select().ToArray());
		}

		/// <summary>
		/// Seçilen ekibe ait zimmetli ürünleri getirir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCompany_Click(object sender, EventArgs e)
		{
			lstCompanyTeamProduct.Items.Clear();
			teamAssignmentReportDal = new TeamAssignmentReportDAL();
			List<TeamAssignment> teams = new List<TeamAssignment>();
			teams = teamAssignmentReportDal.Select((cmbTeams.SelectedItem as Team).TeamId);

			foreach (TeamAssignment item in teams)
			{
				ListViewItem h1 = new ListViewItem(item.Team.TeamName);
				h1.SubItems.Add(item.InventoryAssignment.Product.ProductBarcode.ToString());
				h1.SubItems.Add(item.InventoryAssignment.Product.Brand.BrandName);
				h1.SubItems.Add(item.InventoryAssignment.Product.Model.ModelName);
				h1.SubItems.Add(item.InventoryAssignment.AssignmentStartDate.ToShortDateString());
				h1.SubItems.Add(item.InventoryAssignment.AssignmentEndDate.ToShortDateString());

				lstCompanyTeamProduct.Items.Add(h1);
			}
		}

		private void FrmRapor_2_Load(object sender, EventArgs e)
		{
			FormLoad();
			teamDal = new TeamDAL();
		}
	}
}
