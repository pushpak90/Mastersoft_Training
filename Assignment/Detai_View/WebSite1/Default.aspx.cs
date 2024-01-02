using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ReportDocument cryRpt = new ReportDocument();
        cryRpt.Load(Server.MapPath("~")+ "/CrystalReport.rpt");
        CrystalReportViewer1.ReportSource = cryRpt;
    }
}