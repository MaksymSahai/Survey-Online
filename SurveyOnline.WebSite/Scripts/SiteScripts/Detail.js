app.controller('SurveyController', function ($scope, SurveyOnlineService, $routeParams) {
    GettSurveyDetail();

    ///some comment
    function GettSurveyDetail() {
        var servCall = SurveyOnlineService.getSurveyDetail($routeParams.id); //The Method Call from service

        servCall.then(function (d) {
            $scope.surveys = d.data;
            $scope.Message = "surveys";
        },
        function (error) {
            $log.error('failure loading Survey', error);
        });
    }
})