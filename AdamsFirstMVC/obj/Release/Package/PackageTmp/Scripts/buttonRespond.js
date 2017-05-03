function mouseClicked(buttonName) {
    switch (buttonName) {
        case 'aboutButton': {
            document.images[buttonName].src = "../../images/missionflatterbutton.jpg";
            break;
        }
        case 'bandsButton': {
            document.images[buttonName].src = "../../images/musicflatterbutton.jpg";
            break;
        }
        case 'dJButton':
            {
                document.images[buttonName].src = "../../images/djsbeveledbutton.jpg";
                break;
            }
        case 'contactButton': {
            document.images[buttonName].src = "../../images/contactflatterbutton.jpg";
            break;
        }
        default:
            break;
    }

}
function mouseUnclicked(buttonName) {
    switch (buttonName) {
        case 'aboutButton': {
            document.images[buttonName].src = "../../images/missionflatterbutton.jpg";
            break;
        }
        case 'bandsButton': {
            document.images[buttonName].src = "../../images/musicflatterbutton.jpg";
            break;
        }
        case 'dJButton':
            {
                document.images[buttonName].src = "../../images/djsflatterbutton.jpg";
                break;
            }
        case 'contactButton': {
            document.images[buttonName].src = "../../images/contactflatterbutton.jpg";
            break;
        }
        default:
            break;
    }
}