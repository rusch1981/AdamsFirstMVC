function mouseClicked(buttonName) {
    switch (buttonName) {
        case 'aboutButton': {
            document.images[buttonName].src = "../../images/FlatterButton100px.png";
            break;
        }
        case 'bandsButton': {
            document.images[buttonName].src = "../../images/FlatterButton100px.png";
            break;
        }
        case 'contactButton': {
            document.images[buttonName].src = "../../images/FlatterButton100px.png";
            break;
        }
        default:
            break;
    }

}
function mouseUnclicked(buttonName) {
    switch (buttonName) {
        case 'aboutButton': {
            document.images[buttonName].src = "../../images/BeveledButton100px.png";
            break;
        }
        case 'bandsButton': {
            document.images[buttonName].src = "../../images/BeveledButton100px.png";
            break;
        }
        case 'contactButton': {
            document.images[buttonName].src = "../../images/BeveledButton100px.png";
            break;
        }
        default:
            break;
    }
}