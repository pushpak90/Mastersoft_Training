$(document).ready(function () {
    console.log("Download excel");
})

$('#btnReport').click(function () {
    //exportListToExcel(myList, "Done");

    $.ajax({
        url: "WebForm1.aspx/Excel",
        type: "POST",
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        //data: JSON.stringify(obj),
        success: function (data) {
            var myList = [];
            for (var i = 0; i < data['d'].length; i++) {
                var item = {};
                item.ID = data.d[i].Column1;
                item.Name = data.d[i].Column2;
                item.lastName= data.d[i].Column3;
                item.Subject = data.d[i].Column4;
                item.College = data.d[i].Column5;
                item.Column6 = data.d[i].Column6;
                item.Column7 = data.d[i].Column7;
                item.Column8 = data.d[i].Column8;
                item.Column9 = data.d[i].Column9;
                item.Column10 = data.d[i].Column10;

                myList.push(item);
            }
            exportListToExcel(myList, "Done")
        },
        error: function (errResponse) {
            console.log(errResponse);
        }
    });

})


function exportListToExcel(listData, fileName) {
    // Create a new script element for SheetJS (XLSX)
    var scriptElement = document.createElement('script');
    scriptElement.src = 'https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.17.3/xlsx.full.min.js';

    // Define a callback function to be executed after the script is loaded
    scriptElement.onload = function () {
        // XLSX library is now loaded and available for use
        console.log('XLSX library loaded successfully');

        // Create a new workbook and worksheet
        var wb = XLSX.utils.book_new();
        var ws = XLSX.utils.json_to_sheet(listData);

        // Add the worksheet to the workbook
        XLSX.utils.book_append_sheet(wb, ws, 'Sheet1');

        // Convert the workbook to a binary string
        var wbBinary = XLSX.write(wb, { bookType: 'xlsx', type: 'binary' });

        // Convert the binary string to a Blob
        var wbBlob = new Blob([s2ab(wbBinary)], { type: 'application/octet-stream' });

        // Create a temporary download link and trigger the download
        var downloadLink = document.createElement('a');
        downloadLink.href = URL.createObjectURL(wbBlob);
        downloadLink.download = fileName + '.xlsx';
        document.body.appendChild(downloadLink);
        downloadLink.click();
        document.body.removeChild(downloadLink);
    };

    // Append the script element to the document to load the XLSX library
    document.head.appendChild(scriptElement);
}

// Utility function to convert binary string to ArrayBuffer
function s2ab(s) {
    var buf = new ArrayBuffer(s.length);
    var view = new Uint8Array(buf);
    for (var i = 0; i < s.length; i++) view[i] = s.charCodeAt(i) & 0xff;
    return buf;
}

// Example list data
//var myList = [
//    { Name: 'John Doe', Age: 30, Email: 'john.doe@example.com' },
//    { Name: 'Jane Smith', Age: 25, Email: 'jane.smith@example.com' }
//];

// Example usage: exportListToExcel(myList, 'myListData');
