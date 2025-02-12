<!DOCTYPE html>
<html lang="en">
<head>
    <title>Make an order</title>
    <link rel="stylesheet" href="style/style.css">
    <script src="javascript/script.js"></script>
</head>
<body>
    <form action="OrderForm.php" method="post" style="border: 1px lightgray">
        <?php include("makeOrderCtrl.php"); ?>

        <div class="flex-container">
            <div>
                <label for="txtStaffID:" style="padding-top: 5px;">StaffID</label>
                <input type="password" id="txtStaffID" class="textbox" onblur="verify()" />
                <label id="lblInvaildIDMsg" style="display: none; color: red;" />
            </div>
            <div class="name">
                <label id="lblName"></label>
            </div>
        </div>

        <br>

        <div class="flex-container">
            <div style="max-height: 200px; overflow-y: auto;">
                <table id="table" class="itemtable">
                        <tr>
                            <th style="text-align:left;">Item ID</th>
                            <th style="text-align:left;">Item Name</th>
                            <th style="text-align:left;">Item Price</th>
                        </tr>
                        <?php getItem()?>
                </table>
            </div>
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
            <div class="innerFlex" style="margin-left: 35px">
                <label for="txtOrderQuantity">Order quantity:</label>
                <input type="number" id="txtOrderQuantity" class="textbox" style="width:58%" onblur=""/>
                <div>
                    <input type="text" id="txtAmt" class="textboxDisplay" value="select an item and enter the quantity to calculate the total Amount"/>
                    <script>document.getElementById("txtAmt").disabled = true</script>
                </div>
            </div>
        </div>

        <div class="flex-container">
            <div>
                <input type="date" class="inputDate" />
            </div>
            <div style="margin-top: 25px; margin-left: 35px">
                <label for="txtAddress">Delivery Address:</label>
                <input type="text" id="txtAddress" class="textbox" style="margin: auto" />
            </div>
        </div>
        <div class="flex-container">
            <input type="reset" value="reset" />
            <input type="submit" value="submit" />
        </div>
    </form>
</body>
</html>