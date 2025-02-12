<!DOCTYPE html>
<html lang="en">
<head>
    <title>Update purchase manager's information</title>
    <link rel="stylesheet" href="c.css" />
</head>
<body>
    <form action="UpdatePurchaseManagerInformartionCtrl.php" method="post">
        <div class="flexRow">
            <label for="txtStaffID">StaffID:</label><input type="text" id="txtStaffID" class="textbox" style="margin-right: 50px" />
            <label for="txtPassword">Password:</label><input type="text" id="txtPassowrd" class="textbox" />
        </div>
        <div class="flexCol" style="margin-top: 30px">
            <div class="flexRow" style="margin-top: 10px;"><label for="txtPassword">New Password:</label><input type="text" id="txtNewPassword" class="textbox" /></div>
            <div class="flexRow" style="margin-top: 10px;"><label for="txtContactNum">New Password:</label><input type="text" id="txtContactNum" class="textbox" /></div>
            <div class="flexRow" style="margin-top: 10px;"><label for="txtWarehouseAddress">New Password:</label><input type="text" id="txtWarehouseAddress" class="textbox" /></div>
        </div>
        <div class="flexRow">
            <input type="reset" value="reset" style="margin-left:40%">
            <input type="submit" value="submit" style="margin-right:40%;" />
        </div>
    </form>
</body>
</html>