angular.module('app')
    .component('holidayHomeOwnersList', {
        templateUrl: 'app/components/holidayHomeOwnersList/holidayHomeOwnersList.component.html',
        bindings: {
            list: '<'
        },
        controllerAs: 'ctrl',
        controller: function ($scope) {
            $ctrl = this;
        }
});