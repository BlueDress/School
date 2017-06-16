<!DOCTYPE html>
<html>
<head>
    <title>HTML Buttons</title>
</head>
<body>
<form>
    <input type="text" name="num" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num'])) {
    $n = intval($_GET['num']);
    for ($i = 1; $i <= $n; $i++) { ?>
        <button><?php echo $i;?></button>
        <?php
    }
}
?>
</body>
</html>
