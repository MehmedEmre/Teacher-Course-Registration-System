
let cardId;

function show(id, clssName, clssName2,restart) {

    if (restart) {
        $("#" + id).fadeToggle();
    }
    

    cardId = id;

    $.ajax({

        method: "POST",
        url: "/Branch/LoadTeacher"

    }).then(function (response) {
  
     
        $("." + clssName + " option").remove()
        $("." + clssName2 + " option").remove()

        $("." + clssName2).append(`<option value="-1">Önce Bir Eğitmen Seçiniz</option>`)

        $("." + clssName).append(`<option value="-1">Bir Eğitmen Seçiniz</option>`)

       for (let i = 0; i < response.list.length; i++) {

           $("." + clssName).append(`<option value="${response.list[i].value}">${response.list[i].text}</option>`)
       }

       


    })

}



function LoadBranch(clssName1, clssName2) {


    let teacherId = $("." + clssName1)[0].value;


    $.ajax({

        method: "POST",
        url: "/Branch/LoadBranch",
        data: { id: teacherId }

    }).then(function (response) {


        $("." + clssName2 + " option").remove()


        if (response.state) {

            $("." + clssName2).append(`<option value="-1">Bir Branş Seçiniz</option>`)

            for (let i = 0; i < response.list.length; i++) {

                $("." + clssName2).append(`<option value="${response.list[i].value}">${response.list[i].text}</option>`)
            }
        } else {

            $("." + clssName2).append(`<option value="-1">Uygun Branş Bulunamadı!</option>`)
        }


    })

}

function registerBranch(clss1, clss2) {

    let teacherId = $("." + clss1)[0].value
    let branchId = $("." + clss2)[0].value


    $.ajax({

        method:"POST",
        url: "/Branch/RegisterTeacherBranch",
        data: { tid: teacherId, bid: branchId}

    }).then(function (response) {

        show(cardId, clss1, clss2,false)
    })

}