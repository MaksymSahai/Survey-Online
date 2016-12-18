app.controller('SurveyController', function ($scope, SurveyOnlineService) {
    GettByUserID();
    GettSurveyDetail();

    //Function to load all Employee records
    function GettByUserID() {
        var servCall = SurveyOnlineService.getSurveyList(); //The Method Call from service

        servCall.then(function (d) {
            $scope.surveys = d.data;
            $scope.Message = "List of My surveys";
        },
        function (error) {
            $log.error('failure loading Survey', error);
        });
    }

    function GettSurveyDetail() {
        var servCall = SurveyOnlineService.getSurveyDetail(1); //The Method Call from service

        servCall.then(function (d) {
            $scope.survey = d.data;
            $scope.Message = "surveys";
        },
            function (error) {
                $log.error('failure loading Survey', error);
            });
    }
})