<h1>Űrlap</h1>
<?php
if (filter_input(INPUT_POST,"VanAdat", FILTER_VALIDATE_BOOLEAN, FILTER_NULL_ON_FAILURE)) {
    //-- Van feldolgozandó adat
    $vezeteknev = filter_input(INPUT_POST, 'vezeteknev', FILTER_SANITIZE_STRING);
    $keresztnev = filter_input(INPUT_POST, 'keresztnev', FILTER_SANITIZE_STRING);
    echo "<h3>Üdvözlünk $vezeteknev $keresztnev!</h3>";

} else {
    //-- Nincs feldolgozandó adat
    ?>
    <form action="index.php?menuitem=urlap" method="POST">
        <label>Vezetéknév</label>
        <input type="text" name="vezeteknev">
        <label>keresztnév</label>
        <input type="text" name="keresztnev">
        <button name="VanAdat" value="true">csináld!</button>
    </form>
    <?php
}
//-- var_dump($_POST);
?>


<?php
