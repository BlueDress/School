function modify(number) {

    let num = number.toString();
    let averageValue = 0;

    while (true) {

        let sumOfDigits = 0;

        for (let i = 0; i < num.length; i++) {
            sumOfDigits += Number(num[i]);
        }

        averageValue = sumOfDigits / num.length

        if (averageValue > 5) {

            console.log(num);
            break;
        }

        num = num + '9';
    }
}

modify(101);