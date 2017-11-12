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
        getPageHtml();
        document.getElementsByClassName("sidebar")[0].style.width = "0";
        editor.contentEditable = 'false';
        button.style.backgroundColor = "#F96";
        button.innerHTML = 'Enable Editing';
        //document.designMode = "off";
        savePageToDB();
    } else {
        document.getElementsByClassName("sidebar")[0].style.width = "250px";
        editor.contentEditable = 'true';
        document.getElementById("sideEdit").contentEditable = "false";
        button.style.backgroundColor = "#6F9";
        button.innerHTML = 'Save Changes';
        //document.designMode = "on";
    }
}
//function for bold - double click to bold -- for now
function Bold() {
    document.execCommand('bold', false, null);
}

function addStaff() {
    var insertedSection = document.createElement("SECTION");
    insertedSection.setAttribute("class", "col-xs-12 col-md-4");

    var insertedParagraph = document.createElement("P");

    var staffPic = document.createElement("IMG");
    staffPic.setAttribute("class", "img-responsive");
    staffPic.setAttribute("src", "../resources/staff_alyson.jpg");

    var staffName = document.createElement("SPAN");
    staffName.setAttribute("class", "name")
    staffName.innerHTML = "NEW STAFF NAME";

    var staffTitle = document.createTextNode("STAFF TITLE");
    var staffDesc = document.createTextNode("STAFF DESCRIPTION");

    var staffEmail = document.createElement("SPAN");
    staffEmail.innerHTML = "STAFF EMAIL";

    insertedParagraph.appendChild(staffName);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(staffTitle);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(staffDesc);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(staffEmail);

    insertedSection.appendChild(staffPic);
    
    insertedSection.appendChild(insertedParagraph);

    var staff = document.getElementsByClassName("board_members");

    //document.getElementById("btnAddStaff").insertBefore(insertedElement, staff[1].childNodes.length);
    staff[1].appendChild(insertedSection);
}

function addDirector() {
    var insertedSection = document.createElement("SECTION");
    insertedSection.setAttribute("class", "col-xs-12 col-md-4");

    var insertedParagraph = document.createElement("P");

    var directorName = document.createElement("SPAN");
    directorName.setAttribute("class", "name");
    directorName.innerHTML = "DIRECTOR NAME";

    var directorTitle = document.createTextNode("DIRECTOR TITLE");
    var directorDesc = document.createTextNode("DIRECTOR DESCRIPTION");
    var directorEmail = document.createElement("SPAN");
    directorEmail.setAttribute("class", "email");

    insertedParagraph.appendChild(directorName);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(directorTitle);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(directorDesc);
    insertedParagraph.appendChild(document.createElement("BR"));
    insertedParagraph.appendChild(directorEmail);

    insertedSection.appendChild(insertedParagraph);

    var staff = document.getElementsByClassName("board_members");
    staff[0].appendChild(insertedSection);
}

function getPageHtml() {
    //gets the html of the current page and puts it into the page variable
    var page = document.getElementById("main-body").outerHTML.toString();
    return page;
}

function getPageIndex() {
    var url = document.URL;
    var index = 1;
    if (url.includes("Home/Programs")) {
        index = 2;
    }
    else if (url.includes("Home/Involved")) {
        // Not editable yet....
        // Index 6..
        index = 0;
    }
    else if (url.includes("Home/About")) {
        index = 3;
    }
    else if (url.includes("Home/Contact")) {
        index = 4;
    }
    else if (url.includes("Home/Donate")) {
        index = 5;
    }
    return index;
}

function savePageToDB() {
    var bodyHTML = getPageHtml();
    var index = getPageIndex();
    //TODO: save to db
    if (index != 0) {
        $.post("",
        {
            html: bodyHTML.toString()
        },
        function (data, status) {
        });
    }
    else {
        alert("ERROR");
    }
}

function getModalName() {
    console.log(document.getElementsByTagName("input")[0].value);
}

// Places the html inside the body tag
function PostPageByID(id){
    //var query = null;
    //if (Number.isInteger(id)) {
    //    query = "SELECT PageHtml FROM dbo.Page WHERE PageID = " + id;
    //}
    //document.getElementsByTagName("body")[0].innerHTML = "";
}
