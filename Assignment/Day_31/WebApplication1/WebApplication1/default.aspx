<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Verdana, Geneva, sans-serif;
            font-size: 14px;
            background-color: lightpink;
        }

        .button-64 {
            align-items: center;
            background-image: linear-gradient(144deg,#AF40FF, #5B42F3 50%,#00DDEB);
            border: 0;
            border-radius: 8px;
            box-shadow: rgba(151, 65, 252, 0.2) 0 15px 30px -5px;
            box-sizing: border-box;
            color: #FFFFFF;
            display: flex;
            font-family: Phantomsans, sans-serif;
            font-size: 20px;
            justify-content: center;
            line-height: 1em;
            max-width: 100%;
            min-width: 140px;
            padding: 3px;
            text-decoration: none;
            user-select: none;
            -webkit-user-select: none;
            touch-action: manipulation;
            white-space: nowrap;
            cursor: pointer;
        }

            .button-64:active,
            .button-64:hover {
                outline: 0;
            }

            .button-64 span {
                background-color: rgb(5, 6, 45);
                padding: 16px 24px;
                border-radius: 6px;
                width: 100%;
                height: 100%;
                transition: 300ms;
            }

            .button-64:hover span {
                background: none;
            }

        @media (min-width: 768px) {
            .button-64 {
                font-size: 24px;
                min-width: 196px;
            }
        }

        .div1 {
            position: absolute;
            top: 25%;
            padding: 100px;
            left: 35%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <asp:LinkButton ID="LinkButton2" runat="server" class="button-64" OnClick="LinkButton2_Click">
                <span class="text">
                    <center>Student Registration</center>
                </span>
            </asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" class="button-64" OnClick="LinkButton1_Click">
                <span class="text">
                    <center>Department Login</center>
                </span>
            </asp:LinkButton>
        </div>
    </form>
</body>
</html>

