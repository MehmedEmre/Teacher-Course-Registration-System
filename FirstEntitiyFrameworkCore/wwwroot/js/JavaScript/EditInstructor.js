


var elementId;
var state = false;
var branchId;
var lessonId;
var teacherId;
var newLessonId;
var newBranchId;
var currentCard;

function Switch(clssName,sid,tId,card) {


    if (!state) {
        $("." + clssName).removeAttr("disabled")//select list enable edildi
        $("#" + sid).removeClass("value")//o anki checkbox'ın class değeri olan value kaldırıldı
        $(".value").attr("disabled", "disabled")//tüm checkboxlar disabled edildi       
        $(".custom-control-label").attr('onclick', 'warningMessage()')//tüm labellara click eventi eklendi     
        $("#" + sid).next().removeAttr("onclick")//o anki checkbox'ın labelından click eventi kaldırıldı
        state = true;
        elementId = clssName;

        branchId = $("." + clssName)[0].value;
        lessonId = $("." + clssName)[1].value;
        teacherId = tId;
        currentCard = card;

        if (clssName != "nameAndSurname") {

            $.ajax({

                method: "POST",
                url: "/Instructor/SetInstructorProperty",
                data: { lessonId: lessonId }

            }).then(function (response) {
                console.log("SetInstructorProperty success")


                $("#2" + clssName + " option").remove()

                for (let i = 0; i < response.lessonList.length; i++) {

                    $("#2" + clssName).append(`<option value="${response.lessonList[i].value}">${response.lessonList[i].text}</option>`)
                }

            }).fail(function (response) {
                console.log("SetInstructorProperty fail")
                console.log(response)
            })
        } 


    } else {

        newBranchId = $("." + clssName)[0].value;
        newLessonId = $("." + clssName)[1].value;
       
            if (elementId == clssName) {
                $("." + clssName).attr("disabled", "disabled")//select list disable edildi
                $(".value").removeAttr("disabled")//tüm checkboxların disabledı kaldırıldı.
                $("#" + sid).addClass("value")//o anki checkbox'ın class değerine value eklendi
                $(".custom-control-label").removeAttr('onclick')//tüm labellerdan click eventi kaldırıldı       
                state = false;

                if (clssName != "nameAndSurname") {

                    $.ajax({

                        method: "POST",
                        url: "/Instructor/ChangeInstructorProperty",
                        data: { newBranchId: newBranchId, branchId: branchId, lessonId: lessonId, newLessonId: newLessonId, teacherId: teacherId }

                    }).then(function (response) {
                        console.log("ChangeInstructorProperty success")

                        if (response.state) {
                            $("#" + currentCard).fadeOut("slow");
                        }

                    }).fail(function (response) {
                        console.log("ChangeInstructorProperty fail")
                        console.log(response)
                    })
                } else {

                    let name = $("." + clssName)[1].value;
                    let surname = $("." + clssName)[2].value


                    $.ajax({
                        method: "POST",
                        url:"/Instructor/ChangeNameProperty",
                        data: { name: name, surname: surname, id: tId}
                    }).then(function (response) {

                        if (response.state) {

                            $("." + clssName)[0].textContent = `Eğitmen ${response.name} ${response.surname} İçin Ders Ve Branş Kaydı`;

                            $("." + clssName)[1].textContent = response.name;
                            $("." + clssName)[2].textContent = response.surname;
                        }
                    })
                    
                }

            }
        

     
    }

}

function warningMessage() {

    $.ajax({
        method: "POST",
        url: "/Instructor/warningMessage"
    }).then(function (response) {

    }).fail(function (response) {
 
    })

}

function branchWarningMessage(textId1, listId, swtch, textId2) {

    let val = $("." + listId)[0].value;
   
        $.ajax({

            url: "/Instructor/EndBranch",
            data: { teacherId: teacherId, val: val}

        }).then(function (response) {

            if (response.state) {//eğer bir tane branş kalmışsa
               
                if (val == -1) {
                    $("#" + textId2).removeClass("ml-1 d-none")
                    $("#" + textId2).addClass("ml-1");
                    $("#" + swtch).attr("disabled", "disabled")
                } else {
                    $("#" + textId2).removeClass("ml-1")
                    $("#" + textId2).addClass("ml-1 d-none");
                    $("#" + swtch).removeAttr("disabled")
                }
            } else {

                if (val == -1) {

                        $("#" + textId1).removeClass("ml-1 d-none")
                        $("#" + textId1).addClass("ml-1");

                    
                } else {
                    $("#" + textId1).removeClass("ml-1")
                    $("#" + textId1).addClass("ml-1 d-none");
                    
                } 
            }

        })

       




}




