'use strict';

function isInside(arr) {
    for (let i = 0; i < arr.length; i += 3) {
        if (10 <= arr[i] && arr[i] <= 50 && 15 <= arr[i + 2] && arr[i + 2] <= 50 && 20 <= arr[i + 1] && arr[i + 1] <= 80) {
            console.log("inside");
        }
        else {
            console.log("outside");
        }
    }
}

isInside([13.1, 50, 31.5, 50, 80, 50, -5, 18, 43, 8, 20, 22]);
