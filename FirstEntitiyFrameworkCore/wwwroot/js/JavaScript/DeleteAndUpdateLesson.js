


var saveButton;
var editButton;
var cancelButton;
var text;
var reserveText;
var isAvaliable = true;
var deletedID;

function edit(id) {

    if (isAvaliable) {

        isAvaliable = false;

        saveButton = $("#save_" + id)
        editButton = $("#edit_" + id)
        cancelButton = $("#cancel_" + id)
        text = $("#text_" + id)

        text.attr('contenteditable', 'true')
        text.attr('class', "comment-focus pl-1 col-sm-4")
        reserveText = text.text();


        editButton.hide();
        saveButton.show();
        cancelButton.show();

    } else {

        $('#modalID').modal('show')
        $(".modal-body").text("Şuan Zaten Başka Bir Dersi Güncellemektesiniz!")
    }

}

function cancel() {

    isAvaliable = true;
    text.text(reserveText)
    editButton.show();
    saveButton.hide();
    cancelButton.hide();
    text.attr('contenteditable', 'false')
    text.removeClass("comment-focus")
    $(".modal-body").text("")
}

function save(id) {

    serviceUpdate("Lesson", "Update", id, text.text());

    isAvaliable = true;
    editButton.show();
    saveButton.hide();
    cancelButton.hide();
    text.attr('contenteditable', 'false')
    text.removeClass("comment-focus")
    $(".modal-body").text("")

}

function remove(id) {

    deletedID = id;
    $(".btn1-clss").hide();
    $(".btn2-clss").show();
    $(".btn2-clss").show();

    $('#modalID').modal('show')
    $(".modal-body").text("Eğer Dersi Silerseniz Ders İle İlişkili Diğer Tüm Veriler Silinecektir. Silmek istediğinize Emin misiniz?")

}

function goOn() {
    serviceDelete("Lesson", "DeleteLesson", deletedID)
    $(".btn1-clss").show();
    $(".btn2-clss").hide();
    $(".btn2-clss").hide();
}

function serviceDelete(controller, action, id) {

    $.ajax({

        method: "POST",
        url: "/" + controller + "/" + action,
        data: { value: id }

    }).then(function (response) {

        if (response) {
            $("#row_" + id).hide();
        }

    }).fail(function () {

    })

}

function serviceUpdate(controller, action, id, textPar) {

    $.ajax({

        method: "POST",
        url: "/" + controller + "/" + action,
        data: { "id": id, "name": textPar }

    }).then(function (response) {

        if (response) {
            text.text(textPar)
        }

    }).fail(function () {

    })

}