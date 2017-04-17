var realResize;

setTimeout(function () {
    realResize = true;
}, 500);

var imgAreaResponsizer = (function () {
    var imgElements = document.getElementsByTagName("img");
    var index = 0;
    var naturalWidth = [];
    var naturalHeight = [];
    var areaClassNames = [];
    var areaNodeLengths = [];
    var loadTimeCoords = [];

    var responsizerSetupComplete = function () {
        return imgElements.length == index;
    };

    var updateAreaCoords = function () {
        for (index = 0; index < imgElements.length; index++) {
            var mapName = imgElements[index].getAttribute("usemap");

            if (mapName) {
                var resizedCoords = calculateResizedAreaCoords(imgElements[index].clientWidth, imgElements[index].clientHeight);
                setAreaCoords(document.getElementsByClassName(areaClassNames[index]), resizedCoords);
            }
        }
    };

    var initialSetupAndUpdateOfAreaCoords = function () {
        for (index = 0; index < imgElements.length; index++) {
            var mapName = imgElements[index].getAttribute("usemap");

            if (mapName) {
                initializeImageSizes();
                initializeAreaNodes(mapName);
                var resizedCoords = calculateResizedAreaCoords(imgElements[index].clientWidth, imgElements[index].clientHeight);
                setAreaCoords(document.getElementsByClassName(areaClassNames[index]), resizedCoords);
            }
            else {
                naturalWidth.push(null);
                naturalHeight.push(null);
                areaClassNames.push(null);
                areaNodeLengths.push(0);
            }
        }
    };

    var initializeImageSizes = function () {
        naturalWidth.push(imgElements[index].naturalWidth);
        naturalHeight.push(imgElements[index].naturalHeight);
    };

    var initializeAreaNodes = function (mapName) {
        var nodes = document.getElementsByName(mapName.replace("#", ""))[0].children;
        areaClassNames.push(nodes[0].className);
        areaNodeLengths.push(nodes.length);
        for (var i = 0; i < nodes.length; i++) {
            loadTimeCoords.push(nodes[i].getAttribute("coords"));
        }
    };

    var calculateResizedAreaCoords = function (imgWidth, imgHeight) {
        var resizedAreaCoords = [];
        var beginningIndex = getbeginningIndex();

        for (var i = beginningIndex; i < beginningIndex + areaNodeLengths[index]; i++) {
            var coordNumbers = convertStringsToNumbers(loadTimeCoords[i].split(","));
            var resizedCoordNumbers = calculateAreaCoordinateChanges(coordNumbers, imgWidth, imgHeight);
            resizedAreaCoords.push(resizedCoordNumbers.join());
        }
        return resizedAreaCoords;
    };

    var getbeginningIndex = function () {
        var beginningIndex = 0;
        if (index === 0) {
            return beginningIndex;
        }
        else {
            for (var i = 0; i < index; i++) {
                beginningIndex += areaNodeLengths[i];
            }
            return beginningIndex;
        }
    };

    var convertStringsToNumbers = function (strings) {
        var numbers = [];
        strings.forEach(function (element) {
            numbers.push(Number(element));
        });
        return numbers;
    };

    var calculateAreaCoordinateChanges = function (Coordinates, imgWidth, imgHeight) {
        var changes = [];
        for (var i = 0; i < Coordinates.length; i++) {
            if (i % 2 === 0) {
                changes.push(Math.floor(imgHeight * Coordinates[i] / naturalHeight[index]));
            }
            else {
                changes.push(Math.floor(imgWidth * Coordinates[i] / naturalWidth[index]));
            }
        }
        return changes;
    };

    var setAreaCoords = function (AreaElements, AreaCoords) {
        for (var i = 0; i < AreaElements.length; i++) {
            AreaElements[i].setAttribute("coords", AreaCoords[i]);
        }
    };

    return function () {
        if (responsizerSetupComplete()) {
            updateAreaCoords();
        }
        else {
            initialSetupAndUpdateOfAreaCoords();
        }
    };
})();