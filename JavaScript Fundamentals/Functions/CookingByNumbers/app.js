function cook(arr) {

    let startingPoints = Number(arr[0]);

    for (let i = 1; i < arr.length; i++) {

        switch (arr[i]) {
            case "chop":
                startingPoints /= 2;
                break;
            case "dice":
                startingPoints = Math.sqrt(startingPoints);
                break;
            case "spice":
                startingPoints += 1;
                break;
            case "bake":
                startingPoints *= 3;
                break;
            case "fillet":
                startingPoints -= startingPoints * 0.2;
                break;
        }

        console.log(startingPoints);
    }
}

cook([9, "dice", "spice", "chop", "bake", "fillet"]);