var TinyDataListItem = { ListBreadcrumb: [], ListFolders: [], ListFiles: [] };
    tinymce.init({
        selector: '.full-textarea',
        language: 'vi',
		height: 500,
        image_uploadtab: false,
        relative_urls: false,
        remove_script_host: false,
        convert_urls: false,
        plugins: 'print preview powerpaste importcss searchreplace case autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor tableofcontents insertdatetime advlist lists wordcount imagetools text_patterns noneditable help charmap emoticons',
        imagetools_cors_hosts: ['picsum.photos'],
        menubar: 'file edit view insert format tools table help casechange',
        toolbar: 'undo redo | bold italic underline strikethrough case | fontselect fontsize blocks | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl | powerpaste pastetext | table tabledelete | tableprops tablerowprops tablecellprops | tableinsertrowbefore tableinsertrowafter tabledeleterow | tableinsertcolbefore tableinsertcolafter tabledeletecol',
        toolbar_sticky: true,
        paste_as_text: true,
        templates: [
            { title: 'Slideshow', description: 'Tạo bảng cho slideshow', content: '<div class="mceTmpl"><table width="98%%"  border="0" cellspacing="0" cellpadding="0"><tr><th scope="col"> </th><th scope="col"> </th></tr><tr><td> </td><td> </td></tr></table></div>' },
           
        ],        
        
        //fontsize_formats: '8pt 10pt 12pt 13pt 14pt 16pt 18pt 24pt 36pt 48pt',
        font_size_formats: "6pt 8pt 9pt 10pt 11pt 12pt 13pt 14pt 15pt 16pt 17pt 18pt 19pt 20pt 21pt 22pt 23pt 24pt 30pt 36pt 48pt 60pt 72pt 96pt",
        extended_valid_elements: 'table[class=table table-bordered|style=width:"100%"]',
        file_picker_callback: function (callback, value, meta) {
            
            TinyGetListItems();
            $('#tinymce_insert').modal('show');
            $('.btn-insert-file').hide();
            $('.tiny-insert-file').show();
            $('#TinyMangerFileType').val("1");

            var path = "";

            jQuery(".tiny-insert-file").on("click", function () {
                 
                path = $("#TinySelectPath").val();
                console.log("path", path);
                
                if (meta.filetype == 'file') {
                    callback(path, { text: $("#TinySelectNameFile").val() });
                } else if (meta.filetype == 'image') {

                    callback(path, { alt: $("#TinySelectNameFile").val(), width: "100%", height:"100%" });
                } else if (meta.filetype == 'media') {
                    callback(path, { /*source2: 'alt.ogg', poster: 'image.jpg'*/ });
                } else {
                    callback(path, { /*source2: 'alt.ogg', poster: 'image.jpg'*/ });
                }

                $('#tinymce_insert').modal('hide');
            });

            

            
        },
        file_picker_types: 'file image media',
        images_upload_handler: function (blobInfo, success, failure) {
            var xhr, formData;

            xhr = new XMLHttpRequest();
            xhr.withCredentials = false;
            xhr.open('POST', '/Home/UploadImage');
            xhr.onload = function () {
                var json;

                if (xhr.status != 200) {
                    failure('HTTP Error: ' + xhr.status);
                    return;
                }

                json = JSON.parse(xhr.responseText);

                if (!json || typeof json.file_path != 'string') {
                    failure('Invalid JSON: ' + xhr.responseText);
                    return;
                }
                success(json.file_path);
            };
            formData = new FormData();
            formData.append('file', blobInfo.blob(), blobInfo.filename());
            xhr.send(formData);
        },
        
    });


function TinyGetListItems(CurrentFolder = '/') {
    $("#TinySelectPath").val("");
    $("#tiny-alert").hide();
    $("#TinyCurrentFolder").val(CurrentFolder);

    $("#tinymce_content").html('<div  class="text-center"><div class="lds-dual-ring"></div></div>')
    var form = { Command: '', Lang: '', Type: '', CurrentFolder: CurrentFolder, Hash:''};
    var token = jQuery('input[name="__RequestVerificationToken"]').val();
    var headers = {};
    headers["RequestVerificationToken"] = token;
    
    $.ajax({
        type: "POST",
        url: '/Admin/ManagerFile/GetListItems',
        headers: headers,
        data: JSON.stringify(form),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {            
            
            htmlBreadcrumb = '<li><a onclick="TinyGetListItems(\'/\')"><i class="fas fa-home"></i></a></li>';
            htmlBreadcrumb = htmlBreadcrumb + '<li><span class="divider">/</span></li>';

            if (data.success) {
                //$("#TinyCurrentFolder").val(data.Data.TinyCurrentFolder);
                //TinyDataListItem = data.Data;
                //TinyBuildHtmlList(TinyDataListItem);
                //if (data.Data.ListBreadcrumb != null && data.Data.ListBreadcrumb.length > 0) {

                //    for (let i = 0; i < data.Data.ListBreadcrumb.length; i++) {

                //        if (data.Data.ListBreadcrumb[i].IsActive) {
                //            htmlBreadcrumb = htmlBreadcrumb + '<li class="active">' + data.Data.ListBreadcrumb[i].Name+'</li>';
                //            htmlBreadcrumb = htmlBreadcrumb + '<li><span class="divider">/</span></li>';
                //        } else {
                //            if (i == (data.Data.ListBreadcrumb.length-1)) {
                //                htmlBreadcrumb = htmlBreadcrumb + '<li >' + data.Data.ListBreadcrumb[i].Name + '</li>';
                //            } else {
                //                htmlBreadcrumb = htmlBreadcrumb + '<li ><a onclick="TinyGetListItems(\'' + data.Data.ListBreadcrumb[i].Path+'\')">' + data.Data.ListBreadcrumb[i].Name + '</a></li>';
                //                htmlBreadcrumb = htmlBreadcrumb + '<li><span class="divider">/</span></li>';
                //            }
                //        }
                //    }
                //}

                //$("#TinyBreadcrumb").html(htmlBreadcrumb);

                $("#TinyCurrentFolder").val(data.data.TinyCurrentFolder);
                TinyDataListItem = data.data;
                TinyBuildHtmlList(TinyDataListItem);
                if (data.data.listBreadcrumb != null && data.data.listBreadcrumb.length > 0) {

                    for (let i = 0; i < data.data.listBreadcrumb.length; i++) {

                        if (data.data.listBreadcrumb[i].isActive) {
                            htmlBreadcrumb = htmlBreadcrumb + '<li class="active">' + data.data.listBreadcrumb[i].name + '</li>';
                            htmlBreadcrumb = htmlBreadcrumb + '<li><span class="divider">/</span></li>';
                        } else {
                            if (i == (data.data.listBreadcrumb.length - 1)) {
                                htmlBreadcrumb = htmlBreadcrumb + '<li >' + data.data.listBreadcrumb[i].name + '</li>';
                            } else {
                                htmlBreadcrumb = htmlBreadcrumb + '<li ><a onclick="TinyGetListItems(\'' + data.data.listBreadcrumb[i].path + '\')">' + data.data.listBreadcrumb[i].name + '</a></li>';
                                htmlBreadcrumb = htmlBreadcrumb + '<li><span class="divider">/</span></li>';
                            }
                        }
                    }
                }

                $("#TinyBreadcrumb").html(htmlBreadcrumb);
                
               
            }
        },
        error: function () {
            $('.loadding-title').html("Lỗi khi tải file ...");
            console.log("lỗi");
            
        }
    });

   
}


function TinyGetItem(CurrentFolder = '/', n = 0) {
    $(".dir").removeClass("acctive");
    $(".dir_" + n.toString()).addClass("acctive");
    $("#TinySelectPath").val(CurrentFolder);
    var extension = $(".dir_" + n.toString()).data('extension'); //getter            
    $("#TinySelectNameFile").val($(".dir_" + n.toString() + " .box h4 a").text().replace("." + extension, ""));
}

function ShowFolderPlus() {
    $("#FormCreateFolder")[0].reset();
    $("#FormCreateFolder .invalid-feedback").hide();    
    $('#FolderPlus').modal('show');
}




function ShowUploadFile() {
    $("#TinyBodyUploadFile").html("<tr><td colspan='5' class='text-center'>Không có file Upload</td></tr>");
    $('#UploadFile').modal('show');
}

function TinyCreateFolder() {
    var FolderName = $("#TinyFolderName").val();
    var CurrentFolder = $("#TinyCurrentFolder").val();
    $("#FormCreateFolder .invalid-feedback").hide();

    if (FolderName == null || FolderName.trim() == '') {
        $("#TinyFolderName").removeClass("is-valid");
        $("#TinyFolderName").addClass("is-invalid");
        $("#FormCreateFolder .invalid-feedback").show();
    } else {
        var form = { Path: CurrentFolder, Name: FolderName };
        var token = jQuery('input[name="__RequestVerificationToken"]').val();
        var headers = {};
        headers["RequestVerificationToken"] = token;

        $.ajax({
            type: "POST",
            url: '/Admin/ManagerFile/CreateFolder',
            headers: headers,
            data: JSON.stringify(form),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                $("#TinyFolderName").val("");
                if (data.Success) {
                    $('#FolderPlus').modal('hide');
                    TinyGetListItems(CurrentFolder);
                } else {
                    $("#TinyFolderName").focus();
                    $("#TinyFolderName").removeClass("is-valid");
                    $("#TinyFolderName").addClass("is-invalid");
                    $("#FormCreateFolder .invalid-feedback").html(data.Msg);
                    $("#FormCreateFolder .invalid-feedback").show();
                }

            },
            error: function () {
                $('.loadding-title').html("Lỗi khi tải file ...");

            }
        });
    }

    
}

$("#TinyFolderName").keyup(function () {
    

    $("#TinyFolderName").val(string_to_slug($("#TinyFolderName").val()));
    var FolderName = $("#TinyFolderName").val();

    if (FolderName == null || FolderName.trim() == '') {
        $("#TinyFolderName").removeClass("is-valid");
        $("#TinyFolderName").addClass("is-invalid");
        $("#FormCreateFolder .invalid-feedback").show();
    } else {
        $("#TinyFolderName").removeClass("is-invalid");
        $("#TinyFolderName").addClass("is-valid");   
        $("#FormCreateFolder .invalid-feedback").hide();
    }
});



function TinyUploadFiles() {
    $("#TinyBodyUploadFile").html('<tr><td colspan="5" class="text-center">Đang tải file lên. Xin vui lòng đợi ...</td></tr>');
    var formData = new FormData();
    for (var i = 0; i < $('#TinyUploadFile')[0].files.length; ++i) {
        formData.append('file', $('#TinyUploadFile')[0].files[i]);
    }    
    var CurrentFolder = $("#TinyCurrentFolder").val();
    formData.append("CurrentFolder", CurrentFolder );

    $("#FormCreateFolder .invalid-feedback").hide();

    var token = jQuery('input[name="__RequestVerificationToken"]').val();
    var headers = {};
    headers["RequestVerificationToken"] = token;


    $.ajax({
        type: "POST",
        url: '/Admin/ManagerFile/UploadFiles',
        headers: headers,        
        data: formData,
        processData: false,  // tell jQuery not to process the data
        contentType: false,  // tell jQuery not to set contentType        
        success: function (data) {
            var html = "";
            var ListItems = [];
            if (data.Success) {
                TinyGetListItems(CurrentFolder);
                if (data.Data != null && data.Data.length > 0) {
                    ListItems = data.Data;
                    for (let i = 0; i < data.Data.length; i++)
                    {
                        html = html + "<tr>";
                        html = html + "<td scope='row'>" + (i + 1).toString() + "</td>";
                        if (ListItems[i].Selected) {
                            html = html + "<td scope='row'>" + ListItems[i].Name + "</td>";
                        } else {
                            html = html + "<td scope='row'>" + ListItems[i].Name + "<small class='text-danger'> (" + ListItems[i].Msg + ")</small></td>";
                        }  
                        
                        html = html + "<td scope='row'>" + ListItems[i].StrSize + "</td>";
                        if (ListItems[i].Selected) {
                            html = html + "<td scope='row' class='text-center'><i class='fas fa-check text-primary'></i></td>";
                        } else {
                            html = html + "<td scope='row' class='text-center'><i class='fas fa-times text-danger'></i></td>";
                        }                        
                        html = html + "</tr>";
                    }
                }
            } else {
                
            }
            $("#TinyBodyUploadFile").html(html);
        },
        error: function () {
            $('.loadding-title').html("Lỗi khi tải file ...");

        }
    });

}

$('#TinyUploadFile').change(function () {
    var names = [];
    var html = "";
    for (var i = 0; i < $(this).get(0).files.length; ++i) {
        html = html + "<tr>";
        html = html + "<td scope='row'>" + (i + 1).toString() + "</td>";        
        html = html + "<td scope='row'>" + $(this).get(0).files[i].name + "</td>";
        html = html + "<td scope='row'>" + $(this).get(0).files[i].size + "</td>";
        html = html + "<td scope='row' class='text-center'><i class='fas fa-check text-primary'></i></td>";
        html = html + "</tr>";
        console.log($(this).get(0).files[i]);
        names.push($(this).get(0).files[i].name);
        console.log(names[i]);
    }
    $("#TinyBodyUploadFile").html(html);
});

function TinyDelete(path,name,n,i)
{
    var urlPath = '/Admin/ManagerFile/DeleteFolder';
    var Msg = "Đang xóa folder <strong>" + name + "</strong> Xin vui lòng đơi";    
    if (i == 2) { urlPath = '/Admin/ManagerFile/DeleteFile';  Msg = "Đang xóa file <strong>" + name + "</strong> Xin vui lòng đơi";}           
    $("#tiny-alert").show();
    $("#tiny-alert .tiny-alert-msg").html(Msg);
    $("#tiny-alert .alert").removeClass("alert-danger");
    $("#tiny-alert .alert").addClass("alert-success");

    var token = jQuery('input[name="__RequestVerificationToken"]').val();
    var headers = {};
    headers["RequestVerificationToken"] = token;
    var form = { Path: path, Name: name };

    $.ajax({
        type: "POST",
        url: urlPath,
        headers: headers,
        data: JSON.stringify(form), 
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            
            $("#tinymce_body").animate({ scrollTop: 0 }, 600);
            $("#tiny-alert").show();

            $("#tiny-alert .tiny-alert-msg").html(data.Msg);
            if (data.Success == false) {
                $("#tiny-alert .alert").removeClass("alert-success");
                $("#tiny-alert .alert").addClass("alert-danger");
            } else {
                if (i == 1) {
                    $(".dir_folder_" + n.toString()).hide();
                } else {
                    $(".dir_" + n.toString()).hide();
                }
            }            
        },
        error: function () {
            Msg = "Bạn không có quyền. Xin vui lòng liên hệ với ban quản trị";   
            $("#tiny-alert .tiny-alert-msg").html(Msg);
            $("#tiny-alert .alert").removeClass("alert-success");
            $("#tiny-alert .alert").addClass("alert-danger");
        }
    });
}

function TinyShowRename(n, i) {
    $("#FormRename .invalid-feedback").hide();
    $("#FormRename")[0].reset();
    var name = "";
    var path = "";
    $("#Rename_N").val(n);
    $("#Rename_I").val(i);

    if (i == 1) {
        $("#FormRename .input-group-prepend").hide();
        name = $(".dir_folder_" + n.toString() + " .box h4 a").text();
        path = $("#TinyCurrentFolder").val() + name;
    } else if (i == 2) {
        var extension = $(".dir_" + n.toString()).data('extension'); //getter        
        name = $(".dir_" + n.toString() + " .box h4 a").text().replace("." + extension, "");      
        path = $("#TinyCurrentFolder").val() + name + "." + extension;
        $("#TinyRenameExtension").html("."+extension);
    }

    $("#Rename_Path").val(path);
    $('#TinyShowRename').modal('show');
    $("#TinyRenameName").val(name);
    
    

}

function TinyRename() {
    var token = jQuery('input[name="__RequestVerificationToken"]').val();
    var headers = {};
    headers["RequestVerificationToken"] = token;
    var name = $("#TinyRenameName").val();
    var path = $("#Rename_Path").val();
    var N =  $("#Rename_N").val();
    var I = $("#Rename_I").val();
    var name_old = "";
    if (I == 2) {
        var extension = $(".dir_" + N.toString()).data('extension'); //getter
        name = name + "." + extension;
        $("#FormRename .input-group-prepend").show();
        name_old = $(".dir_" + N.toString() + " .box h4 a").text().replace("." + extension, "");
    } else {
        name_old = name = $(".dir_folder_" + N.toString() + " .box h4 a").text();
    }
    if (name == name_old) {
        $("#FormRename .invalid-feedback").html("Tên Mới trùng với tên Cũ");
        $("#FormRename .invalid-feedback").show();
    } else {
        var form = { Path: path, Name: name, flag: I };

        $.ajax({
            type: "POST",
            url: '/Admin/ManagerFile/Rename',
            headers: headers,
            data: JSON.stringify(form),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                if (data.Success == false) {
                    $("#FormRename .invalid-feedback").html(data.Msg);
                    $("#FormRename .invalid-feedback").show();

                } else {
                    $('#TinyShowRename').modal('hide');
                    $("#FormRename")[0].reset();
                    if (I == 1) {
                        $(".dir_folder_" + N.toString() + " .box h4 a").text(name);
                    } else {
                        $(".dir_" + N.toString() + " .box h4 a").text(name);
                    }
                }
            },
            error: function () {
                Msg = "Bạn không có quyền. Xin vui lòng liên hệ với ban quản trị";
                $("#tiny-alert .tiny-alert-msg").html(Msg);
                $("#tiny-alert .alert").removeClass("alert-success");
                $("#tiny-alert .alert").addClass("alert-danger");
            }
        });
    }
    
}

function TinyAlertClose() {
    $("#tiny-alert").hide();
}

function TinyResetItems() {
    TinyGetListItems($("#TinyCurrentFolder").val());
}

function TinyHelper() {
    console.log(TinyDataListItem);
}

$("#tiny_filter_keyword").on("keyup", function () {
    TinySearchListItems();
});

function TinySearchListItems() {
    var keyword = $("#tiny_filter_keyword").val().toLowerCase();    
    if (TinyDataListItem.ListFolders != null && TinyDataListItem.ListFolders.length > 0) {
        for (let i = 0; i < TinyDataListItem.ListFolders.length; i++) {
            if (TinyDataListItem.ListFolders[i].Name.toLowerCase().indexOf(keyword) > -1) {
                $(".dir_folder_" + i.toString()).show();
            } else {
                $(".dir_folder_" + i.toString()).hide();
            }
        }
    }

    if (TinyDataListItem.ListFiles != null && TinyDataListItem.ListFiles.length > 0) {
        for (let i = 0; i < TinyDataListItem.ListFiles.length; i++) {
            if (TinyDataListItem.ListFiles[i].Name.toLowerCase().indexOf(keyword) > -1) {
                $(".dir_" + i.toString()).show();
            } else {
                $(".dir_" + i.toString()).hide();
            }
        }
    }
}
function TinyBuildHtmlList(Data) {
    console.log("Line 510: ", Data);
    var html = "";
    //if (Data.istFolders != null && Data.ListFolders.length > 0) {
    //    for (let i = 0; i < Data.ListFolders.length; i++) {
    //        html = html + "<li class='dir dir_folder_" + i.toString() + "'>";
    //        html = html + "<div class='tiny-directory' onclick='TinyGetListItems(\"" + Data.ListFolders[i].Path + "\")' data-name='" + Data.ListFolders[i].Name + "' data-path='" + Data.ListFolders[i].Path + "' data-pathparent='" + Data.ListFolders[i].PathParent + "'>";
    //        html = html + "<a  class='folder-link'>";
    //        html = html + "<img style='width:122px;height:91px;' src='" + Data.ListFolders[i].Img + "' class='directory-img loaded' data-src='" + Data.ListFolders[i].Img + "' />";
    //        html = html + "</a>";
    //        html = html + "</div>";
    //        html = html + "<div class='box' onclick='TinyGetListItems(\"" + Data.ListFolders[i].Path + "\")'>";
    //        html = html + "<h4><a >" + Data.ListFolders[i].Name + "</a></h4>";
    //        html = html + "</div>";
    //        html = html + "<div class='tiny-action'>";
    //        html = html + "<i class='fas fa-pencil-alt' onclick='TinyShowRename(" + i + ",1)'></i>";
    //        html = html + "<i class='fas fa-trash-alt' onclick='TinyDelete(\"" + Data.ListFolders[i].Path + "\",\"" + Data.ListFolders[i].Name + "\"," + i + ",1)'></i>";
    //        html = html + "</div>";
    //        html = html + "</li>";
    //    }



    //}

    //if (Data.ListFiles != null && Data.ListFiles.length > 0) {
    //    for (let i = 0; i < Data.ListFiles.length; i++) {
    //        html = html + "<li class='dir dir_file dir_" + i.toString() + "' data-pathparent='" + Data.ListFiles[i].PathParent + "' data-extension='" + Data.ListFiles[i].Extension + "'>";
    //        html = html + "<div class='tiny-directory' onclick='TinyGetItem(\"" + Data.ListFiles[i].Path + "\"," + i + ")' data-name='" + Data.ListFiles[i].Name + "' data-path='" + Data.ListFiles[i].Path + "' >";
    //        html = html + "<a  class='folder-link'>";
    //        html = html + "<img style='width:122px;height:91px;' src='" + Data.ListFiles[i].Img + "' class='directory-img loaded' data-src='" + Data.ListFiles[i].Img + "' />";
    //        html = html + "</a>";
    //        html = html + "</div>";
    //        html = html + "<div class='box ' onclick='TinyGetItem(\"" + Data.ListFiles[i].Path + "\"," + i + ")' data-path='" + Data.ListFiles[i].Path + "'>";
    //        html = html + "<h4><a >" + Data.ListFiles[i].Name + "</a></h4>";
    //        html = html + "</div>";
    //        html = html + "<div class='tiny-action'>";
    //        html = html + "<i class='fas fa-pencil-alt' onclick='TinyShowRename(" + i + ",2)'></i>";
    //        html = html + "<i class='fas fa-trash-alt' onclick='TinyDelete(\"" + Data.ListFiles[i].Path + "\",\"" + Data.ListFiles[i].Name + "\"," + i + ",2)'></i>";
    //        html = html + "</div>";
    //        html = html + "</li>";
    //    }
    //}


    if (Data.listFolders != null && Data.listFolders.length > 0) {
        for (let i = 0; i < Data.listFolders.length; i++) {
            html = html + "<li class='dir dir_folder_" + i.toString() + "'>";
            html = html + "<div class='tiny-directory' onclick='TinyGetListItems(\"" + Data.listFolders[i].path + "\")' data-name='" + Data.listFolders[i].name + "' data-path='" + Data.listFolders[i].path + "' data-pathparent='" + Data.listFolders[i].pathParent + "'>";
            html = html + "<a  class='folder-link'>";
            html = html + "<img style='width:122px;height:91px;' src='" + Data.listFolders[i].img + "' class='directory-img loaded' data-src='" + Data.listFolders[i].img + "' />";
            html = html + "</a>";
            html = html + "</div>";
            html = html + "<div class='box' onclick='TinyGetListItems(\"" + Data.listFolders[i].path + "\")'>";
            html = html + "<h4><a >" + Data.listFolders[i].name + "</a></h4>";
            html = html + "</div>";
            html = html + "<div class='tiny-action'>";
            html = html + "<i class='fas fa-pencil-alt' onclick='TinyShowRename(" + i + ",1)'></i>";
            html = html + "<i class='fas fa-trash-alt' onclick='TinyDelete(\"" + Data.listFolders[i].path + "\",\"" + Data.listFolders[i].name + "\"," + i + ",1)'></i>";
            html = html + "</div>";
            html = html + "</li>";
        }



    }

    if (Data.listFiles != null && Data.listFiles.length > 0) {
        for (let i = 0; i < Data.listFiles.length; i++) {
            html = html + "<li class='dir dir_file dir_" + i.toString() + "' data-pathparent='" + Data.listFiles[i].pathParent + "' data-extension='" + Data.listFiles[i].extension + "'>";
            html = html + "<div class='tiny-directory' onclick='TinyGetItem(\"" + Data.listFiles[i].path + "\"," + i + ")' data-name='" + Data.listFiles[i].name + "' data-path='" + Data.listFiles[i].path + "' >";
            html = html + "<a  class='folder-link'>";
            html = html + "<img style='width:122px;height:91px;' src='" + Data.listFiles[i].img + "' class='directory-img loaded' data-src='" + Data.listFiles[i].img + "' />";
            html = html + "</a>";
            html = html + "</div>";
            html = html + "<div class='box ' onclick='TinyGetItem(\"" + Data.listFiles[i].path + "\"," + i + ")' data-path='" + Data.listFiles[i].path + "'>";
            html = html + "<h4><a >" + Data.listFiles[i].name + "</a></h4>";
            html = html + "</div>";
            html = html + "<div class='tiny-action'>";
            html = html + "<i class='fas fa-pencil-alt' onclick='TinyShowRename(" + i + ",2)'></i>";
            html = html + "<i class='fas fa-trash-alt' onclick='TinyDelete(\"" + Data.listFiles[i].path + "\",\"" + Data.listFiles[i].name + "\"," + i + ",2)'></i>";
            html = html + "</div>";
            html = html + "</li>";
        }
    }

    $("#tinymce_content").html(html);
}



function ShowManagerFile(id='')
{
    $(".btn-insert-file").hide();
    $(".ouput-insert-file").show();
    $("#TinyOutputId").val(id);
    $('#TinyMangerFileType').val("2");
    TinyGetListItems();
    $('#tinymce_insert').modal('show');
}

function ManagerFileSelect()
{
    console.log("ManagerFileSelect");
    $('#tinymce_insert').modal('hide');
    var id = $("#TinyOutputId").val();    
    $("#" + id).val($("#TinySelectPath").val());
    $('.' + id + '_Preview').attr("src", $("#TinySelectPath").val());
}

function ViewImageMain(id) {
    //$('#MainShowImagePath').attr("src", "/images/no-image.png");
    $('#MainShowImage').modal('show');
    $('#MainShowImagePath').attr("src", $('#' + id).val());
}

