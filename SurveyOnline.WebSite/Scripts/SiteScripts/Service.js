app.service("SurveyOnlineService", function ($http) {
    this.getSurveyList = function () {
        return $http.get("/api/Survey")
    }
});