<!DOCTYPE html>
<html>
<head>
    <title>Prime Numbers from N to 1</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = $n; $i > 2; $i--) {
        $isPrime = true;
        for ($j = 2; $j <= $i / 2; $j++) {
            if ($i % $j == 0) {
                $isPrime = false;
                break;
            }
        }
        if ($isPrime == true) {
            echo $i . " ";
        }
    }
}
?>
</body>
</html>
