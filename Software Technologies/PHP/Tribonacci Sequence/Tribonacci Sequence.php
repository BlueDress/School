<!DOCTYPE html>
<html>
<head>
    <title>Tribonacci Sequence</title>
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
    $p3 = 2;
    $p4 = 0;
    echo "1 1 2 ";
    for ($i = 3; $i < $n; $i++) {
        $p4 = $p1 + $p2 + $p3;
        $p1 = $p2;
        $p2 = $p3;
        $p3 = $p4;
        echo $p3 . " ";
    }
}
?>
</body>
</html>
