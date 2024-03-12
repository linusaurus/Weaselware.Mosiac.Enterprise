using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public partial class TransmittalItemDto : ObservableObject
    {
        public TransmittalItemDto() { }

		private int transmitallID;
        private string description;
        private int quanity;

        public int TransmittalID
		{
			get => transmitallID; 
			set => SetProperty(ref transmitallID, value);
		}

		public string Description
		{
			get => description;
			set => SetProperty(ref description , value); 
		}
	
		public int Quanity
		{
			get => quanity;
			set => SetProperty(ref quanity , value);
		}


		


	}
}
