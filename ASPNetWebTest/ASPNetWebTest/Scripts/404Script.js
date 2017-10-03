function toggleView() {
    var viewBox = document.getElementById("attributeViewBox");
    var toggleView = document.getElementById("toggleView");
    if (viewBox.style.width == "0px") {
        viewBox.style.width = "300px";
        toggleView.style.right = "300px";
        console.log("start 0");
    } else if (viewBox.style.width == "300px") {
        viewBox.style.width = "0px";
        toggleView.style.right = "0px";
        console.log("start 300");
    }
}