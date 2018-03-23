function printDNAHelix(num) {

    let dnaSequence = "ATCGTTAGGG";

    for (let i = 0, j = 0; i < num; i++, j += 2) {

        if (i % 4 === 0) {
            console.log(`**${dnaSequence[j % 10]}${dnaSequence[(j + 1) % 10]}**`);
        }
        else if (i % 4 === 1) {
            console.log(`*${dnaSequence[j % 10]}--${dnaSequence[(j + 1) % 10]}*`);
        }
        else if (i % 4 === 2) {
            console.log(`${dnaSequence[j % 10]}----${dnaSequence[(j + 1) % 10]}`);
        }
        else if (i % 4 === 3) {
            console.log(`*${dnaSequence[j % 10]}--${dnaSequence[(j + 1) % 10]}*`);
        }
    }
}

printDNAHelix(10);
