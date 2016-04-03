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


    $.validator.addMethod('required_group', function (value, element) {
                                                var $module = $(element).parents('form');
                                                return $('.required_group:checked').size() > 0;
                                            },
                          'Select at least one Service please');
    $.validator.addClassRules('required-checkbox', { 'required_group': true });
})