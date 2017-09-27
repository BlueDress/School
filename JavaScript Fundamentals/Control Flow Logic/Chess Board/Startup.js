function drawChessboard(number) {
    let color = "";
    let result = '<div class="chessboard">\n';

    for (let i = 1; i <= number; i++) {
        result += "  <div>\n";

        for (let j = 1; j <= number; j++) {
            if ((i + j) % 2 == 0) {
                color = "black";
            } else {
                color = "white";
            }

            result += `    <span class=${color}></span>\n`;
        }

        result += "  </div>\n";
    }

    result += "</div>\n";
    return result;
}

console.log(drawChessboard(3));