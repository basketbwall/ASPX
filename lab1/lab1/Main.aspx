<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="lab1.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link href="https://bootswatch.com/5/lux/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div class="card text-white bg-primary mb-3 col-5 offset-4 d-flex align-items-center" style="max-width: 35rem;">
        <div class="card-header">Order Confirmation</div>
        <div class="card-body">
            <h4 class="card-title">total cost</h4>
            <p class="card-text" id="pTagText" runat="server"></p>
        </div>
    </div>
    </form>

</body>
</html>
