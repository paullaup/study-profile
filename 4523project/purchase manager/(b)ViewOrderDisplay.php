<!DOCTYPE html>
<html lang="en">
<head>
    <title>View the order</title>
    <link rel="stylesheet" href="styleb.css" />
    <script src="b.js"></script>
</head>
<body>
<?php include("ViewOrderCtrl.php");?>
<div class="flexCol">
    <div class="flexRow"> <!-- block contain three block-->
    <div class="flexCol"> <!--checkbox row list block-->
        <div class="flexRow">
            chose at least 2
        </div>
        <div class="flexRow">
            <input type="checkbox" id="order-id" name="order-id" value="order-id">
            <label for="order-id">Order ID</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="supplier-id" name="supplier-id" value="supplier-id">
            <label for="supplier-id">Supplier ID</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="company-name" name="company-name" value="company-name">
            <label for="company-name">Supplier Company Name</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="contact-name" name="contact-name" value="contact-name">
            <label for="contact-name">Supplier Contact Name</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="contact-number" name="contact-number" value="contact-number">
            <label for="contact-number">Supplier Contact Number</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="order-date" name="order-date" value="order-date">
            <label for="order-date">Order Date &amp; Time</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="delivery-address" name="delivery-address" value="delivery-address">
            <label for="delivery-address">Delivery Address</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="delivery-date" name="delivery-date" value="delivery-date">
            <label for="delivery-date">Delivery Date</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="item-id" name="item-id" value="item-id">
            <label for="item-id">Item ID</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="item-image" name="item-image" value="item-image">
            <label for="item-image">Item Image</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="item-name" name="item-name" value="item-name">
            <label for="item-name">Item Name</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="order-quantity" name="order-quantity" value="order-quantity">
            <label for="order-quantity">Order Quantity</label>
        </div>
        <div class="flexRow">
            <input type="checkbox" id="total-order-amount" name="total-order-amount" value="total-order-amount">
            <label for="total-order-amount">Total Order Amount</label>
        </div>
        
    </div> <!--checkbox row list block-->

    <div class="flexCol" style="margin: 0 20px"></div> <!--block to seperate two block-->
        
    <div class="flexCol">    <!--radio row list block-->
        <div class="flexRow">
            chose 1
        </div>
        <div class="flexRow">
            <input type="radio" id="order-id-asc" name="order-id-sort" value="asc">
            <label for="order-id-asc">Ascending</label>
            <input type="radio" id="order-id-desc" name="order-id-sort" value="desc">
            <label for="order-id-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="supplier-id-asc" name="supplier-id-sort" value="asc">
            <label for="supplier-id-asc">Ascending</label>
            <input type="radio" id="supplier-id-desc" name="supplier-id-sort" value="desc">
            <label for="supplier-id-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="company-name-asc" name="company-name-sort" value="asc">
            <label for="company-name-asc">Ascending</label>
            <input type="radio" id="company-name-desc" name="company-name-sort" value="desc">
            <label for="company-name-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="contact-name-asc" name="contact-name-sort" value="asc">
            <label for="contact-name-asc">Ascending</label>
            <input type="radio" id="contact-name-desc" name="contact-name-sort" value="desc">
            <label for="contact-name-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="contact-number-asc" name="contact-number-sort" value="asc">
            <label for="contact-number-asc">Ascending</label>
            <input type="radio" id="contact-number-desc" name="contact-number-sort" value="desc">
            <label for="contact-number-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="order-date-asc" name="order-date-sort" value="asc">
            <label for="order-date-asc">Ascending</label>
            <input type="radio" id="order-date-desc" name="order-date-sort" value="desc">
            <label for="order-date-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="delivery-address-asc" name="delivery-address-sort" value="asc">
            <label for="delivery-address-asc">Ascending</label>
            <input type="radio" id="delivery-address-desc" name="delivery-address-sort" value="desc">
            <label for="delivery-address-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="delivery-date-asc" name="delivery-date-sort" value="asc">
            <label for="delivery-date-asc">Ascending</label>
            <input type="radio" id="delivery-date-desc" name="delivery-date-sort" value="desc">
            <label for="delivery-date-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="item-id-asc" name="item-id-sort" value="asc">
            <label for="item-id-asc">Ascending</label>
            <input type="radio" id="item-id-desc" name="item-id-sort" value="desc">
            <label for="item-id-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="item-image-asc" name="item-image-sort" value="asc">
            <label for="item-image-asc">Ascending</label>
            <input type="radio" id="item-image-desc" name="item-image-sort" value="desc">
            <label for="item-image-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="item-name-asc" name="item-name-sort" value="asc">
            <label for="item-name-asc">Ascending</label>
            <input type="radio" id="item-name-desc" name="item-name-sort" value="desc">
            <label for="item-name-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="order-quantity-asc" name="order-quantity-sort" value="asc">
            <label for="order-quantity-asc">Ascending</label>
            <input type="radio" id="order-quantity-desc" name="order-quantity-sort" value="desc">
            <label for="order-quantity-desc">Descending</label>
        </div>
        <div class="flexRow">
            <input type="radio" id="total-order-amount-asc" name="total-order-amount-sort" value="asc" >
            <label for="total-order-amount-asc">Ascending</label>
            <input type="radio" id="Atotal-order-amount-desc" name="total-order-amount-sort" value="desc">
            <label for="total-order-amount-desc">Descending</label>
        </div>
    </div> <!--radio row list block-->

</div> <!-- block contain three block-->
    <div class="flexRow" style="margin-top: 300px; margin-left:400px;"> <button type="button" onclick="updateGrid()" >update</button></div>
    <div style="max-height: 800px; overflow-y: auto;">
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
    </div>

</div>



        




</body>
</html>