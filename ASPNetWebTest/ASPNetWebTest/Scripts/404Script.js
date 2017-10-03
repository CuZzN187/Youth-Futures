function toggleView() {
    var attrViewBox = document.getElementById("attributeViewBox");
    var viewToggle = document.getElementById("toggleView");
    var btnSub = document.getElementById("btnSubmit");
    if (attrViewBox.style.visibility == "visible") {
        attrViewBox.style.visibility = "hidden";
        viewToggle.style.right = "0px";
        btnSub.style.visibility = "hidden";
    } else if (attrViewBox.style.visibility == "hidden") {
        attrViewBox.style.visibility = "visible";
        viewToggle.style.right = "300px";
        btnSub.style.visibility = "visible";
    }
}

function loadElementsToEditView() {
    var nameBox = document.getElementById("elementName");
    nameBox.innerHTML = this.innerHTML; //incorrect targetting of right-side assignment
}

//loops through img and p tags in the page and adds an event handler to load for edit view
function eventLoader() {
    var p = document.getElementsByName("p");
    for (var i = 0; i < p.length; ++i) {
        p[i].addEventListener("click", loadElementsToEditView());
    }
    var img = document.getElementsByTagName("img");
    for (var i = 0; i < img.length; ++i) {
        img[i].addEventListener("click", loadElementsToEditView());
    }
}

function loadBigHi() {
    document.getElementById("elementName").children[1].innerHTML = "HI";
    document.getElementById("elementAttr1").children[1].innerHTML = "quicksand-bold";
    document.getElementById("elementAttr2").children[1].innerHTML = "rgb(255, 255, 255)";
    document.getElementById("elementAttr3").children[1].innerHTML = "214px";
}

function loadBeds() {
    document.getElementById("elementName").children[1].innerHTML = "14 WARM BEDS. YOUTH 12-17. YOUR TEMPORARY HOME";
    document.getElementById("elementAttr1").children[1].innerHTML = "quicksand-bold";
    document.getElementById("elementAttr2").children[1].innerHTML = "rgb(71, 71, 71)";
    document.getElementById("elementAttr3").children[1].innerHTML = "38px";
}

function loadContact() {
    document.getElementById("elementName").children[1].innerHTML = "Have questions? Send us a text!";
    document.getElementById("elementAttr1").children[1].innerHTML = "montserrat-semibold";
    document.getElementById("elementAttr2").children[1].innerHTML = "rgb(255, 255, 255)";
    document.getElementById("elementAttr3").children[1].innerHTML = "36px";
}