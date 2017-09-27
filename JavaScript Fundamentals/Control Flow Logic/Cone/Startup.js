function calculateConeVolumeAndSurfaceArea(radius, height) {
    console.log("volume = " + (Math.PI * radius * radius * height / 3).toFixed(4));
    console.log("area = " + (Math.PI * radius * (Math.sqrt((radius ** 2) + (height ** 2))) + (Math.PI * radius ** 2)).toFixed(4));
}