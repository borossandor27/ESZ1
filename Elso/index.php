<!DOCTYPE html>

<html lang="hu">
    <head>
        <meta charset="UTF-8">
        <title>Első PHP alkamazás</title>
        <link rel="stylesheet" href="elso.css">
    </head>
    <body>
        <nav>
            <ul>
                <li><a href="index.php?menuitem=lista" >Listák</a>
                <li><a href="index.php?menuitem=tablazat" >Táblázat</a>
                <li><a href="index.php?menuitem=urlap" >Űrlap</a>
            </ul>
        </nav>
        <h1>Első PHP alkamazás</h1>
        <?php
            $menuItem = filter_input(INPUT_GET, 'menuitem', FILTER_SANITIZE_STRING);
            var_dump($_GET);
            switch ($menuItem) {
                case "lista":
                    include './listak.php';
                    break;
                case "tablazat":
                    include './tablazat.php';
                    break;
                case "urlap":
                    include './urlapok.php';
                    break;

                default:
                    echo '<h2>Űdvözlet!</h2>';
                    break;
            }
            echo 'választás értéke: '.$menuItem;
        ?>
    </body>
</html>
