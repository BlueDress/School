<!DOCTYPE html>
<html>
<head>
    <title>Numbers from 1 to N</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = 1; $i <= $n; $i++) {
        echo $i . " ";
    }
}
?>
</body>
</html>
