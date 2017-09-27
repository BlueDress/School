function isPrime(number) {
    let isPrime = true;

    for (let i = 2; i <= Math.sqrt(number); i++) {
        if (number % i == 0 && number > 2) {
            isPrime = false;
        }
    }

    return isPrime;
}