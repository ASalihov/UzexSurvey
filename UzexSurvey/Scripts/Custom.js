$(document).ready(function () {
    $('input[type=radio]').change(function () {
        $('input[type=textarea]').find('label.control input').prop('disabled', true);
        }
    );
})