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

function deleteElement() {
    this.parentNode.parentNode.removeChild(this.parentNode);
}

function loadEditView() {
    //makes all edit-specific items visible
    var editElements = document.getElementsByClassName("editView");
    for (var i = 0; i < editElements.length; ++i) {
        editElements[i].style.visibility = "visible";
    }
    //adds events to the X buttons to remove items
    var closeBtns = document.getElementsByClassName("editCloseBtn");
    for (var i = 0; i < closeBtns.length; ++i) {
        closeBtns[i].addEventListener('click', deleteElement, false);
    }
}

function loadFunction() {
    //TEMP UNTIL LOGIN FUNCTIONALITY IMPLEMENTATION
    loadEditView();
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
//function for font colors/////////////////////////////////////////
//var
//    red = document.getElementById("red"),
//    blue = document.getElementById("blue");
//red.addEventListener("click", function () { setColor("#ff0000") });
//blue.addEventListener("click", function () { setColor("#0000ff") });
function setColor(color) {
    document.execCommand('styleWithCSS', false, true);
    document.execCommand('foreColor', false, color);
}

function DblClick() {
    document.getElementsByClassName('dropdown').show();
    //italics
    //document.execCommand('italic', false, null);
    //bold
    //document.execCommand('bold', false, null);
    //font color
    //colors();
}

function colors() {
    //font color - RED
    document.execCommand('foreColor', false, '#ff0000');
}

/////////////////////////////////////////////////////////////////////

function createDeleteBtn() {
    var newDiv = document.createElement("DIV");
    newDiv.setAttribute("class", "editCloseBtn editView");
    newDiv.addEventListener("click", deleteElement, false);
    newDiv.innerHTML = "X";
    return newDiv;
}

function addStaff() {
    var insertedSection = document.createElement("SECTION");
    insertedSection.setAttribute("class", "col-xs-12 col-md-4");

    var insertedParagraph = document.createElement("P");

    var staffPic = document.createElement("IMG");
    staffPic.setAttribute("class", "img-responsive");
    staffPic.setAttribute("src", "../resources/staff_alyson.jpg");

    var staffName = document.createElement("SPAN");
    staffName.setAttribute("class", "name");
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

    insertedSection.appendChild(createDeleteBtn());

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

    insertedSection.appendChild(createDeleteBtn());

    insertedSection.appendChild(insertedParagraph);

    var staff = document.getElementsByClassName("board_members");
    staff[0].appendChild(insertedSection);
}

function addPlatDonor() {
    var platCnt = document.getElementsByClassName("plat").length;
    var platDonors = document.getElementsByClassName("plat")[platCnt - 1].parentElement;

    var insertedDonor = document.createElement("DIV");
    insertedDonor.setAttribute("class", "col-xs-4");
    insertedDonor.className += " donor_box";
    insertedDonor.className += " plat";

    var donorName = document.createElement("P");
    donorName.setAttribute("class", "donor_name");
    donorName.innerHTML = "DONOR NAME";

    var donorYear = document.createElement("P");
    donorYear.setAttribute("class", "year");
    donorYear.innerHTML = "DONOR YEAR";

    insertedDonor.appendChild(createDeleteBtn());
    insertedDonor.appendChild(donorName);
    insertedDonor.appendChild(donorYear);
    
    platDonors.appendChild(insertedDonor);
}

function addGoldDonor() {
    var goldCnt = document.getElementsByClassName("gold").length;
    var goldDonors = document.getElementsByClassName("gold")[goldCnt - 1].parentElement;

    var insertedDonor = document.createElement("DIV");
    insertedDonor.setAttribute("class", "col-xs-4");
    insertedDonor.className += " donor_box";
    insertedDonor.className += " gold";

    var donorName = document.createElement("P");
    donorName.setAttribute("class", "donor_name");
    donorName.innerHTML = "DONOR NAME";

    var donorYear = document.createElement("P");
    donorYear.setAttribute("class", "year");
    donorYear.innerHTML = "DONOR YEAR";

    insertedDonor.appendChild(createDeleteBtn());
    insertedDonor.appendChild(donorName);
    insertedDonor.appendChild(donorYear);

    goldDonors.appendChild(insertedDonor);
}

function addSilverDonor() {
    var silverCnt = document.getElementsByClassName("silver").length;
    var silverDonors = document.getElementsByClassName("silver")[silverCnt - 1].parentElement;

    var insertedDonor = document.createElement("DIV");
    insertedDonor.setAttribute("class", "col-xs-4");
    insertedDonor.className += " donor_box";
    insertedDonor.className += " silver";

    var donorName = document.createElement("P");
    donorName.setAttribute("class", "donor_name");
    donorName.innerHTML = "DONOR NAME";

    var donorYear = document.createElement("P");
    donorYear.setAttribute("class", "year");
    donorYear.innerHTML = "DONOR YEAR";

    insertedDonor.appendChild(createDeleteBtn());
    insertedDonor.appendChild(donorName);
    insertedDonor.appendChild(donorYear);

    silverDonors.appendChild(insertedDonor);
}

function addBronzeDonor() {
    var bronzeCnt = document.getElementsByClassName("bronze").length;
    var bronzeDonors = document.getElementsByClassName("bronze")[bronzeCnt - 1].parentElement;

    var insertedDonor = document.createElement("DIV");
    insertedDonor.setAttribute("class", "col-xs-4");
    insertedDonor.className += " donor_box";
    insertedDonor.className += " bronze";

    var donorName = document.createElement("P");
    donorName.setAttribute("class", "donor_name");
    donorName.innerHTML = "DONOR NAME";

    var donorYear = document.createElement("P");
    donorYear.setAttribute("class", "year");
    donorYear.innerHTML = "DONOR YEAR";

    insertedDonor.appendChild(createDeleteBtn());
    insertedDonor.appendChild(donorName);
    insertedDonor.appendChild(donorYear);

    bronzeDonors.appendChild(insertedDonor);
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

function loginCreds() {
    var username = $('#uname').val();
    var password = $('#psw').val();
    var data = new Object();
    data.username = $('#uname').val();
    data.password = $('#psw').val();

    jQuery.ajax({
        type: "POST",
        url: "Home/Login",
        dataType: "json",
        contentType: "application/json; charset=utf=8",
        data: JSON.stringify({ username, password }),
        success: function (result) {
            if (result == "pass") {
                $('#editBtnEdit').css("display", "block");
                //$("#editBtnEdit").show();
                loadEditView();
                location.reload();
                alert("Login Successful");
            }
            else {
                $('#editBtnEdit').css("display", "none");
                //$("#editBtnEdit").hide();
                alert("Invalid Credentials");
            }
        },
        failure: function (username, password) {
            alert("Not successful");
        }

    });
    location.reload();
    $(document).ready(function () {
    })
}

// Places the html inside the body tag
function PostPageByID(id){
    //var query = null;
    //if (Number.isInteger(id)) {
    //    query = "SELECT PageHtml FROM dbo.Page WHERE PageID = " + id;
    //}
    //document.getElementsByTagName("body")[0].innerHTML = "";
}
