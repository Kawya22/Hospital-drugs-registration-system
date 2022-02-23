<?php
$serverName= "DESKTOP-7B3FIB2";
$connectionInfo = array( "Database"=>"HospitalFinal");
$conn =sqlsrv_connect( $serverName, $connectionInfo);

if($conn)
    {
       echo "connection established.<br/>";

    }else
        {
            echo "connection could not beestablised.<br/>";
            die( print_r( sqlsrv_errors(), true));
        }
?>

<html>

    <head>

        <title>LocalPurchases</title>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <style>

            table,th,tr,td
            {
                border: 1px solid black;
            }

        </style>

    </head>

    <body>


        <table style="background-color: yellow;">

            <tr>
                <th>itemNo</th>
                <th>itemName</th>
                <th>currentbalance</th>
           
            </tr>

            <?php while($row1 = mysqli_fetch_array($result1)):;?>
            <tr>
                <td><?php echo $row1[0];?></td>
                <td><?php echo $row1[1];?></td>
                <td><?php echo $row1[2];?></td>
                
            </tr>
            <?php endwhile;?>

        </table>