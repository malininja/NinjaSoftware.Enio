function setGridPage(newPageNo) {
    var sort = getParameterValue("sortField");
    var sortDir = getParameterValue("sortDirection");

    var url = this.location.pathname + "?";

    var isFirst = true;

    if ("" != sort || "" != sortDir) {
        url = url + "sortField=" + sort + "&sortDirection=" + sortDir;
        isFirst = false;
    }

    if (!isFirst) {
        url = url + "&";
    }

    url = url + "pageNumber=" + newPageNo;

    this.location.href = url;
}

function getParameterValue(name) {
    name = name.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
    var regexS = "[\\?&]" + name + "=([^&#]*)";
    var regex = new RegExp(regexS);
    var results = regex.exec(window.location.href);
    if (results == null)
        return "";
    else
        return results[1];
}