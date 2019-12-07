var table;

//Datayable.net code start here

window.DestroyFetchProjectData = () => {
    if (table != undefined)
        table.destroy();
};

window.FetchProjectData = () => {
    table = $('#programs').DataTable({
        pageLength: 10,
        paging: true,
        searching: false,
        "ordering": true,
        columnDefs: [{
            orderable: false,
            targets: "no-sort"
        }]
    });

};

//Datayable.net code end here

//Custsom multiselect checkbox code
jQuery.fn.multiselect = function () {
    $(this).each(function () {
        var checkboxes = $(this).find("input:checkbox");
        checkboxes.each(function () {
            var checkbox = $(this);
            // Highlight pre-selected checkboxes
            if (checkbox.prop("checked"))
                checkbox.parent().addClass("multiselect-on");

            // Highlight checkboxes that the user selects
            checkbox.click(function () {
                if (checkbox.prop("checked"))
                    checkbox.parent().addClass("multiselect-on");
                else
                    checkbox.parent().removeClass("multiselect-on");
            });
        });
    });
};

//multiselect checkbox 
window.BindCheckBoxes = () => {
    $(".multiselect").multiselect();
};

//Clear all filter code. This code will remove all selection of checkboxes.
window.ClearAllFilters = () => {
    $('input[type="checkbox"]:checked').prop('checked', false);
    $('.multiselect-on').removeClass('multiselect-on');
}

window.CheckboxesHideShowButton = () => {

    if ($("#checkboxes").hasClass('show')) {
        $("#checkboxes").removeClass('show');
    } else {
        $("#checkboxes").addClass('show');
    }

};

//Login form validation.

window.ValidateLogin = () => {

    $("form[name='login']").validate({
        rules: {

            email: {
                required: true,
                email: true
            },
            password: {
                required: true,

            }
        },
        messages: {
            email: "Please enter a valid email address",

            password: {
                required: "Please enter password",
            }
        },
        submitHandler: function (form) {
            window.location.href = "login?paramUsername=" + form["email"].value + "&paramPassword=" + form["password"].value;
        }
    });
}