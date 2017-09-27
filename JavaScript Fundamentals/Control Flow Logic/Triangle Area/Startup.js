function calculateTriangleArea(firstSide, secondSide, thirdSide) {
    let sp = (firstSide + secondSide + thirdSide) / 2;
    return Math.sqrt(sp * (sp - firstSide) * (sp - secondSide) * (sp - thirdSide));
}