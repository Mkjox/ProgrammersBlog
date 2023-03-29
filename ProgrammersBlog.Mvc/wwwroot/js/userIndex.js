﻿$(document).ready(function () {

    /* DataTables starts here */


    const dataTable = $('#usersTable').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Ekle',
                attr: {
                    id: "btnAdd",

                },
                className: 'btn btn-success',
                action: function (e, dt, node, config) {
                }
            },
            {
                text: 'Yenile',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    $.ajax({
                        type: 'GET',
                        url: '/Admin/User/GetAllUsers/',
                        contentType: "application/json",
                        beforeSend: function () {
                            $('#usersTable').hide();
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const userListDto = jQuery.parseJSON(data);
                            console.log(userListDto);
                            if (userListDto.ResultStatus === 0) {
                                let tableBody = "";
                                $.each(userListDto.Users.$values,
                                    function (index, user) {
                                        tableBody += `
                                                                                                    <tr>
                                                                                                            <td>${user.Id}</td>
                                                                                                            <td>${user.Name}</td>
                                                                                                            <td>${user.Description}</td>
                                                                                                            <td>${convertFirstLetterToUpperCase(user.IsActive.toString())}</td>
                                                                                                            <td>${convertFirstLetterToUpperCase(user.IsDeleted.toString())}</td>
                                                                                                            <td>${user.Note}</td>
                                                                                                            <td>${convertToShortDate(user.CreatedDate)}</td>
                                                                                                            <td>${user.CreatedByName}</td>
                                                                                                            <td>${convertToShortDate(user.ModifiedDate)}</td>
                                                                                                            <td>${user.ModifiedByName}</td>
                                                                                                                    <td>
                                                                    <button class="btn btn-primary btn-sm btn-block btn-update" data-id="${user.Id}"><span class="fas fa-edit"></span>Düzenle</button>
                                                                    <button class="btn btn-danger btn-sm btn-block btn-delete" data-id="${user.Id}"><span class="fas fa-minus-circle"></span>Sil</button>
                                                                </td>
                                                                                                    </tr>`;
                                    });
                                $('#usersTable > tbody').replaceWith(tableBody);
                                $('.spinner-border').hide();
                                $('#usersTable').fadeIn(1400);
                            }
                            else {
                                toastr.error(`${userListDto.Message}`, 'İşlem Başarısız!');

                            }
                        },
                        error: function (err) {
                            console.log(err);
                            $('.spinner-border').hide();
                            $('#usersTable').fadeIn(1000);
                            toastr.error(`${err.responseText}`, 'Hata!');
                        }
                    })
                }
            }
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });

    /* DataTables ends here */

    /* Ajax GET / Getting the _UserAddPartial as Modal Form starts from here. */

    $(function () {
        const url = '/Admin/User/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $('#btnAdd').click(function () {
            $.get(url).done(function (data) {
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');
            });
        });
        /* Ajax GET / Getting the _UserAddPartial as Modal Form ends here. */
        /* Ajax POST / Posting the FormData as UserAddDto starts from here. */
        placeHolderDiv.on('click', '#btnSave', function (event) {
            event.preventDefault();
            const form = $('#form-user-add');
            const actionUrl = form.attr('action');
            const dataToSend = new FormData(form.get(0));
            $.ajax({
                url: actionUrl,
                type: 'POST',
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    console.log(data);
                    const userAddAjaxModel = jQuery.parseJSON(data);
                    console.log(userAddAjaxModel);
                    const newFormBody = $('.modal-body', userAddAjaxModel.UserAddPartial);
                    placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                    const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                    if (isValid) {
                        placeHolderDiv.find('.modal').modal('hide');
                        dataTable.row.add([
                            userAddAjaxModel.UserDto.User.Id,
                            userAddAjaxModel.UserDto.User.UserName,
                            userAddAjaxModel.UserDto.User.Email,
                            userAddAjaxModel.UserDto.User.PhoneNumber,
                            userAddAjaxModel.UserDto.User.Picture,
                            `<td>
                                    <button class="btn btn-primary btn-sm btn-block btn-update" data-id="userAddAjaxModel.UserDto.User.Id"><span class="fas fa-edit"></span> Düzenle</button>
                                    <button class="btn btn-danger btn-sm btn-block btn-delete" data-id="userAddAjaxModel.UserDto.User.Id"><span class="fas fa-minus-circle"></span> Sil</button>
                                </td>`
                        ]).draw();
                        toastr.success(`${userAddAjaxModel.UserDto.Message}`, 'Başarılı İşlem!');
                    }
                    else {
                        let summaryText = "";
                        $('#validation-summary > ul > li').each(function () {
                            let text = $(this).text();
                            summaryText = `*${text}\n`;
                        });
                        toastr.warning(summaryText);
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    });

    /* Ajax POST / Posting the FormData as UserAddDto ends here. */

    /* Ajax POST / Deleting a User starts from here. */

    $(document).on('click', '.btn-delete', function (event) {
        event.preventDefault();
        const id = $(this).attr('data-id');
        const tableRow = $(`[name="${id}"]`);
        const userName = tableRow.find('td:eq(1)').text();
        Swal.fire({
            title: 'Silmek istediğinize emin misiniz?',
            text: `${userName} adlı kategori silinecektir!`,
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, silmek istiyorum.',
            cancelButtonText: 'Hayır, silmek istemiyorum.'
        }).then((result) => {
            if (result.isConfirmed) {
                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    data: { userId: id },
                    url: '/Admin/User/Delete/',
                    success: function (data) {
                        const userDto = jQuery.parseJSON(data);
                        if (userDto.ResultStatus === 0) {
                            Swal.fire(
                                'Silindi!',
                                `${userDto.User.Name} adlı kategori başarıyla silinmiştir.`,
                                'success'
                            );

                            tableRow.fadeOut(3500);
                        }
                        else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Başarısız İşlem!',
                                text: `${userDto.Message}`,
                            });
                        }
                    },
                    error: function (err) {
                        console.log(err);
                        toastr.error(`${err.responseText}`, "Hata!");
                    }
                });
            }
        });
    });

    //#62 Update'in Modal Form olarak görüntülenmesi
    $(function () {
        const url = '/Admin/User/Update/';
        const placeHolderDiv = $('#modalPlaceHolder');
        $(document).on('click', '.btn-update',
            function (event) {
                event.preventDefault();
                const id = $(this).attr('data-id');
                $.get(url, { userId: id }).done(function (data) {
                    placeHolderDiv.html(data);
                    placeHolderDiv.find('.modal').modal('show');
                }).fail(function () {
                    toastr.error("Bir hata oluştu.");
                });
            });

        /* Ajax POST / Updating a User starts from here */

        placeHolderDiv.on('click', '#btnUpdate', function (event) {
            event.preventDefault();

            const form = $('#form-user-update');
            const actionUrl = form.attr('action');
            const dataToSend = form.serialize();
            $.post(actionUrl, dataToSend).done(function (data) {
                const userUpdateAjaxModel = jQuery.parseJSON(data);
                console.log(userUpdateAjaxModel);
                const newFormBody = $('.modal-body', userUpdateAjaxModel.UserUpdatePartial);
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';
                if (isValid) {
                    placeHolderDiv.find('.modal').modal('hide');
                    const newTableRow = `<tr name="${userUpdateAjaxModel.UserDto.User.Id}">
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.Id}</td>
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.Name}</td>
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.Description}</td>
                                                                                                                                        <td>${convertFirstLetterToUpperCase(userUpdateAjaxModel.UserDto.User.IsActive.toString())}</td>
                                                                                                                                                <td>${convertFirstLetterToUpperCase(userUpdateAjaxModel.UserDto.User.IsDeleted.toString())}</td>
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.Note}</td>
                                                                                                                                <td>${convertToShortDate(userUpdateAjaxModel.UserDto.User.CreatedDate)}</td>
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.CreatedByName}</td>
                                                                                                                                <td>${convertToShortDate(userUpdateAjaxModel.UserDto.User.ModifiedDate)}</td>
                                                                                                                                <td>${userUpdateAjaxModel.UserDto.User.ModifiedByName}</td>
<td>
                                                                    <button class="btn btn-primary btn-sm btn-update" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-edit"></span>Düzenle</button>
                                                                    <button class="btn btn-danger btn-sm btn-delete" data-id="${userUpdateAjaxModel.UserDto.User.Id}"><span class="fas fa-minus-circle"></span>Sil</button>
                                                                </td>
                                                                                                                                </tr>`;
                    const newTableRowObject = $(newTableRow);
                    const userTableRow = $(`[name="${userUpdateAjaxModel.UserDto.User.Id}"]`);
                    newTableRowObject.hide();
                    userTableRow.replaceWith(newTableRowObject);
                    newTableRowObject.fadeIn(3500);
                    toastr.success(`${userUpdateAjaxModel.UserDto.Message}`, "Başarılı İşlem!");
                }
                else {
                    let summaryText = "";
                    $('#validation-summary > ul > li').each(function () {
                        let text = $(this).text();
                        summaryText = `*${text}\n`;
                    });
                    toastr.warning(summaryText);
                }
            }).fail(function (response) {
                console.log(response);
            });
        });

    });
});