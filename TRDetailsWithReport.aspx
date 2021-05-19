<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TRDetailsWithReport.aspx.cs" Inherits="Demo1.TRDetailsWithReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <h1> Excise and Taxation Department </h1>

            </div>
        <br />
        <div>
            <asp:Table ID="TRDetails" runat="server" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell Font-Bold="true" ForeColor="Black" HorizontalAlign="Center" Font-Size="X-Large">
                        TR Details
                    </asp:TableHeaderCell>
                </asp:TableHeaderRow>
               
                <asp:TableRow>
                    <asp:TableCell>
                    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Name="Arial" Font-Size="Medium"  Width="100%" Height="50%" AsyncRendering="False"  SizeToReportContent="True"></rsweb:ReportViewer>
                        <LocalReport ReportPath="TRDetails.rdlc">
                        </LocalReport>
                        </asp:TableCell>    
                </asp:TableRow>
            </asp:Table>
        </div>
        
    </form>
</body>
</html>
