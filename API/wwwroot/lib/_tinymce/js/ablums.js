var ListItemsAlbums = [];

function AddItemAlbums() {
   

    var max = parseInt($("#maxfile").val()) + 1;
    var img = '/images/no-image.png';
    var row = '<tr >';
    row = row + '<td><a onclick="ShowManagerFile(\'FileName_' + max + '\')" type="button" class="btn btn-primary">Chọn File</a></td>';
    row = row + '<td>' + "<img height='64px' width='64px' class='FileName_" + max + "_Preview' id='FileName_" + max + "_Preview' src='" + img + "' />" + ' <input type="hidden" id="FileName_' + max + '" name="ListItemsAlbums[' + max + '].Images" value="' + img + '"/></td>';
    row = row + '<td><input onchange="UpdateDataItemAlbums(' + max + ',1,event)" name="ListItemsAlbums[' + max + '].Title" class="form-control" placeholder="Tiêu Đề" value="" /></td>';
    row = row + '<td><input type="number" onchange="UpdateDataItemAlbums(' + max + ',2,event)" name="ListItemsAlbums[' + max + '].Ordering"  class="form-control"  value="' + max +'"/></td>';
    row = row + '<td><span class="btn btn-danger" onclick="DeleteItemAlbums(' + max + ')">Xóa</span> <input type="hidden" name="ListItemsAlbums[' + max + '].Status" value="true"/> <input type="hidden" name="ListItemsAlbums[' + max + '].Id" value="0"/>';
    row = row + '<input type="hidden" name="ListItemsAlbums[' + max + '].Deleted" value="false"/>';
    row = row + '</td>';
    row = row + '</tr>';
    $("#tbAlbums tbody").append(row);

    $("#maxfile").val(max);
}
function DeleteItemAlbums(i) {

}
