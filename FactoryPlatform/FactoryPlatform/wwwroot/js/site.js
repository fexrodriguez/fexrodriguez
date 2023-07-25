
// Write your JavaScript code.
toastr.options = {
    "closeButton": true,
    "debug": true,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-center",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "500",
    "hideDuration": "1000",
    "timeOut": "6000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};

function getKeyCode(tecla) {
    tecla = (window.event) ? event : tecla;
    intKey = (tecla.keyCode) ? tecla.keyCode : tecla.charCode;
    return intKey;
}


//Alert for session Expired
function swalExpired(){
    let timerInterval
    Swal.fire({
        title: 'Your Session has Expired!',
        html: 'I will to Redirect the Login',
        allowEscapeKey: false,
        allowOutsideClick: false,
        timer: 4000,
        timerProgressBar: true,
        didOpen: () => {
            Swal.showLoading()
            const b = Swal.getHtmlContainer().querySelector('b')
            timerInterval = setInterval(() => {
                b.textContent = Swal.getTimerLeft()
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
            location.reload()
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            console.log('I was closed by the timer')
        }
    })
}



function swalErrorServer() {
    let timerInterval
    Swal.fire({
        title: 'Error of sever!',
        html: 'I will to refresh the page',
        allowEscapeKey: false,
        allowOutsideClick: false,
        timer: 4000,
        timerProgressBar: true,
        didOpen: () => {
            Swal.showLoading()
            const b = Swal.getHtmlContainer().querySelector('b')
            timerInterval = setInterval(() => {
                b.textContent = Swal.getTimerLeft()
            }, 100)
        },
        willClose: () => {
            clearInterval(timerInterval)
            location.reload()
        }
    }).then((result) => {
        /* Read more about handling dismissals below */
        if (result.dismiss === Swal.DismissReason.timer) {
            console.log('I was closed by the timer')
        }
    })
}


//This alert is used when the users no have the page or subsection linked
function swalNoAuthorized() {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'You do not have access to the last action!'
    })
    BlockPantalla.release();
}

//Used for the errors of the sytem server
function SystemServerError()
{
    toastr.error("An error occurred on the server, please contact the Admin!");
}


/*Esta funcion sirve para que no se muevan las columnas cuando se colapsa el asidemenu*/
$("#kt_body").click(function () {
    $('.dataTables_scrollHeadInner').css('width', '100%');
});


