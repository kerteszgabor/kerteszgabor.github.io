function ToogleDarkMode() 
{
    var docBody = document.getElementById("body");
    var getBodiesCurrentClass = docBody.className;
    var buttonvar = document.getElementById("btn");
    if (getBodiesCurrentClass == "light-mode")
        {
            docBody.className = "dark-mode";
            document.getElementById("content").style.color= '#353942'
            buttonvar.innerHTML = "Light Mode";
            buttonvar.className = "btn text-center btn-light";
        }
    else
        {
            docBody.className = "light-mode";
            buttonvar.innerHTML = "Dark Mode";
            buttonvar.className = "btn text-center btn-dark";
        }
}