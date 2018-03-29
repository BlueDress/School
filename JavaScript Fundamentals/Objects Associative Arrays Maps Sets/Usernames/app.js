function createCatalogue(arr) {

    let catalogue = new Set();

    for (let i = 0; i < arr.length; i++) {

        catalogue.add(arr[i]);
    }
    
    for (let name of [...catalogue].sort(sortCatalogue)) {

        console.log(name);
    }

    function sortCatalogue(a, b) {

        let firstCriteria = a.length - b.length;

        if (firstCriteria !== 0) {

            return firstCriteria;
        }

        return a.localeCompare(b);
    }
}

createCatalogue(["Ashton", "Kutcher", "Ariel", "Lilly", "Keyden", "Aizen", "Billy", "Braston", "Lilly", "Keyden", "Aizen"]);