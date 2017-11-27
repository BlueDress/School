<!DOCTYPE html>
<html>
<head>
    <title>Sub-Lists</title>
</head>
<body>
<form>
    <input type="text" name="num1" />
    <input type="text" name="num2" />
    <input type="submit" />
</form>
<?php if (isset($_GET['num1']) && isset($_GET['num2'])) {
    $n1 = intval($_GET['num1']);
    $n2 = intval($_GET['num2']);?>
    <ul>
    <?php for ($i = 1; $i <= $n1; $i++) { ?>
            <li>
                List <?php echo $i;?>
                <ul>
                <?php for ($j = 1; $j <= $n2; $j++) { ?>
                      <li>
                          Element <?php echo $i.".".$j;?>
                      </li>
                    <?php
                } ?>
                </ul>
            </li>
    <?php
    }
}
?>
    </ul>
</body>
</html>
