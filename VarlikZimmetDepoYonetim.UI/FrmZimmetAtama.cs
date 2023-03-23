using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.DTO.Result;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmZimmetAtama : Form
	{
		#region Instances

		private int products;
		private InventoryAssignmentDAL inventoryAssignmentDal;
		ProductWarehouseDAL productWarehouseDal;
		private List<ProductWarehouse> productWarehouses = new List<ProductWarehouse>();
		private Product producta;
		private int insertedInventory;
		UserAssignmentDAL userAssignmentDal;
		TeamAssignmentDAL teamAssignmentDal;
		InventoryReasonDAL inventoryReasonDal = new InventoryReasonDAL();
		InventoryTypeDAL inventoryTypeDal = new InventoryTypeDAL();
		TeamDAL teamDal = new TeamDAL();
		UserDAL userDal = new UserDAL();

		#endregion

		public FrmZimmetAtama()
		{
			InitializeComponent();
		}

		public FrmZimmetAtama(int product) : this() 
		{
			this.products = product;
		}

		void FormLoad()
		{
			cmbInventoryReason.Items.AddRange(inventoryReasonDal.Select().ToArray());
			cmbInventoryType.Items.AddRange(inventoryTypeDal.Select().ToArray());
			cmbInventoryPerson.Enabled = false;
		}
		private void btnInvertoryAdd_Click(object sender, EventArgs e)
		{
			inventoryAssignmentDal = new InventoryAssignmentDAL();
			productWarehouseDal = new ProductWarehouseDAL();
			productWarehouses.AddRange(productWarehouseDal.Select(products));
			InventoryAssignment insertedInventoryAssignment = new InventoryAssignment()
			{
				AssignmentReason = new InventoryReason()
				{
					InventoryReasonId = (cmbInventoryReason.SelectedItem as InventoryReason).InventoryReasonId,
				},
				AssignmentType = new InventoryType()
				{
					InventoryTypeId = (cmbInventoryType.SelectedItem as InventoryType).InventoryTypeId,
				},
				ProductWarehouse = new ProductWarehouse()
				{
					Product = new Product()
					{
						ProductId = products
					},
					ProductWarehouseId = productWarehouses[0].ProductWarehouseId
				},
				Description = tbDescription.Text,
				AssignmentStartDate = dtpInventoryEntry.Value,
				AssignmentEndDate = dtpInventoryEnd.Value
			};
			inventoryAssignmentDal.Insert(insertedInventoryAssignment);
			insertedInventory = inventoryAssignmentDal.InventoryAssignmentId();
			InventoryAssignmentAdd(insertedInventory);
		}

		private MyResult result;
		/// <summary>
		/// Formda bulunan alanlara zimmet atama islemini yapan metot.
		/// </summary>
		/// <param name="insertedInventory"></param>
		public void InventoryAssignmentAdd(int insertedInventory)
		{
			if (cmbInventoryType.SelectedIndex == 1)
			{
				UserAssignment insertedUserAssignment = new UserAssignment()
				{
					User = new User()
					{
						UserId = (cmbInventoryPerson.SelectedItem as User).UserId,
					},
					InventoryAssignment = new InventoryAssignment()
					{
						InventoryAssignmentId = insertedInventory
					}
				};
				userAssignmentDal = new UserAssignmentDAL();
				result = userAssignmentDal.Insert(insertedUserAssignment);
				MessageBox.Show(result.ResultMessage);
			}
			else if (cmbInventoryType.SelectedIndex == 0)
			{
				TeamAssignment insertedTeamAssignment = new TeamAssignment()
				{
					Team = new Team()
					{
						TeamId = (cmbInventoryPerson.SelectedItem as Team).TeamId
					},
					InventoryAssignment = new InventoryAssignment()
					{
						InventoryAssignmentId = insertedInventory
					},
					
				};
				teamAssignmentDal = new TeamAssignmentDAL();
				result = teamAssignmentDal.Insert(insertedTeamAssignment);
				MessageBox.Show(result.ResultMessage);
			}
		}

		private void FrmZimmetAtama_Load(object sender, EventArgs e)
		{
			FormLoad();
		}

		private void cmbInventoryType_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbInventoryPerson.Enabled = true;
			cmbInventoryPerson.Items.Clear();
			if (cmbInventoryType.Text == "Kişi")
			{
				cmbInventoryPerson.Items.AddRange(userDal.Select().ToArray());
			}
			else 
			{
				cmbInventoryPerson.Items.AddRange(teamDal.Select().ToArray());
			}

		}
	}
}
