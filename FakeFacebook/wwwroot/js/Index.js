





function Starter() {
    var myParent = document.getElementById("test");

    var selectList = document.createElement("select");

    selectList.id = "H-I-Year";
    selectList.name = "Year";


    myParent.appendChild(selectList);

    for (var i = 2020; i > 1950; i--) {
        var option = document.createElement("option");
        option.value = i;
        option.text = i;

        selectList.appendChild(option);
    }




    var months = ["Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"]

    var parent = document.getElementById("test");

    var selectlist3 = document.createElement("select");

    selectlist3.id = "H-I-Month";
    selectList3.id = "Month";



    parent.appendChild(selectlist3);

    for (var i = 0; i < 12; i++) {


        var option = document.createElement("option");

        option.value = months[i];
        option.text = months[i];


        selectlist3.appendChild(option);



    }













    var parent = document.getElementById("H-I-SignUp");

    var input2 = document.createElement("input");
    input2.type = selectList2;


    var selectList2 = document.createElement("select");

    selectList2.id = "H-I-Date";
    selectlist3.name = "Day";

    parent.appendChild(selectList2);


    if (selectlist3.value == "Styczeń" || selectlist3.value == "Marzec" || options.value == "Maj" || options.value == "Lipiec" || options.value == "Sierpień" || options.value == "Październik" || options.value == "Wrzesień") {

        for (var i = 1; i < 32; i++) {
            var option = document.createElement("option");
            option.value = i;
            option.text = i;

            selectList2.appendChild(option);
        }
    }
    else {
        for (var i = 1; i < 31; i++) {
            var option = document.createElement("option");
            option.value = i;
            option.text = i;


            selectList2.appendChild(option);
        }
    }







}

