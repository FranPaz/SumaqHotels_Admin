sumaqHotelsApp.controller('habitacionesCtrl', function ($scope, $stateParams, $state, $filter, ngTableParams, habitacionesDataFactory, listadoHabitaciones, infoHabitacion) {

    $scope.tipoHabBuscada = {};
    $scope.tiposHab = [
        { Nombre: 'Single' },
        { Nombre: 'Doble' },
        { Nombre: 'Presidencial' }
    ];

});