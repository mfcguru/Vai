var BacklogReference = null;

function SetBacklogReference (pDotNetReference) {
    BacklogReference = pDotNetReference;
};


window.onresize = executeOnResize;

function executeOnResize () {
    callDotnetHandleBacklogPaginationDivOverflow();
}

function callDotnetHandleBacklogPaginationDivOverflow () {
    BacklogReference.invokeMethodAsync("HandlePaginationDivOverflow");
}

function checkTablePaginationDivOverflow (id) {
    var el = document.getElementById(id);
    var isOverflowing = el.clientWidth < el.scrollWidth;

    return isOverflowing;
}