function captureNumbers(arr) {

    let regex = /\d+/g;

    let numbers = [];

    for (let i = 0; i < arr.length; i++) {

        while (true) {

            let result = regex.exec(arr[i]);

            if (result == null) {

                break;
            }

            numbers.push(result);
        }
    }

    console.log(numbers.join(" "));
}

captureNumbers(["The300", "What is that ?", "I think it’s the 3rd movie.", "Lets watch it at 22:45"]);