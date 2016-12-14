app.controller('SurveyController', function ($scope, SurveyOnlineService) {
    GettByUserID();

    function GettByUserID() {
        var servCall = SurveyOnlineService.getSurveyList();
        servCall.then(function (d) {
            $scope.surveys = d.data;
            $scope.Message = "List of My surveys";
        }, function (error) {
        })
    }
})