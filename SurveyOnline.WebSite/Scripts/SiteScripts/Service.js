app.service("SurveyOnlineService", function ($http) {
    ///Get All surveys
    this.getSurveyList = function () {
        return $http.get("/api/Survey");
    }

    ///Get Survey detail
    this.getSurveyDetail = function (surveyID) {
        return $http.get("/api/Survey/" + surveyID);
    }
});