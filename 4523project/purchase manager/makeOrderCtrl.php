<?php
    include("conn.php");

    $orderID = 1;

    function test() {
        alert("test");
    }

    function getItem() {
        for($i = 0 ; $i<20 ; $i++) {
            echo("<tr>
                    <td>test ID$i</td>
                    <td>test Name$i</td>
                    <td>$i</td>
                </tr>");
        }
    }

    
