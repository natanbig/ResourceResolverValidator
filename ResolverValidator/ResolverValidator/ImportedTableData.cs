using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverValidator
{
    public class ImportedTableData
    {


        public  ImportedTableData(int riskLevel, string userId, string loginName, string domain)
        {
            RiskLevel = riskLevel;
            UserId = userId;
            LoginName = loginName;
            Domain = domain;
        }





        public int RiskLevel { get; set; }
        public string UserId {get; set;}
        public string LoginName { get; set; }
        public string Domain { get; set; }
        
    }
}
