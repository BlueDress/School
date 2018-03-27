function rotateArray(arr) {

    let numberOfRotations = Number(arr.pop());

    for (let i = 0; i < numberOfRotations; i++) {

        let elementToShift = arr.pop();

        arr.unshift(elementToShift);
    }

    console.log(arr.join(" "));
}

rotateArray(["Banana", "Orange", "Coconut", "Apple", "15"]);