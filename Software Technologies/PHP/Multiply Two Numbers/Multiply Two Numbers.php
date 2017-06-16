<!DOCTYPE html>
<html>
<head>
    <title>Multiply Two Numbers</title>
</head>
<body>
<form>
    N: <input type="text" name="num1" />
    M: <input type="text" name="num2" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num1']) && isset($_GET['num2'])) {
    $n = intval($_GET['num1']);
    $m = intval($_GET['num2']);
    echo $n * $m;
}
?>
</body>
</html>
