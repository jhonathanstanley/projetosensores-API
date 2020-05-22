<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SensoresDashboard._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <br />
    <br />
    <div class="row">
        <asp:GridView ID="gdvSensores" runat="server" AutoGenerateColumns="False" CellPadding="8" ForeColor="#333333" GridLines="None" Height="134px" Width="856px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="latitude" HeaderText="Latitude" />
                <asp:BoundField DataField="longitude" HeaderText="Longitude" />
                <asp:BoundField DataField="luminosidade" HeaderText="Luminosidade" />
                <asp:BoundField HeaderText="Proximidade" DataField="proximidade" />
                <asp:BoundField DataField="dataEnvio" HeaderText="DataEnvio" />
            </Columns>
            <EditRowStyle BackColor="#2461BF"/>
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB"/>
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>

</asp:Content>
