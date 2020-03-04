using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebGroupProject.Models;

namespace WebGroupProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFTest" in both code and config file together.
    [ServiceContract]
    public interface IWCFTest
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<JasonTest> getSubCategory(int CategoryID);
    }
}
