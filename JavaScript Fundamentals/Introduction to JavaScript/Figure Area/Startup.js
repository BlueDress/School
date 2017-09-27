function calculateArea(firstWidth, firstHeight, secondWidth, secondHeight) {
    let firstArea = firstWidth * firstHeight;
    let secondArea = secondWidth * secondHeight;
    let commonArea = Math.min(firstWidth, secondWidth) * Math.min(firstHeight, secondHeight);

    let totalArea = firstArea + secondArea - commonArea;

    console.log(totalArea);
}