<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PopUp.aspx.cs" Inherits="WebApplication1.PopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <style>
        /* Styles for the pop-up */
        .popup-overlay {
            display: none;
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-color: rgba(0, 0, 0, 0.5);
            z-index: 999;
        }

        .popup-content {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.3);
        }

        .close-btn {
            position: absolute;
            top: 10px;
            right: 10px;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Button to open the pop-up -->
        <button id="btnpop">Open Pop-up</button>

        <!-- Pop-up overlay and content -->
        <div class="popup-overlay" id="popupOverlay">
            <div class="popup-content">
                <span class="close-btn" onclick="closePopup()">&times;</span>
                <h2>Pop-up Content</h2>
                <p>This is a pop-up on the web page.</p>
            </div>
        </div>
    </form>

    <script>
        // Function to open the pop-up
        $(document).ready(function () {
            console.log('Pop Up Begin');
            $('#btnpop').click(function () {
                var popup = document.getElementById('popupOverlay');
                popup.style.display = 'block';
            })
           // function openPopup() {
           //     var popup = document.getElementById('popupOverlay');
           //     popup.style.display = 'block';
           // }
        })
        

        //Function to close the pop-up
        function closePopup() {
            var popup = document.getElementById('popupOverlay');
            popup.style.display = 'none';
        }
    </script>
</body>
</html>
