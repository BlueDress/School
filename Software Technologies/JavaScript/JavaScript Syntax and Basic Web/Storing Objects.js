function  printObj(input) {
    let people = [];

    for(let i = 0; i < input.length; i++){
        let args = input[i].split(' -> ');
        let name = args[0];
        let age = args[1];
        let grade = args[2];

        let person = {Name:name, Age:age, Grade:grade};

        people[i] = person;
    }

    for(person of people){
        console.log(`Name: ${person.Name}`);
        console.log(`Age: ${person.Age}`);
        console.log(`Grade: ${person.Grade}`);
    }
}
