using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ServiceLayer.Models
{
   
    public  partial class PickList : ObservableObject
    {
        [ObservableProperty]
        int pickListID;

        [ObservableProperty]
         DateTime dateStamp;

        [ObservableProperty]
        int jobID;

        [ObservableProperty]
        string jobName;

        [ObservableProperty]
         string preparedBy;

        [ObservableProperty]
        int itemCount;

       [ObservableProperty]
        bool complete;

    }
}
