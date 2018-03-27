function isMatrixMagical(matrix) {

    let sum = matrix[0].reduce((a, b) => a + b, 0);

    for (let i = 0; i < matrix.length; i++) {

        if (matrix[i].reduce((a, b) => a + b, 0) != sum) {

            return false;
        }

        let currentSum = 0;

        for (let j = 0; j < matrix.length; j++) {

            currentSum += matrix[j][i];
        }

        if (currentSum != sum) {

            return false;
        }
    }

    return true;
}

console.log(isMatrixMagical([[4, 5, 6], [6, 5, 4], [5, 5, 5]]));
console.log(isMatrixMagical([[4, 5, 6], [6, 5, 7], [5, 5, 5]]));