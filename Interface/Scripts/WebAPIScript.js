
    var idBoisson = 0; var idSucre = 0; var mugPerson = false; var idSelection = 0;
    $(document).ready(function () {
        loadBoisson(idBoisson);
        loadSucre(idSucre);
        getLastSelection();
    });
//declarer les constants
const APIHOST = 'http://localhost:58203/Api/WebAPI';
const DATATYPE = 'application/json';
const CONTENTTYPE = 'application/x-www-form-urlencoded; charset=UTF-8';
const ESPACE = '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
//Recuper idBoisson par selection un boisson
    $(document).on('click', "button.typeBoisson", function () {
        idBoisson = $(this).attr('id');
    });
    //Recuper idSucre par selection un quantite Sucre
    $(document).on('click', "input.typeSucre", function () {
        idSucre = $(this).attr('id');
    });
    //MugPerso
    $(document).on('click', "input.mugPerso", function () {
        mugPerson = $(this).attr('value');
    });
    //Create Selection
    $(document).on("click", "#div1 input.selectionChoix", function () {
        var data3 = {'fkBoissonDto': idBoisson, 'fkQuantiteSucreDto': idSucre, 'mugPersonDto': mugPerson };
        $.ajax({
        type: 'POST',
        url: APIHOST,
        datatype: DATATYPE,
        data: JSON.stringify(data3),
        contentType: DATATYPE,
            success: function (data, status, xhr) {
                if (status == 'success') {
                    if (data == null)
                        $("#message").html("Aucune information trouvee !");
                        else {
                            $("#message").remove();
                            $('#message').append('information envoyé');
                         }
                    }
                else
                    $("#message").html("problème avec les données reçues2");
            },
            error: function (xhr, status, error) {
                    $("#message").html("erreur de communication");
            }
        });
        goWait();
    });
    //Choose last Selection
    $(document).on("click", "#lastChoice", function () {
        idBoisson = $(".lastBoisson").attr('id');
        idSucre = $(".lastSucre").attr('id');
        mugPerson = $(".lastMug").attr('id');
        var data3 = {'fkBoissonDto': idBoisson, 'fkQuantiteSucreDto': idSucre, 'mugPersonDto': mugPerson };
        $.ajax({
            type: 'POST',
            url: APIHOST,
            datatype: DATATYPE,
            data: JSON.stringify(data3),
            contentType: DATATYPE,
            success: function (data, status, xhr) {
                if (status == 'success') {
                    if (data == null)
                        $("#message").html("Aucune information trouvee !");
                    else {
                            $("#message").remove();
                            $('#message').append('information envoyé');
                    }
                }
                else
                    $("#message").html("problème avec les données reçues2");
            },
            error: function (xhr, status, error) {
                $("#message").html("erreur de communication");
            }
        });
        goWait();
    });
    //get boisson
    function loadBoisson(idBoisson) {
        $.ajax({
            type: 'GET',
            url: APIHOST + "?idBoisson=" + idBoisson,
            datatype: DATATYPE,
            contentType: CONTENTTYPE,
            success: function (data, status, xhr) {
                if (status == 'success') {
                    if (data == null)
                        $("#message").html("Aucune information trouvee !");
                    else {
                        $.each(data, function () {
                            $('#contentBoisson').append('<button id=' + '"' + this.IdDto + '"' + 'class=' + '"' + 'typeBoisson btn btn-block' + '"' + '>' + this.NomBoissonDto + '</button>');
                        });
                    }
                }
                else
                    $("#message").html("problème avec les données reçues");
            },
            error: function (xhr, status, error) {
                $("#message").html("erreur de communication 0");
            }
        });
    }
    //get Sucre
    function loadSucre(idSucre) {
        $.ajax({
            type: 'GET',
            url: APIHOST + "?idSucre=" + idSucre,
            datatype: DATATYPE,
            contentType: CONTENTTYPE,
            success: function (data, status, xhr) {
                if (status == 'success') {
                    if (data == null)
                        $("#message").html("Aucune information trouvee !");
                    else {
                        $.each(data, function () {
                            //<input type="radio" id="mugPerso" name="selection" value="true" />
                            $('#contentSucre').append(
                                '<input type=' + '"' + 'checkbox' + '"' + 'id=' + '"' + this.IdDto + '"' + 'class=' + '"' + 'typeSucre btn' + '"' + '>' + this.QuantiteDto + '</input>' + ESPACE);
                        });
                    }
                }
                else
                    $("#message").html("problème avec les données reçues");
            },
            error: function (xhr, status, error) {
                $("#message").html("erreur de communication 0");
            }
        });
    }
    //get last Selection
    function getLastSelection() {
        $.ajax({
            type: 'GET',
            url: APIHOST + "?idSelection=" + idSelection,
            datatype: DATATYPE,
            contentType: CONTENTTYPE,
            success: function (data, status, xhr) {
                if (status == 'success') {
                    if (data == null)
                        $("#message").html("Aucune information trouvee !");
                    else {
                        $("#contentLast td").remove();
                        $('#contentLast').append('<td id=' + '"' + data.FkBoissonDto + '"' + 'class=' + '"' + 'lastBoisson' + '"' + '>' + data.NomBoissonDto + '</td>');
                        $('#contentLast').append('<td id=' + '"' + data.FkQuantiteSucreDto + '"' + 'class=' + '"' + 'lastSucre' + '"' + '>' + data.QuantitySucreDto + '</td>');
                        $('#contentLast').append('<td id=' + '"' + data.MugPersonDto + '"' + 'class=' + '"' + 'lastMug' + '"' + '>' + data.MugPersonDto == true ? 'oui' : 'non' + '</td>');
                        $('#contentLast').append('<td><input type=' + '"' + 'submit' + '"' + 'id=' + '"' + 'lastChoice' + '"' + '/></td>');
                    }
                }
                else
                    $("#message").html("problème avec les données reçues");
            },
            error: function (xhr, status, error) {
                $("#message").html("erreur de communication 0");
            }
        });
}
    //function go to page 
    function goWait() {
        window.location.href = "/Home/Service";
    }
    //set color button
    var count = 1;
    function setColor(btn, color) {
        var property = document.getElementById(btn);
        if (count == 0) {
            property.style.backgroundColor = "#FFFFFF";
            count = 1;
        }
        else {
            property.style.backgroundColor = "#7FFF00";
            count = 0;
        }
    }
