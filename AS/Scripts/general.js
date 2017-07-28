

/*var aplicacion = "Bienvenida";
	alert("Bienvenida a AS")
function darBienvenida({
	alert("Bienvenida a AS")
})*/

/*
$('#ingresar').on('click', darBienvenida);

$('#ingresar').on('click', function({
	alert("Bienvenida a AS");
}))

//para comentario de una linea

$(document).on('ready', function(){

});
*/
/*FIN PRUEBAS!*/

$(document).on('ready', function(){
	/*$('#ingresar').on('click', function(){
		$('#iniciar').addClass('hide');
		$('.menuUsuario').removeClass('hide');

		var email = $('#loginEmail').val();
		$('#nombreUsuario').text(email);
	})

	$('#salir').on('click', function(){
		$('.menuUsuario').addClass('hide');
		$('#iniciar').removeClass('hide');
	});*/

	/*$(window).scroll(function(){
		if (($(window).scrollTop() - $('#navbar').offset().top) > 0){
			$('#navbar').addClass('navbar-fixed-top');
			$('#navbar').removeClass('navbar-default');
			$('#navbar').addClass('navbar-inverse');
		}	else {
			$('#navbar').removeClass('navbar-fixed-top');
			$('#navbar').removeClass('navbar-inverse');
			$('#navbar').addClass('navbar-default');
		}
	});*/
	
	/*window.alert("Bienvenida a nuestro sitio web. Gracias por elegirnos...")*/

	/*$(".img").mouseenter(function(){
        $(this).css({"height": "400px", "widht": "600px"});
    });
    $(".img").mouseleave(function(){
        $(this).css({"height": "200px", "widht": "300px"});
    });*/

    //--

    $("img").mouseover(function () {
        $("img").css({ "height": "400px", "widht": "600px" });
    });
    $("img").mouseout(function () {
        $("img").css({ "height": "200px", "widht": "300px" });
    });




//FIN DOCUMENT READY

});

