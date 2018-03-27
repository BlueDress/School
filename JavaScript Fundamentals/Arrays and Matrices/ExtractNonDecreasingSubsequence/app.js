function extractSequnce(arr) {

    let biggestNumber = arr[0];
    let nondecreasingSequence = [];
    nondecreasingSequence.push(biggestNumber);

    for (let i = 1; i < arr.length; i++) {

        if (arr[i] >= biggestNumber) {

            nondecreasingSequence.push(arr[i]);
            biggestNumber = arr[i];
        }
    }

    console.log(nondecreasingSequence.join("\n"));
}

extractSequnce([1, 3, 8, 4, 10, 12, 3, 2, 24]);
