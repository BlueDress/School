function validityCheck(arr) {

    let pointOneX = Number(arr[0]);
    let pointOneY = Number(arr[1]);

    let pointTwoX = Number(arr[2]);
    let pointTwoY = Number(arr[3]);

    if (Number.isInteger(Math.sqrt(Math.pow(pointOneX, 2) + Math.pow(pointOneY, 2)))) {
        console.log(`{${pointOneX}, ${pointOneY}} to {0, 0} is valid`);
    }
    else {
        console.log(`{${pointOneX}, ${pointOneY}} to {0, 0} is invalid`);
    }

    if (Number.isInteger(Math.sqrt(Math.pow(pointTwoX, 2) + Math.pow(pointTwoY, 2)))) {
        console.log(`{${pointTwoX}, ${pointTwoY}} to {0, 0} is valid`);
    }
    else {
        console.log(`{${pointTwoX}, ${pointTwoY}} to {0, 0} is invalid`);
    }

    if (Number.isInteger(Math.sqrt(Math.pow(pointOneX - pointTwoX, 2) + Math.pow(pointOneY - pointTwoY, 2)))) {
        console.log(`{${pointOneX}, ${pointOneY}} to {${pointTwoX}, ${pointTwoY}} is valid`);
    }
    else {
        console.log(`{${pointOneX}, ${pointOneY}} to {${pointTwoX}, ${pointTwoY}} is invalid`);
    }
}

validityCheck([2, 1, 1, 1]);