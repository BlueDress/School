<!DOCTYPE html>
<html>
<head>
    <title>Multiply a Number by 2</title>
</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    echo $n * 2;
}
?>
</body>
</html>
