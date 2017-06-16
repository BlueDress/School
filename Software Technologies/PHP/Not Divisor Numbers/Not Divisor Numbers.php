<!DOCTYPE html>
<html>
<head>
    <title>Not Divisor Numbers</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = $n; $i >= 1; $i--) {
        if ($n % $i != 0) {
            echo $i . " ";
        }
    }
}
?>
</body>
</html>
