(function ($) {

    var _employeeService = abp.services.app.employee,
        l = abp.localization.getSource('MovieMVC'),
        _$modal = $('#EmployeeCreateModal'),
        _$form = _$modal.find('form'),
        _$table = $('#EmployeeTable');

    var _$employeeTable = _$table.DataTable({
        paging: true,
        serverSide: true,
        ajax: function (data, callback, settings) {
            var filter = $('#UsersSearchForm').serializeFormToObject(true);
            filter.maxResultCount = data.length;
            filter.skipCount = data.start;

            abp.ui.setBusy(_$table);
            _employeeService.getEmployee(filter).done(function (result) {
                callback({
                    recordsTotal: result.totalCount,
                    recordsFiltered: result.totalCount,
                    data: result.items
                });
            }).always(function () {
                abp.ui.clearBusy(_$table);
            });
        },
        buttons: [
            {
                name: 'refresh',
                text: '<i class="fas fa-redo-alt"></i>',
                action: () => _$employeeTable.draw(false)
            }
        ],
        responsive: {
            details: {
                type: 'column'
            }
        },
        columnDefs: [
            {
                targets: 0,
                data: 'name',
                sortable: false
            },
            {
                targets: 1,
                data: 'gender',
                sortable: false
            },
            {
                targets: 2,
                data: 'birthDate',
                sortable: false
            },
            {
                targets: 3,
                data: 'emailAddress',
                sortable: false
            },
            {
                targets: 4,
                data: 'jobs',
                sortable: false,
            },
            {
                targets: 5,
                data: null,
                sortable: false,
                autoWidth: false,
                defaultContent: '',
                render: (data, type, row, meta) => {
                    return [
                        `   <button type="button" class="btn btn-sm bg-secondary edit-user" data-user-id="${row.id}" data-toggle="modal" data-target="#UserEditModal">`,
                        `       <i class="fas fa-pencil-alt"></i> ${l('Edit')}`,
                        '   </button>',
                        `   <button type="button" class="btn btn-sm bg-danger delete-user" data-user-id="${row.id}" data-user-name="${row.name}">`,
                        `       <i class="fas fa-trash"></i> ${l('Delete')}`,
                        '   </button>'
                    ].join('');
                }
            }
        ]
    });

    //_$form.validate({
    //    rules: {
    //        Password: "required",
    //        ConfirmPassword: {
    //            equalTo: "#Password"
    //        }
    //    }
    //});

    _$form.find('.save-button').on('click', (e) => {
        e.preventDefault();
        if (!_$form.valid()) {
            return;
        }

        var employee = _$form.serializeFormToObject();

        abp.ui.setBusy(_$modal);
        _employeeService.createEmployee(employee).done(function () {
            _$modal.modal('hide');
            _$form[0].reset();
            abp.notify.info(l('SavedSuccessfully'));
            _$employeeTable.ajax.reload();
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    });

    //$(document).on('click', '.delete-user', function () {
    //    var userId = $(this).attr("data-user-id");
    //    var userName = $(this).attr('data-user-name');

    //    deleteUser(userId, userName);
    //});

    //function deleteUser(userId, userName) {
    //    abp.message.confirm(
    //        abp.utils.formatString(
    //            l('AreYouSureWantToDelete'),
    //            userName),
    //        null,
    //        (isConfirmed) => {
    //            if (isConfirmed) {
    //                _userService.delete({
    //                    id: userId
    //                }).done(() => {
    //                    abp.notify.info(l('SuccessfullyDeleted'));
    //                    _$usersTable.ajax.reload();
    //                });
    //            }
    //        }
    //    );
    //}

    $(document).on('click', '.edit-user', function (e) {
        var userId = $(this).attr("data-user-id");

        e.preventDefault();
        abp.ajax({
            url: abp.appPath + 'Users/EditModal?userId=' + userId,
            type: 'POST',
            dataType: 'html',
            success: function (content) {
                $('#UserEditModal div.modal-content').html(content);
            },
            error: function (e) { }
        });
    });

    $(document).on('click', 'a[data-target="#EmployeeCreateModal"]', (e) => {
        $("#datepicker").datepicker();
        $('a[data-target="#EmployeeCreateModal"]').show();
    });

    //abp.event.on('user.edited', (data) => {
    //    _$usersTable.ajax.reload();
    //});

    //_$modal.on('shown.bs.modal', () => {
    //    _$modal.find('input:not([type=hidden]):first').focus();
    //}).on('hidden.bs.modal', () => {
    //    _$form.clearForm();
    //});

    //$('.btn-search').on('click', (e) => {
    //    _$usersTable.ajax.reload();
    //});

    //$('.txt-search').on('keypress', (e) => {
    //    if (e.which == 13) {
    //        _$usersTable.ajax.reload();
    //        return false;
    //    }
    //});
})(jQuery);
