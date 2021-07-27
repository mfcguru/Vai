var ActionReference = null;
var BacklogReference = null;

function SetActionReference(pDotNetReference) {
    ActionReference = pDotNetReference;
}

function SetBacklogReference(pDotNetReference) {
    BacklogReference = pDotNetReference;
}

window.onresize = executeOnResize;

function executeOnResize() {
    callBacklogHandlePaginationDivOverflow();
    callActionHandlePaginationDivOverflow();
}

function callActionHandlePaginationDivOverflow() {
    ActionReference.invokeMethodAsync("HandleButtonSlideLeft");
}

function callBacklogHandlePaginationDivOverflow() {
    BacklogReference.invokeMethodAsync("HandleButtonSlideLeft");
}

function checkTablePaginationScrollLeft(id) {
    var el = document.getElementById(id);
    var isOverflowing = el.clientWidth < el.scrollWidth;

    return isOverflowing;
}

function checkClickedBox(id) {
    document.getElementById(id).checked = true;
}