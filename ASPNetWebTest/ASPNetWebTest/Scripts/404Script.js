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

//a function
//that initiates the edit side bar
function myFunction() {
    var editor = document.getElementById("main-body");
    var button = document.getElementById("editBtnEdit");
    var coloring = document.getElementById("color");

    //allowing editing of all texts/links
    if (editor.isContentEditable) {
        document.getElementsByClassName("sidebar")[0].style.width = "0";
        editor.contentEditable = 'false';
        button.style.backgroundColor = "#F96";
        button.innerHTML = 'Enable Editing';
        document.designMode = "off";
    } else {
        document.getElementsByClassName("sidebar")[0].style.width = "250px";
        editor.contentEditable = 'true';
        button.style.backgroundColor = "#6F9";
        button.innerHTML = 'Save Changes';
        document.designMode = "on";
    }
}
//function for bold - double click to bold -- for now
function Bold() {
    document.execCommand('bold', false, null);
}

function addStaff() {
    var insertedElement = document.createElement("SECTION");
    insertedElement.setAttribute("class", "col-xs-12 col-md-4");

    var staffName = document.createTextNode("new Staff Name");
    staffName.className = "name";

    var staffBio = document.createTextNode("Testing texting");
    insertedElement.appendChild(staffName);
    insertedElement.appendChild(staffBio);

    var staff = document.getElementsByClassName("board_members");
    console.log(staff);
    staff[1].appendChild(insertedElement);
}
