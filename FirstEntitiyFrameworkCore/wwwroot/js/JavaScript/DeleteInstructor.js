
var deletedItemId;

function remove(id) {

    deletedItemId = id;

    $(".btn1-clss").hide();
    $(".btn2-clss").show();
    $(".btn2-clss").show();

    $("#modalID").modal('show')
    $(".modal-body").text("Eğer Eğitmeni Silerseniz Eğitmen İle İlişkili Diğer Tüm Veriler Silinecektir. Silmek istediğinize Emin misiniz?")
}



function removeService(controller,action) {

    $.ajax({

        method: "POST",
        url: "/" + controller + "/" + action,
        data: { id: deletedItemId}

    }).then(function (response) {

        if (response) {
            $("#row_"+deletedItemId).hide();
        }

    }).fail(function () {

    })
  
}


function goOn() {

    $(".btn1-clss").show();
    $(".btn2-clss").hide();
    $(".btn2-clss").hide();

    removeService("Instructor","Delete");
}
