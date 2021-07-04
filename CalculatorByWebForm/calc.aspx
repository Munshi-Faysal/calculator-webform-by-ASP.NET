<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="calc.aspx.cs" Inherits="CalculatorByWebForm.calc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <body>
        <div style="padding: 10px;"">
             <center>
                 <div style="margin-bottom: 50px;">
                     <h1>Calculator</h1>
                 </div>
                 
                 <div style="border: 1px solid black; width: 25%; padding:30px; background:#3a847b; border-radius: 10px; ">
                     <p>
                        <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="175px"></asp:TextBox>
                    </p>
                    <p>
                        <asp:Button style="background: green; color: white;border-radius: 20px;" ID="Button1" runat="server" Text="ON" Width="39px" OnClick="Button1_Click" />
                        <asp:Button style="background: red; color: white;border-radius: 20px;" ID="Button2" runat="server" Text="OFF" Width="36px" OnClick="Button2_Click"  />
                        <asp:Button  style="background: #3498db; color: white;border-radius: 20px;" ID="Button3" runat="server" Text="CLR" OnClick="Button3_Click" />
                        <asp:Button style="background: #FDA7DF; color: white;border-radius: 20px;" ID="Button4" runat="server" Text="/" Width="37px" OnClick="Button4_Click" />
                    </p>
                    <p>
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button5" runat="server" Text="7" Width="39px" OnClick="Button5_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button6" runat="server" Text="8" Width="38px" OnClick="Button6_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button7" runat="server" Text="9" Width="43px" OnClick="Button7_Click" />
                        <asp:Button style="background: #FDA7DF; color: white;border-radius: 20px;" ID="Button8" runat="server" Text="*" Width="35px" OnClick="Button8_Click" />
                    </p>
                    <p>
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button9" runat="server" Text="4" Width="39px" OnClick="Button20_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button10" runat="server" Text="5" Width="38px" OnClick="Button21_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button11" runat="server" Text="6" Width="43px" OnClick="Button22_Click" />
                        <asp:Button style="background: #FDA7DF; color: white;border-radius: 20px;" ID="Button12" runat="server" Text="-" Width="35px" OnClick="Button12_Click" />
                    </p>
                    <p>
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button13" runat="server" Text="1" Width="39px" OnClick="Button24_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button14" runat="server" Text="2" Width="38px" OnClick="Button25_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button15" runat="server" Text="3" Width="43px" OnClick="Button26_Click" />
                        <asp:Button style="background:#FDA7DF; color: white;border-radius: 20px;" ID="Button16" runat="server" Text="+" Width="35px" OnClick="Button16_Click" />
                    </p>
                    <p>
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button17" runat="server" Text="0" Width="39px" OnClick="Button28_Click" />
                        <asp:Button style="background:#778ca3; color: white;border-radius: 20px;" ID="Button18" runat="server" Text="." Width="38px" OnClick="Button29_Click" />
                        <asp:Button style="background:#a55eea; color: white; border-radius: 20px;" ID="Button19" runat="server" Text="=" Width="78px" OnClick="Button19_Click" />
                    </p>
                 </div>
                    

                 </center>
        </div>     
    </body>
   
    
</asp:Content>
