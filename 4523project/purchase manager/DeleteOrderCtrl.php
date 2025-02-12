<?php 

include("conn.php");

    
function getOrderTable() {
    for($i = 0 ; $i<30 ; $i++) {
        echo"<tr>
        <td>$i Order ID</td>
        <td>$i Supplier ID</td>
        <td>$i Supplier Company Name</td>
        <td>$i Supplier Contact Name</td>
        <td>$i Supplier Contact Number</td>
        <td>$i Order Date & Time</td>
        <td>$i Delivery Address</td>
        <td>$i Delivery Date</td>
        <td>$i Item ID</td>
        <td>$i Item Image</td>
        <td>$i Item Name</td>
        <td>$i Order Quantity</td>
        <td>$i Total Order Amount</td>
        </tr>";
    }
}