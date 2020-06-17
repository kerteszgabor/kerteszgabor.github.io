function ToogleDarkMode() 
{
    var docBody = document.getElementById("body");
    var getBodiesCurrentClass = docBody.className;
    var buttonvar = document.getElementById("btn");
    var getContents = document.getElementById("content");
    var getTables = document.getElementById("table");
    if (getBodiesCurrentClass == "light-mode")
        {
            docBody.className = "dark-mode";
            getContents.style.color= '#d8dbe3';
            buttonvar.innerHTML = "Light Mode";
            buttonvar.className = "btn text-center btn-light";
            getContents.classList += " dark-mode";
            getTables.classList = " table table-dark";
        }
    else
        {
            getContents.classList += " light-mode";
            getContents.style.color = '#111';
            docBody.className = "light-mode";
            buttonvar.innerHTML = "Dark Mode";
            buttonvar.className = "btn text-center btn-dark";
            getTables.classList = " table";
        }
}