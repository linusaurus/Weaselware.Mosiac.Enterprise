using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public   partial class TransmittalDto : ObservableObject
    {
        private List<TransmittalItemDto> _transmittalItems = new List<TransmittalItemDto>();

		private int transmittalID;

		public int TramsmittalID
		{
			get => transmittalID;
			set => SetProperty(ref transmittalID, value);
		}

		private DateTime submittalDate;

		public DateTime SubmittalDate
		{
			get => submittalDate;
			set => SetProperty(ref submittalDate, value);
		}

		private int jobID;

		public int JobId
		{
			get => jobID;
			set => SetProperty(ref jobID, value);
		}
		private int employeeID;

		public int EmployeeID
		{
			get => employeeID;
			set => SetProperty(ref employeeID, value);
		}

		private int includedItemCount;

		public int IncludedItemsCount
		{
			get { return includedItemCount; }
			set { includedItemCount = value; }
		}





	}
}
