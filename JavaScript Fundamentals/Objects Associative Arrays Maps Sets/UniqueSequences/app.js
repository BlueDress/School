function sortSequences(arr) {

    let sortedArrays = [];

    for (let i = 0; i < arr.length; i++) {

        let sortedArray = JSON.parse(arr[i]).sort((a, b) => Number(b) - Number(a));

        let arrayIsUnique = true;

        let sortedArrayLength = sortedArray.length;

        for (let j = 0; j < sortedArrays.length; j++) {

            if (sortedArrayLength === sortedArrays[j].length) {

                for (let k = 0; k < sortedArrays.length; k++) {

                    if (sortedArray[k] === sortedArrays[j][k]) {

                        arrayIsUnique = false;
                        break;
                    }
                }
            }

            if (!arrayIsUnique) {

                break;
            }
        }

        if (arrayIsUnique) {

            sortedArrays.push(sortedArray);
        }
    }

    for (let array of sortedArrays.sort(sortByLength)) {

        console.log(JSON.stringify(array));
    }

    function sortByLength(a, b) {

        return a.length - b.length;
    }
}

sortSequences(["[-3, -2, -1, 0, 1, 2, 3, 4]", "[10, 1, -17, 0, 2, 13]", "[4, -3, 3, -2, 2, -1, 1, 0]"]);