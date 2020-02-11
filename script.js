function ToogleDarkMode() 
{
    var docBody = document.getElementById("body");
    var getBodiesCurrentClass = docBody.className;
    var buttonvar = document.getElementById("btn");
    var getContents = document.getElementById("content");
    var getCards = document.getElementsByClassName("card");
    if (getBodiesCurrentClass == "light-mode")
        {
            docBody.className = "dark-mode";
            getContents.style.color= '#353942'
            buttonvar.innerHTML = "Light Mode";
            buttonvar.className = "btn text-center btn-light";
            getContents.classList = "row d-flex justify-content-center dark-mode";
            
            
            for(var i=0; i< getCards.length; i++){
                getCards[i].classList = "mb-4 card card-body text-white bg-dark";
            }
            
        }
    else
        {
            getContents.classList = "row d-flex justify-content-center light-mode";
            docBody.className = "light-mode";
            buttonvar.innerHTML = "Dark Mode";
            buttonvar.className = "btn text-center btn-dark";

            
            for(var i=0; i< getCards.length; i++){
                getCards[i].classList = "mb-4 card card-body bg-light";
            }
        }
}

