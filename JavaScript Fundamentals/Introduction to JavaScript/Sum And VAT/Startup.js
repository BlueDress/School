function calculateSumAndVat(input) {
    let sum = 0;
    for (let i = 0; i < input.length; i++){
        sum += input[i];
    }
    console.log(`sum = ${sum}`);
    console.log(`VAT = ${sum * 0.2}`);
    console.log(`total = ${sum * 1.2}`);
}