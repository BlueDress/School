function findTreasure(arr) {

    let locations = [];

    for (let i = 0; i < arr.length; i += 2) {

        let pointX = Number(arr[i]);
        let pointY = Number(arr[i + 1]);

        if (1 <= pointX && pointX <= 3 && 1 <= pointY && pointY <= 3) {
            locations.push("Tuvalu");
        }
        else if (8 <= pointX && pointX <= 9 && 0 <= pointY && pointY <= 1) {
            locations.push("Tokelau");
        }
        else if (5 <= pointX && pointX <= 7 && 3 <= pointY && pointY <= 5) {
            locations.push("Samoa");
        }
        else {
            locations.push("On the bottom of the ocean");
        }
    }

    for (let location of locations) {
        console.log(location);
    }
}

findTreasure([4, 2, 1.5, 6.5, 1, 3, 6, 4]);