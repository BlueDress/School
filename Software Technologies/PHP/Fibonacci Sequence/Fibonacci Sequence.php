<!DOCTYPE html>
<html>
<head>
    <title>Fibonacci Sequence</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    $p1 = 1;
    $p2 = 1;
    $p3 = 0;
    echo "1 1 ";
    for ($i = 2; $i < $n; $i++) {
        $p3 = $p1 + $p2;
        $p1 = $p2;
        $p2 = $p3;
        echo $p3 . " ";
    }
}
?>
</body>
</html>
