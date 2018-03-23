function printQAndA(arr) {

    console.log('<?xml version="1.0"; encoding="UTF-8"?>');
    console.log('<quiz>');

    for (let i = 0; i < arr.length; i += 2) {

        let questionText = arr[i];
        let answerText = arr[i + 1];

        console.log('   <question>');
        console.log();
        console.log(`       ${questionText}`);
        console.log();
        console.log('   </question>');
        console.log('   <answer>');
        console.log();
        console.log(`       ${answerText}`);
        console.log();
        console.log('   </answer>');
    }

    console.log('</quiz>');
}

printQAndA(["Dry ice is a frozen form of which gas ?", " Carbon Dioxide", " What is the brightest star in the night sky ?", " Sirius"]);
