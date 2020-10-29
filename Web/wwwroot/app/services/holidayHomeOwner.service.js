angular.module('app')
    .service('HolidayHomeOwnerService', function ($q,$http) {
        var list = [];

        var holidayHomeOwnerService = {
            getOwnersList: function () {
                var deferred = $q.defer();
                
                $http.get(constants.URL.Owner.GetAll)
                    .then(function (response) {
                        list = response.data;
                        deferred.resolve(list);
                    });

                return deferred.promise;
            }
        }

        return holidayHomeOwnerService;
    });