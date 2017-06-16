<!DOCTYPE html>
<html>
<head>
    <title>Even Numbers from 1 to N</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = 1; $i <= $n; $i++){
        if ($i % 2 == 0) {
            echo $i . " ";
        }
    }
}
?>
</body>
</html>
