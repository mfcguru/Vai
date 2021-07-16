var GLOBAL = {};
GLOBAL.DotNetReference = null;
GLOBAL.SetDotnetReference = function (pDotNetReference) {
    GLOBAL.DotNetReference = pDotNetReference;
};


window.onresize = executeOnResize;

function executeOnResize() {
    callDotnetHandlePaginationDivOverflow();
}

function callDotnetHandlePaginationDivOverflow() {
    GLOBAL.DotNetReference.invokeMethodAsync("HandlePaginationDivOverflow");
}

function isOverflowing(id) {
    var el = document.getElementById(id);
    var isOverflowing = el.clientHeight > 43;

    return isOverflowing;
}