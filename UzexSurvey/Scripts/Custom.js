$(document).ready(function () {
    $('input[type=radio]').change(function () {
            $('textarea.rt' + this.value).prop('disabled', false);
            $("textarea.question-id-" + $(this).attr("questionid")).not(".rt" + this.value).each(function () {
                $(this).prop('disabled', true);
            })

            $('input[type=text].rt' + this.value).prop('disabled', false);
            $("input[type=text].question-id-" + $(this).attr("questionid")).not(".rt" + this.value).each(function () {
                $(this).prop('disabled', true);
            })
        }
    );
})