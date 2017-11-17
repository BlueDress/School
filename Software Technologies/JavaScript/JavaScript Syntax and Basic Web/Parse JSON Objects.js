function  parseJSON(input) {
    let people = [];

    for(let i = 0; i < input.length; i++){
        let person = JSON.parse(input[i]);
        people[i] = person;
    }

    for(person of people){
        console.log(`Name: ${person.name}`);
        console.log(`Age: ${person.age}`);
        console.log(`Date: ${person.date}`);
    }
}