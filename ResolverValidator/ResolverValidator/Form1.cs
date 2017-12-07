using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolverValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetRiskLevel_Click(object sender, EventArgs e)
        {

            string sqlQueryFindDomainUsers = @"select RR_datatype_RiskLevel.data, RR_datatype_RiskLevel.resourceid,RR_datatype_UserName.data,RR_datatype_UserDN.data from RR_datatype_RiskLevel,RR_datatype_UserName,RR_datatype_userDN where RR_datatype_RiskLevel.resourceid=RR_datatype_UserName.resourceid and RR_datatype_UserDN.resourceid=RR_datatype_UserName.resourceid";
            string sqlQueryFindCustomeUsers = @"select RR_datatype_RiskLevel.data, RR_datatype_RiskLevel.resourceid,RR_datatype_UserName.data ,RR_datatype_UserName.ntDomain  from RR_datatype_RiskLevel,RR_datatype_UserName where RR_datatype_RiskLevel.resourceid=RR_datatype_UserName.resourceid and RR_datatype_UserName.ntDomain!='*'";
            SqlLiteHelper instance = new SqlLiteHelper();
            List<ImportedTableData> tableUsers = instance.StartConnection(sqlQueryFindDomainUsers);
            List<ImportedTableData> tableCustomUsers = instance.StartConnection(sqlQueryFindCustomeUsers);
            tableUsers.AddRange(tableCustomUsers);
            datagridtable.DataSource = tableUsers;
            string currentUserDomain = string.Format(@"{0}\{1}", Environment.UserName, Environment.UserDomainName).ToLower();
            DisplayCurenUserDomain.Clear();
            DisplayCurenUserDomain.AppendText(currentUserDomain);
            validIndicator.Clear();
            foreach (ImportedTableData Item in tableUsers)
            {
                if (Item.Domain.Contains("dc="))
                {
                    string fff = String.Format(@"{0}\{1}", Item.LoginName, DomainClean(Item.Domain).ToLower());
                    if (fff == currentUserDomain)
                    {
                        validIndicator.AppendText(@"Current Login user is exist in EP DB");
                        validIndicator.BackColor = Color.Green;
                        break;
                    }


                }
                else
                {
                    string aa = string.Format(@"{0}\{1}", Item.LoginName, Item.Domain).ToLower();
                    if (aa == currentUserDomain.ToLower())
                    {
                        validIndicator.AppendText(@"Current Login user is exist in EP DB");
                        validIndicator.BackColor = Color.Green;
                        break;
                    }
                }
                
            }
            if (validIndicator.Text == @"")
            {
                validIndicator.AppendText(@"Current user doesn't exist in EP DB");
                validIndicator.BackColor = Color.Red;


            }



        }

        private string DomainClean(string domain)
        {
           string[] s = domain.Split(',');
           return string.Format(@"{0}", s[2].Substring(3,s[2].Length-3).ToLower());
            
            
        }
    }
}
