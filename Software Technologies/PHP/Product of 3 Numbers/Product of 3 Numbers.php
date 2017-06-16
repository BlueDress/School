<!DOCTYPE html>
<html>
<head>
    <title>Product of 3 Numbers</title>
</head>
<body>
<form>
    N: <input type="text" name="num1" />
    M: <input type="text" name="num2" />
    P: <input type="text" name="num3" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $n = intval($_GET['num1']);
    $m = intval($_GET['num2']);
    $p = intval($_GET['num3']);
    if ($n * $m * $p >= 0) {
        echo 'Positive';
    }
    else {
        echo 'Negative';
    }
}
?>
</body>
</html>
