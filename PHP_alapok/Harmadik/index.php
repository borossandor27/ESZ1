<?php

?>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Osztályok és névterek</title>
    </head>
    <body>
        <h1>Osztályok és névterek</h1>
        <?php
        // PHP 8.x
        echo 'nyitó névtér:'. __NAMESPACE__;
        include './classes/Allat.php';
        include './classes/Kutya.php';
        
        $bodri = new classes\Kutya();
        $bodri->nev = "Bodri";
        echo $bodri->nev." hangja: ".$bodri->hangotAd(); 
        ?>
    </body>
</html>
