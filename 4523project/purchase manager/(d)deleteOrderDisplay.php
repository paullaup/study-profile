<!DOCTYPE html>
<html lang="en">
<head>
    <title>Delete order</title>
    <link rel="stylesheet" href="d.css">
</head>
<body>
    <?php include("DeleteOrderCtrl.php");?>
    <form action="DeleteOrderCtrl.php">
        <div class="flexRow">
            <div style="max-height: 800px; overflow-y: scroll; max-width: 50%; overflow-x: scroll;">
                <table class="table" id="table">
                    <tr>
                        <th>Order ID</th>
                        <th>Supplier ID</th>
                        <th>Supplier Company Name</th>
                        <th>Supplier Contact Name</th>
                        <th>Supplier Contact Number</th>
                        <th>Order Date & Time</th>
                        <th>Delivery Address</th>
                        <th>Delivery Date</th>
                        <th>Item ID</th>
                        <th>Item Image</th>
                        <th>Item Name</th>
                        <th>Order Quantity</th>
                        <th>Total Order Amount</th>
                    </tr>
                    <?php getOrderTable();?>
                </table>
                <script>
                    var table = document.getElementById('table');
                    var row = table.getElementsByTagName('tr');
                    for(var i = 0 ; i<row.length ; i++) {
                        row[i].addEventListener("click", function() {
                            if(this.rowIndex!=0){
                                var selectedRow = document.querySelector("tr.selected");
                                if(selectedRow) {
                                    selectedRow.classList.remove("selected");
                                }
                                this.classList.add("selected");
                                var price = this.getElementsByTagName("td")[2].textContent;
                                setPrice(price);
                            }
                        })
                    }
                </script>
            </div>
            <div class="flexCol">
                <label style="margin-top:150px">Selecte and item from the table</label>
                <input type="submit" value="Delete Order" style="margin-top:50px; margin-left: 20px; ">
            </div>
        </div>
    </form>
</body>
</html>
