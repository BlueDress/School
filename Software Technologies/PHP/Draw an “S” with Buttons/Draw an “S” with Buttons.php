<!DOCTYPE html>
<html>
<head>
    <title>Draw an “S” with Buttons</title>
</head>
<body>
<?php for ($row = 1; $row <= 9; $row++) {
    if ($row == 1 || $row == 5 || $row == 9) {
        for ($i = 1; $i <= 5; $i++) { ?>
            <button style="background-color: blue"><?php echo "1"; ?></button><?php
        }
        ?><br /><?php
    }
    elseif ($row <= 4 && $row >= 2){ ?>
        <button style="background-color: blue"><?php echo "1"; ?></button><?php
        for ($j = 1; $j <= 4; $j++){ ?>
            <button><?php echo "0"; ?></button><?php
        }
        ?><br /><?php
    }
    elseif ($row <= 8 && $row >= 6) {
        for ($p = 1; $p <= 4; $p++){ ?>
            <button><?php echo "0"; ?></button>
         <?php }?>
            <button style="background-color: blue"><?php echo "1"; ?></button><br /><?php

    }
}
?>
</body>
</html>
