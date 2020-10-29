angular.module('app')
    .component('holidayHomeOwners', {
        templateUrl: 'app/components/holidayHomeOwners/holidayHomeOwners.component.html',
        controllerAs: 'ctrl',
        controller: function ($scope, HolidayHomeOwnerService) {
            $ctrl = this;

            //Gets owners list from service
            HolidayHomeOwnerService.getOwnersList().then(function (data) {
                $scope.list = data;
            });
        }
});