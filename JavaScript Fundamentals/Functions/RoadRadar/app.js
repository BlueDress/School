function getSpeedLimit(arr) {

    let driverSpeed = Number(arr[0]);
    let area = arr[1];

    let speedLimit = 0;
    let overSpeedLimit = 0;

    switch (area) {
        case "motorway":
            speedLimit = 130;
            break;
        case "interstate":
            speedLimit = 90;
            break;
        case "city":
            speedLimit = 50;
            break;
        case "residential":
            speedLimit = 20;
            break;
    }

    if (driverSpeed > speedLimit) {

        overSpeedLimit = driverSpeed - speedLimit;

        if (overSpeedLimit <= 20) {
            return "speeding";
        }
        else if (overSpeedLimit <= 40) {
            return "excessive speeding";
        }
        else {
            return "reckless driving";
        }
    }
    else {
        return "";
    }
}

console.log(getSpeedLimit([40, "city"]));
console.log(getSpeedLimit([21, "residential"]));
console.log(getSpeedLimit([120, "interstate"]));
console.log(getSpeedLimit([200, "motorway"]));
