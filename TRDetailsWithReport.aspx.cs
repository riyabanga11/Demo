using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo1
{

    public partial class TRDetailsWithReport : System.Web.UI.Page
    {

        TR_Details objTR_Details = new TR_Details();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetTRDetails();
            }

        }
        void GetTRDetails()
        {
            DataTable dtTRDetails = null;
            dtTRDetails = objTR_Details.GetTRDetails();

            if (dtTRDetails.Rows.Count > 0)
            {
                ReportViewer1.LocalReport.ReportPath = "TRDetails.rdlc ";
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", dtTRDetails));
                ReportViewer1.LocalReport.Refresh();
            }

        }
    }
}