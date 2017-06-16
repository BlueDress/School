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
    $n2 = intval($_GET['num2']);
    for ($i = 1; $i <= $n1; $i++) { ?>
        <ul>
            <li>
                List <?php echo $i;
                for ($j = 1; $j <= $n2; $j++) { ?>
                  <ul>
                      <li>
                          Element <?php echo $i.".".$j;?>
                      </li>
                  </ul>
                    <?php
                } ?>
            </li>
        </ul>
        <?php
    }
}
?>
</body>
</html>
